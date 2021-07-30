using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bay_View_Hotel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon;
        SQLiteCommand sql_cmd;

        int tryCount = 0;
        DateTime timeout = new DateTime();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SystemVariables.IsLoggedIn = false;
                //User locked out for 2 minutes if they get the Password wrong 3 times
                if (tryCount >= 3 && new DateTime() < timeout)
                {
                    MessageBox.Show("Please try again in " + (timeout.Minute - new DateTime().Minute).ToString() + " minute/s");
                }
                else
                {
                    if (tryCount >= 3 && new DateTime() >= timeout)
                    {
                        //resets try count after 2 minutes
                        tryCount = 0;
                    }
                    //gets directory of the project so it can find the db file
                    string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string db = projectDirectory + "\\Assets\\hotel.db";
                    SystemVariables.ConnectionString = "Data Source=" + db.Replace("\\", "/");
                    //grabs staff from database that is logging in
                    using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                    {
                        dbCon.Open();
                        string sql = @"SELECT * FROM Staff WHERE Username = $username AND Password = $password";
                        sql_cmd = dbCon.CreateCommand();
                        sql_cmd.CommandText = sql;
                        sql_cmd.Parameters.AddWithValue("$username", txtUsername.Text);
                        sql_cmd.Parameters.AddWithValue("$password", txtPassword.Text);

                        //populate staff variable within the global variables
                        using (var reader = sql_cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SystemVariables.IsLoggedIn = true;
                                SystemVariables.LoggedInUser.StaffName = (string)reader["StaffName"];
                                SystemVariables.LoggedInUser.StaffNo = Convert.ToInt32(reader["StaffNo"]);
                                SystemVariables.LoggedInUser.Username = (string)reader["Username"];
                                SystemVariables.LoggedInUser.StaffRole = (string)reader["StaffRole"];
                            }
                        }
                    }

                    //logic to check if log in was successful
                    if (SystemVariables.IsLoggedIn)
                    {
                        this.Hide();
                        FormHome frmHome = new FormHome();
                        frmHome.FormClosed += (s, args) => this.Close();
                        frmHome.Show();
                    }
                    else
                    {
                        tryCount += 1;
                        if (tryCount >= 3)
                        {
                            MessageBox.Show("Exceeded 3 tries. Please try again in 2 minutes");
                            timeout = new DateTime().AddMinutes(2);
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. please try again.");
            }
            
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SystemVariables.IsLoggedIn = false;
            SystemVariables.LoggedInUser = new Tables.Staff();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Are you sure you want to exit", "Exit booking system?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Are you sure you want to exit?", "Hotel Booking System", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
