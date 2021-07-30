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

namespace Bay_View_Hotel
{
    public partial class FormEditBooking : Form
    {
        public FormEditBooking()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon;
        DataTable dt;
        SQLiteDataAdapter adpt;

        string roomType;

        private void btnShowNonCancelled_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        adpt = new SQLiteDataAdapter("select * from Booking", dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        EditGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowCancelledBooking_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        adpt = new SQLiteDataAdapter("select Booking.*, Room.RoomType from Booking join Room on Room.RoomNo = Booking.RoomNo where BookingNo =" + txtFindBooking.Text, dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        EditGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (dpStartDate.Value > dpEndDate.Value)
                {
                    MessageBox.Show("Dates incorrect");
                    return;
                }
                int recordsChanged = 0;
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        dbcmd.CommandText = @"SELECT * FROM Booking WHERE RoomNo = $roomno AND StartDate >= $startdate AND StartDate < $enddate AND BookingNo <> $bookingno";
                        dbcmd.Parameters.AddWithValue("$roomno", Convert.ToInt32(txtRoomNo.Text));
                        dbcmd.Parameters.AddWithValue("$startdate", dpStartDate.Value.ToString("yyyy-MM-dd"));
                        dbcmd.Parameters.AddWithValue("$enddate", dpEndDate.Value.ToString("yyyy-MM-dd"));
                        dbcmd.Parameters.AddWithValue("$bookingno", Convert.ToInt32(txtBookingNo.Text));

                        dbCon.Open();
                        recordsChanged = dbcmd.ExecuteNonQuery();
                        dbCon.Close();
                    }
                }
                if (recordsChanged >= 1)
                {
                    MessageBox.Show("Booking Dates overlap with another");
                }
                else
                {
                    int bookingCost = 0;
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

                    bookingCost = (dpStartDate.Value - dpEndDate.Value).Days * bookingCost;

                    var dialog = MessageBox.Show("Booking cost is now £" + bookingCost.ToString() + ", does the customer wish to proceed?", "Proceed?", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                        {
                            txtStaffNo.Text = SystemVariables.LoggedInUser.StaffNo.ToString();
                            using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                            {
                                dbcmd.CommandText = @"Update Booking Set StaffNo=$staff, StartDate=$startdate, EndDate=$enddate, NumberOfGuests=$guest, IsBreakfastIncluded=$breakfast, BookingCost=$cost Where BookingNo=$bookingno";
                                dbcmd.Parameters.AddWithValue("$staff", Convert.ToInt32(txtStaffNo.Text));
                                dbcmd.Parameters.AddWithValue("$startdate", dpStartDate.Value.ToString("yyyy-MM-dd"));
                                dbcmd.Parameters.AddWithValue("$enddate", dpEndDate.Value.ToString("yyyy-MM-dd"));
                                dbcmd.Parameters.AddWithValue("$guest", Convert.ToInt32(txtGuests.Text));
                                dbcmd.Parameters.AddWithValue("$breakfast", cbBreakfast.Checked ? 1 : 0);
                                dbcmd.Parameters.AddWithValue("$cost", 0);
                                dbcmd.Parameters.AddWithValue("$bookingno", Convert.ToInt32(txtBookingNo.Text));

                                dbCon.Open();
                                recordsChanged = dbcmd.ExecuteNonQuery();
                                MessageBox.Show(recordsChanged.ToString() + " Record Modified");
                                dbCon.Close();
                            }

                            txtBookingNo.Clear();
                            txtRoomNo.Clear();
                            txtStaffNo.Clear();
                            txtCustomerNo.Clear();
                            txtGuests.Clear();
                            cbBreakfast.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }

        private void EditGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        if (e.RowIndex >= 0)
                        {
                            //gets a collection that contains all the rows
                            DataGridViewRow row = this.EditGrid.Rows[e.RowIndex];
                            //populate the textbox from specific value of the coordinates of column and row.
                            txtBookingNo.Text = row.Cells[0].Value.ToString();
                            txtRoomNo.Text = row.Cells[1].Value.ToString();
                            txtStaffNo.Text = row.Cells[2].Value.ToString();
                            txtCustomerNo.Text = row.Cells[3].Value.ToString();
                            //txtStaffRole.Text = row.Cells[4].Value.ToString();
                            dpStartDate.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                            dpEndDate.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                            txtGuests.Text = row.Cells[7].Value.ToString();
                            cbBreakfast.Checked = Convert.ToInt32(row.Cells[8].Value.ToString()) == 1 ? true : false;
                            roomType = row.Cells[8].Value.ToString();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
