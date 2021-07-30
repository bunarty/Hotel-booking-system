using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using Bay_View_Hotel.Tables;

namespace Bay_View_Hotel
{
    public partial class FormManageCustomer : Form
    {

        // Declare Database variables
        SQLiteConnection dbCon;
        SQLiteCommand sqlCmd;
        SQLiteDataAdapter sqlAdpt;
        DataTable dt;
        Customer Customer = new Customer();
        public FormManageCustomer()
        {
            InitializeComponent();
            
        }

        //Back to Home button
        private void tsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome frmHome = new FormHome();
            frmHome.FormClosed += (s, args) => this.Close();
            frmHome.Show();
        }

        //Button_Click Shows all Customer on DataGridView
        private void btnListAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    using (sqlAdpt = new SQLiteDataAdapter("select * from Customer", dbCon))
                    {
                        dt = new DataTable("Customers");
                        sqlAdpt.Fill(dt);
                        dataGridView.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
 
        // Button_Click to search for Customer data
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    using (sqlAdpt = new SQLiteDataAdapter("select * from Customer where CustomerNo ="+ txtSearchCustomer.Text, dbCon))
                    {
                        dt = new DataTable("Customers");
                        sqlAdpt.Fill(dt);
                        dataGridView.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // To Select Customer and display in textboxes

        private void dataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            {
                txtCustomerNo.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                txtCustomerName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                txtCity.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                txtPostCode.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                txtCustomerDOB.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                this.Show();
            }
        }

    // Button_Click to Add new Customer data
    private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    string insertCustomerQuery = "insert into Customer (CustomerName,Address,City,Postcode,DOB) values (@CustomerName, @Address, @City, @Postcode, @DOB)";
                    sqlCmd = dbCon.CreateCommand();
                    sqlCmd.CommandText = insertCustomerQuery;
                    sqlCmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    sqlCmd.Parameters.AddWithValue("@Postcode", txtPostCode.Text);
                    sqlCmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtCustomerDOB.Text).ToString("yyyy-MM-dd"));

                    sqlCmd.ExecuteNonQuery();
                    dbCon.Close();
                    MessageBox.Show("Action Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Button_Click to Update Customer data
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    string updateCustomerQuery = "update Customer set CustomerNo = @CustomerNo, CustomerName = @CustomerName, Address = @Address, City = @City, Postcode = @Postcode where CustomerNo = @CustomerNo";
                    sqlCmd = dbCon.CreateCommand();
                    sqlCmd.CommandText = updateCustomerQuery;
                    sqlCmd.Parameters.AddWithValue("@CustomerNo", txtCustomerNo.Text);
                    sqlCmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    sqlCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    sqlCmd.Parameters.AddWithValue("@Postcode", txtPostCode.Text);
                    sqlCmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(txtCustomerDOB.Text).ToString("yyyy/MM/dd"));

                    sqlCmd.ExecuteNonQuery();
                    dbCon.Close();
                    MessageBox.Show("Action Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Button_Click to Delete Customer data
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    string deleteCustomerQuery = "delete from Customer where CustomerNo = @CustomerNo";
                    sqlCmd = dbCon.CreateCommand();
                    sqlCmd.CommandText = deleteCustomerQuery;
                    sqlCmd.Parameters.AddWithValue("@CustomerNo", Convert.ToInt32(txtDeleteCustomer.Text));
                    sqlCmd.ExecuteNonQuery();
                    dbCon.Close();
                    MessageBox.Show("Action Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

    }
}
