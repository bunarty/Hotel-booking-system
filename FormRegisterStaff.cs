using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Bay_View_Hotel.Tables;
using System.Data;

namespace Bay_View_Hotel
{
    public partial class FormRegisterStaff : Form
    {
        public FormRegisterStaff()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;
        DataTable dt;
        SQLiteDataAdapter adpt;
        Staff staff;

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        dbcmd.CommandText = @"insert into Staff (StaffNo, StaffName, Username, Password, StaffRole) values ('" + txtStaffNo.Text + "','" + txtStaffName.Text + "','" + txtStaffUsername.Text + "','" + txtStaffPassword.Text + "','" + txtStaffRole.Text + "')";

                        dbCon.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " record added");
                        dbCon.Close();
                    }
                    txtStaffNo.Clear();
                    txtStaffName.Clear();
                    txtStaffUsername.Clear();
                    txtStaffPassword.Clear();
                    txtStaffRole.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }  
        }
        private void bntStaffSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        adpt = new SQLiteDataAdapter("select * from Staff", dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        StaffGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowAllStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        adpt = new SQLiteDataAdapter("select * from Staff where StaffNo =" + txtFindStaff.Text, dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        StaffGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        dbcmd.CommandText = @"delete  from Staff where StaffNo=@staffid";
                        dbcmd.Parameters.AddWithValue("staffid", Convert.ToInt32(txtStaff.Text));
                        dbCon.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " record removed");
                        dbCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        dbcmd.CommandText = @"Update Staff Set StaffName=@name, Username=@user, Password=@pass, StaffRole=@role Where StaffNo=@ID";
                        dbcmd.Parameters.AddWithValue("name", txtStaffName.Text);
                        dbcmd.Parameters.AddWithValue("user", txtStaffUsername.Text);
                        dbcmd.Parameters.AddWithValue("pass", txtStaffPassword.Text);
                        dbcmd.Parameters.AddWithValue("role", txtStaffRole.Text);
                        dbcmd.Parameters.AddWithValue("ID", Convert.ToInt32(txtStaffNo.Text));

                        dbCon.Open();
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        MessageBox.Show(recordsChanged.ToString() + " Record Modified");
                        dbCon.Close();
                    }

                    txtStaffName.Clear();
                    txtStaffUsername.Clear();
                    txtStaffPassword.Clear();
                    txtStaffRole.Text = String.Empty;
                    txtStaffNo.Clear();
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

        private void StaffGrid_CellClick(object sender, DataGridViewCellEventArgs e)
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
                            DataGridViewRow row = this.StaffGrid.Rows[e.RowIndex];
                            //populate the textbox from specific value of the coordinates of column and row.
                            txtStaffNo.Text = row.Cells[0].Value.ToString();
                            txtStaffName.Text = row.Cells[1].Value.ToString();
                            txtStaffUsername.Text = row.Cells[2].Value.ToString();
                            txtStaffPassword.Text = row.Cells[3].Value.ToString();
                            txtStaffRole.Text = row.Cells[4].Value.ToString();
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
