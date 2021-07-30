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
    public partial class FormCancelBooking : Form
    {
        public FormCancelBooking()
        {
            InitializeComponent();
        }

        SQLiteConnection dbCon;
        SQLiteCommand dbcmd;
        DataTable dt;
        SQLiteDataAdapter adpt;

        bool isCancelled = false;

        private void ShowAllStaff_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        isCancelled = false;
                        adpt = new SQLiteDataAdapter("select * from BookingCancellation where BookingNo =" + txtFindBooking.Text, dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        CancelGrid.DataSource = dt;
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

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    DateTime cancelDate = DateTime.Now;
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        dbCon.Open();
                        string sql = @"INSERT INTO BookingCancellation (BookingNo, CancellationDate, CancellationReason, StaffNo, CancellationFee) VALUES ($bookingno, $date, $reason, $staffno, $fee)";
                        dbcmd.CommandText = sql;
                        dbcmd.Parameters.AddWithValue("$bookingno", Convert.ToInt32(txtBookingNo.Text));
                        dbcmd.Parameters.AddWithValue("$date", cancelDate.ToString("yyyy-MM-dd"));
                        dbcmd.Parameters.AddWithValue("$reason", rtbCancReason.Text);
                        dbcmd.Parameters.AddWithValue("$staffno", Convert.ToInt32(txtStaffNo.Text));
                        dbcmd.Parameters.AddWithValue("$fee", DateTime.Parse(CancelGrid.SelectedRows[0].Cells[5].Value.ToString()) <= cancelDate.AddDays(21) ? Convert.ToInt32(CancelGrid.SelectedRows[0].Cells[9].Value) * 0.15 : 0);
                        int recordsChanged = dbcmd.ExecuteNonQuery();
                        dbCon.Close();

                        if (recordsChanged > 0)
                        {
                            MessageBox.Show(recordsChanged.ToString() + " Record Added");
                            txtBookingNo.Clear();
                            rtbCancReason.Clear();
                            txtStaffNo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Please try again");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowCancelled_Click(object sender, EventArgs e)
        {
            try
            {
                btnCancelBooking.Enabled = false;
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        isCancelled = true;
                        adpt = new SQLiteDataAdapter("select b.*, c.CancellationDate, c.CancellationReason, c.StaffNo as StaffCancelled, c.CancellationFee from Booking b join bookingcancellation c on b.bookingno = c.bookingno", dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        CancelGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowNonCancelled_Click(object sender, EventArgs e)
        {
            btnCancelBooking.Enabled = true;
            try
            {
                using (dbCon = new SQLiteConnection(SystemVariables.ConnectionString))
                {
                    using (SQLiteCommand dbcmd = dbCon.CreateCommand())
                    {
                        isCancelled = false;
                        adpt = new SQLiteDataAdapter("select * from Booking where bookingno not in (select bookingno from bookingcancellation) AND startdate > " + new DateTime().ToString("yyyy-MM-dd"), dbCon);
                        dt = new DataTable();
                        adpt.Fill(dt);
                        CancelGrid.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormCancelBooking_Load(object sender, EventArgs e)
        {
            txtStaffNo.Text = SystemVariables.LoggedInUser.StaffNo.ToString();
        }

        private void CancelGrid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            if (isCancelled) return;
            foreach(DataGridViewRow row in CancelGrid.SelectedRows)
            {
                txtBookingNo.Text = row.Cells[0].Value.ToString();
                rtbCancReason.Text = "";
            }

        }
    }
}
