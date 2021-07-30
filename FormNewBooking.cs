using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Bay_View_Hotel.Tables;

namespace Bay_View_Hotel
{
    public partial class FormNewBooking : Form
    {
        public FormNewBooking()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;

        Customer customer = new Customer();

        List<AvailableRooms> availableRooms = new List<AvailableRooms>();

        int bookingCost;
        string roomType;

        private void tsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRoom;
        }

        private void FormNewBooking_Load(object sender, EventArgs e)
        {
            //staffno automatically populated to logged in user
            txtStaffNo.Text = SystemVariables.LoggedInUser.StaffNo.ToString();
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCustomer;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var customerFound = false;
                //grabs customer from entered id
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    string sql = @"SELECT * FROM Customer WHERE CustomerNo = $custno";
                    sql_cmd = dbCon.CreateCommand();
                    sql_cmd.CommandText = sql;
                    sql_cmd.Parameters.AddWithValue("$custno", Convert.ToInt32(txtSearchCustomer.Text));

                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customerFound = true;
                            customer.CustomerNo = Convert.ToInt32(reader["CustomerNo"]);
                            customer.CustomerName = (string)reader["CustomerName"];
                            customer.Address = (string)reader["Address"];
                        }
                    }
                }

                if (customerFound)
                {
                    //asks user if the correct customer is returned
                    DialogResult dialog;
                    dialog = MessageBox.Show("Customer: " + customer.CustomerName + " found with CustomerNo: " + customer.CustomerNo, "Is this correct?", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        txtCustomerNo.Text = customer.CustomerNo.ToString();
                        tabControl1.SelectedTab = tabBooking;
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found. Please try again.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Add this customer and insert them onto the booking?", "Proceed?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    int result = 0;
                    //logic to add customer
                    using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                    {
                        dbCon.Open();
                        string sql = @"INSERT INTO Customer (CustomerName, Address, City, Postcode, DOB) VALUES ($custname, $address, $city, $postcode, $dob)";
                        sql_cmd = dbCon.CreateCommand();
                        sql_cmd.CommandText = sql;
                        sql_cmd.Parameters.AddWithValue("$custname", txtNewCustomerName.Text);
                        sql_cmd.Parameters.AddWithValue("$address", txtNewCustomerAddress.Text);
                        sql_cmd.Parameters.AddWithValue("$city", txtNewCustomerCity.Text);
                        sql_cmd.Parameters.AddWithValue("$postcode", txtNewCustomerPostcode.Text);
                        sql_cmd.Parameters.AddWithValue("$dob", Convert.ToDateTime(txtNewCustomerDOB.Text).ToString("yyyy-MM-dd"));

                        result = sql_cmd.ExecuteNonQuery();
                    }

                    //this means that sql was successful if true
                    if (result == 1)
                    {
                        //grabs new customer from database
                        using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                        {
                            dbCon.Open();
                            string sql = @"SELECT * FROM Customer WHERE CustomerName = $custname AND Address = $address";
                            sql_cmd = dbCon.CreateCommand();
                            sql_cmd.CommandText = sql;
                            sql_cmd.Parameters.AddWithValue("$custname", txtNewCustomerName.Text);
                            sql_cmd.Parameters.AddWithValue("$address", txtNewCustomerAddress.Text);

                            using (var reader = sql_cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    customer.CustomerNo = Convert.ToInt32(reader["CustomerNo"]);
                                    customer.CustomerName = (string)reader["CustomerName"];
                                    customer.Address = (string)reader["Address"];
                                    customer.City = (string)reader["City"];
                                    customer.Postcode = (string)reader["Postcode"];
                                    customer.DOB = (string)reader["DOB"];
                                    txtNewCustomerNo.Text = customer.CustomerNo.ToString();
                                    txtCustomerNo.Text = customer.CustomerNo.ToString();
                                }
                            }
                        }

                        MessageBox.Show("Customer Successfully Added! Proceeding to main booking screen");
                        tabControl1.SelectedTab = tabBooking;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while trying to add the customer. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }

        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            try
            {
                availableRooms = new List<AvailableRooms>();
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    //SQL logic filters out the dates from bookings that reside within the 2 given dates and then lets the staff member book within those gaps
                    string sql = @"SELECT * FROM (
	                                SELECT 
		                                b.RoomNo,
		                                Lag(EndDate, 1) OVER ( ORDER BY StartDate) AS AvailableFrom,
		                                StartDate AS AvailableTo,
                                        r.RoomType
	                                FROM
		                                Booking b
	                                JOIN
		                                room r on r.roomno = b.roomno
	                                WHERE
		                                r.RoomType = $roomtype AND
		                                $isaccessible IN (IsAccessible, 0)
                                )
                                WHERE (AvailableFrom >= $startdate and AvailableFrom <= $enddate) or (AvailableTo >= $startdate and AvailableTo <= $enddate)
                                UNION
                                SELECT
	                                RoomNo,
	                                $startdate AS AvailableFrom,
	                                $enddate AS AvailableTo,
                                    RoomType
                                FROM
	                                Room
                                WHERE
	                                RoomNo NOT IN (select roomno from booking where (startdate >= $startdate and startdate <= $enddate) or (enddate >= $startdate and enddate <= $enddate)) AND RoomType = $roomtype AND $isaccessible IN (IsAccessible, 0)";
                    sql_cmd = dbCon.CreateCommand();
                    sql_cmd.CommandText = sql;
                    sql_cmd.Parameters.AddWithValue("$roomtype", cbRoomType.Text);
                    sql_cmd.Parameters.AddWithValue("$isaccessible", cbSearchAccessible.Checked ? 1 : 0);
                    sql_cmd.Parameters.AddWithValue("$startdate", dtSearchStartDate.Value.ToString("yyyy-MM-dd"));
                    sql_cmd.Parameters.AddWithValue("$enddate", dtSearchEndDate.Value.ToString("yyyy-MM-dd"));

                    using (var reader = sql_cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableRooms.Add(new AvailableRooms
                            {
                                RoomNo = Convert.ToInt32(reader["RoomNo"]),
                                AvailableFrom = Convert.ToDateTime(reader["AvailableFrom"]),
                                AvailableTo = Convert.ToDateTime(reader["AvailableTo"]),
                                RoomType = (string)reader["RoomType"]
                            });
                        }
                    }

                    txtSelectedNights.Enabled = true;
                    txtSelectedGuests.Enabled = true;
                }

                lstAvailableRooms.Items.Clear();
                for (var i = 0; i < availableRooms.Count(); i++)
                {
                    lstAvailableRooms.Items.Add("Room " + availableRooms[i].RoomNo + " Available between " + availableRooms[i].AvailableFrom.ToString("dd/MM/yyyy") + " and " + availableRooms[i].AvailableTo.ToString("dd/MM/yyyy"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void lstAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelectedRoomNo.Text = availableRooms[lstAvailableRooms.SelectedIndex].RoomNo.ToString();
            dtSelectedStart.MinDate = availableRooms[lstAvailableRooms.SelectedIndex].AvailableFrom;
            dtSelectedStart.MaxDate = availableRooms[lstAvailableRooms.SelectedIndex].AvailableTo;
            dtSelectedStart.Value = dtSelectedStart.MinDate;
        }

        private void btnConfirmRoom_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txtSelectedRoomNo.Text))
                {
                    MessageBox.Show("Please select a room from the list");
                }
                else if (dtSelectedStart.Value.AddDays(Convert.ToInt32(txtSelectedNights.Text)) > dtSelectedStart.MaxDate)
                {
                    MessageBox.Show("This booking overlaps with another");
                }
                else if (Convert.ToInt32(txtSelectedGuests.Text) > 4 && cbRoomType.Text == "Family")
                {
                    MessageBox.Show("A family room can't have more than 4 guests");
                }
                else if (Convert.ToInt32(txtSelectedGuests.Text) > 4 && cbRoomType.Text == "Double")
                {
                    MessageBox.Show("A double room can't have more than 2 guests");
                }
                else if (Convert.ToInt32(txtSelectedGuests.Text) > 1 && cbRoomType.Text == "Single")
                {
                    MessageBox.Show("A single room can't have more than 1 guest");
                }
                else
                {
                    DialogResult dialog;
                    dialog = MessageBox.Show("Add these details onto the booking?", "Proceed?", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        txtRoomNo.Text = txtSelectedRoomNo.Text;
                        txtStartDate.Text = dtSelectedStart.Value.ToString("yyyy-MM-dd");
                        txtEndDate.Text = dtSelectedStart.Value.AddDays(Convert.ToInt32(txtSelectedNights.Text)).ToString("yyyy-MM-dd");
                        txtGuests.Text = txtSelectedGuests.Text;

                        roomType = availableRooms[lstAvailableRooms.SelectedIndex].RoomType;
                        tabControl1.SelectedTab = tabBooking;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtRoomNo.Text) || String.IsNullOrEmpty(txtStartDate.Text) || String.IsNullOrEmpty(txtEndDate.Text) || String.IsNullOrEmpty(txtGuests.Text))
                {
                    MessageBox.Show("Please go to the Room tab to complete this booking.");
                }
                else if (String.IsNullOrEmpty(txtCustomerNo.Text))
                {
                    MessageBox.Show("Please go to the customer screen to complete this booking");
                }
                else
                {
                    if (roomType == "Single")
                    {
                        bookingCost = cbBreakfast.Checked ? 75 : 70;
                    }
                    else if (roomType == "Double")
                    {
                        if (txtGuests.Text == "1")
                        {
                            bookingCost = cbBreakfast.Checked ? 95 : 90;
                        }
                        else
                        {
                            bookingCost = cbBreakfast.Checked ? 120 : 110;
                        }
                    }
                    else
                    {
                        bookingCost = cbBreakfast.Checked ? 175 : 160;
                    }

                    bookingCost = (Convert.ToDateTime(txtEndDate.Text) - Convert.ToDateTime(txtStartDate.Text)).Days * bookingCost;

                    DialogResult dialog;
                    dialog = MessageBox.Show("Booking cost is £" + bookingCost.ToString() + ", does the customer wish to proceed?", "Proceed?", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                        {
                            dbCon.Open();
                            string sql = @"INSERT INTO Booking (RoomNo, StaffNo, CustomerNo, BookingDate, StartDate, EndDate, NumberOfGuests, IsBreakfastIncluded, BookingCost) VALUES ($roomno, $staffno, $customerno, $bookingdate, $startdate, $enddate, $numberofguests, $isbreakfastincluded, $bookingcost)";
                            sql_cmd = dbCon.CreateCommand();
                            sql_cmd.CommandText = sql;
                            sql_cmd.Parameters.AddWithValue("$roomno", Convert.ToInt32(txtRoomNo.Text));
                            sql_cmd.Parameters.AddWithValue("$staffno", Convert.ToInt32(txtStaffNo.Text));
                            sql_cmd.Parameters.AddWithValue("$customerno", Convert.ToInt32(txtCustomerNo.Text));
                            sql_cmd.Parameters.AddWithValue("$bookingdate", new DateTime().ToString("yyyy-MM-dd"));
                            sql_cmd.Parameters.AddWithValue("$startdate", txtStartDate.Text);
                            sql_cmd.Parameters.AddWithValue("$enddate", txtEndDate.Text);
                            sql_cmd.Parameters.AddWithValue("$numberofguests", Convert.ToInt32(txtGuests.Text));
                            sql_cmd.Parameters.AddWithValue("$isbreakfastincluded", cbBreakfast.Checked ? 1 : 0);
                            sql_cmd.Parameters.AddWithValue("$bookingcost", bookingCost);

                            sql_cmd.ExecuteNonQuery();
                        }

                        DialogResult dialogTwo;
                        dialogTwo = MessageBox.Show("Booking Created! Would you like to exit booking screen?", "Exit?", MessageBoxButtons.YesNo);
                        if (dialogTwo == DialogResult.Yes)
                        {
                            FormHome frmHome = new FormHome();
                            frmHome.FormClosed += (s, args) => this.Close();
                            frmHome.Show();
                        }
                        else
                        {
                            FormNewBooking frmNewBooking = new FormNewBooking();
                            frmNewBooking.FormClosed += (s, args) => this.Close();
                            frmNewBooking.Show();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }

        private void txtNewCustomerDOB_Enter(object sender, EventArgs e)
        {
            if (txtNewCustomerDOB.Text == "yyyy-mm-dd")
            {
                txtNewCustomerDOB.Text = String.Empty;
            }
        }

        private void txtNewCustomerDOB_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNewCustomerDOB.Text))
            {
                txtNewCustomerDOB.Text = "yyyy-mm-dd";
            }
        }
    }
}
