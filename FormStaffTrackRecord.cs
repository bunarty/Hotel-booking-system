using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using Bay_View_Hotel.Tables;

namespace Bay_View_Hotel
{
    public partial class FormStaffTrackRecord : Form
    {

        // Declare Database variables
        SQLiteConnection dbCon;
        SQLiteDataAdapter sqlAdpt;
        DataTable dt;
        Booking Booking = new Booking();
        public FormStaffTrackRecord()
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

        // Show All Staff Track Record of Bookings Managed (Added/Modified/Deleted)
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    using (sqlAdpt = new SQLiteDataAdapter("select StaffNo, BookingNo from Booking order by StaffNo", dbCon))
                    {
                        dt = new DataTable("Booking");
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
        // Show All Bookings Managed by a particular Staff 
        private void btnShowBooking_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    using (sqlAdpt = new SQLiteDataAdapter("select BookingNo from Booking where StaffNo =" + txtStaffNo.Text, dbCon))
                    {
                        dt = new DataTable("Booking");
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
        // Show Staff Details associated with a particular Booking
        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    dbCon.Open();
                    using (sqlAdpt = new SQLiteDataAdapter("select StaffNo from Booking where BookingNo =" + txtBookingNo.Text, dbCon))
                    {
                        dt = new DataTable("Booking");
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

        private void FormStaffTrackRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
