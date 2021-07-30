using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay_View_Hotel
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            tsName.Text = "Hello, " + SystemVariables.LoggedInUser.StaffName;
            //Filters out the options to navigate to staff and reports for staff not in management
            if (SystemVariables.LoggedInUser.StaffRole == "Regular")
            {
                tsReports.Visible = false;
                tsStaff.Visible = false;
            }
        }

        private void timerDateUpdate_Tick(object sender, EventArgs e)
        {
            tsDate.Text = DateTime.Now.ToString();
        }

        #region navigation buttons
        private void tsManageCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmManageCustomer = new FormManageCustomer();
            frmManageCustomer.FormClosed += (s, args) => this.Close();
            frmManageCustomer.Show();
        }

        private void tsNewBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmNewBooking = new FormNewBooking();
            frmNewBooking.FormClosed += (s, args) => this.Close();
            frmNewBooking.Show();
        }

        private void tsEditBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmEditBooking = new FormEditBooking();
            frmEditBooking.FormClosed += (s, args) => this.Close();
            frmEditBooking.Show();
        }

        private void tsCancelBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmCancelBooking = new FormCancelBooking();
            frmCancelBooking.FormClosed += (s, args) => this.Close();
            frmCancelBooking.Show();
        }

        private void tsRoomAvailability_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmRoomAvailability = new FormRoomAvailability();
            frmRoomAvailability.FormClosed += (s, args) => this.Close();
            frmRoomAvailability.Show();
        }

        private void tsOccupancyRate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmOccupancyRate = new FormOccupancyRate();
            frmOccupancyRate.FormClosed += (s, args) => this.Close();
            frmOccupancyRate.Show();
        }

        private void tsIncomeGenerated_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmIncomeGenerated = new FormIncomeGenerated();
            frmIncomeGenerated.FormClosed += (s, args) => this.Close();
            frmIncomeGenerated.Show();
        }

        private void tsRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmRegisterStaff = new FormRegisterStaff();
            frmRegisterStaff.FormClosed += (s, args) => this.Close();
            frmRegisterStaff.Show();
        }


        private void tsStaffTrackRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmStaffTrackRecord = new FormStaffTrackRecord();
            frmStaffTrackRecord.FormClosed += (s, args) => this.Close();
            frmStaffTrackRecord.Show();
        }
        #endregion

        private void tsLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Are you sure you want to Logout?", "Logout from booking system?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                SystemVariables.IsLoggedIn = false;
                SystemVariables.LoggedInUser = new Tables.Staff();
                FormLogin frmLogin = new FormLogin();
                frmLogin.FormClosed += (s, args) => this.Close();
                frmLogin.Show();
            }
        }
            private void tsExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Are you sure you want to exit?", "Exit booking system?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
    
            
        