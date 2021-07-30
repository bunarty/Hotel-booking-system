namespace Bay_View_Hotel
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureHotel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManageCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRoomAvailability = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOccupancyRate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIncomeGenerated = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRegisterStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStaffTrackRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHotel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureHotel
            // 
            this.pictureHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureHotel.Image")));
            this.pictureHotel.Location = new System.Drawing.Point(276, 140);
            this.pictureHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureHotel.Name = "pictureHotel";
            this.pictureHotel.Size = new System.Drawing.Size(449, 404);
            this.pictureHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHotel.TabIndex = 2;
            this.pictureHotel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bay View Hotel Booking System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCustomer,
            this.tsBookings,
            this.tsReports,
            this.tsStaff,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(993, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsCustomer
            // 
            this.tsCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsManageCustomer});
            this.tsCustomer.Name = "tsCustomer";
            this.tsCustomer.Size = new System.Drawing.Size(86, 24);
            this.tsCustomer.Text = "Customer";
            // 
            // tsManageCustomer
            // 
            this.tsManageCustomer.Name = "tsManageCustomer";
            this.tsManageCustomer.Size = new System.Drawing.Size(219, 26);
            this.tsManageCustomer.Text = "Manage Customers";
            this.tsManageCustomer.Click += new System.EventHandler(this.tsManageCustomer_Click);
            // 
            // tsBookings
            // 
            this.tsBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewBooking,
            this.tsEditBooking,
            this.tsCancelBooking,
            this.tsRoomAvailability});
            this.tsBookings.Name = "tsBookings";
            this.tsBookings.Size = new System.Drawing.Size(84, 24);
            this.tsBookings.Text = "Bookings";
            // 
            // tsNewBooking
            // 
            this.tsNewBooking.Name = "tsNewBooking";
            this.tsNewBooking.Size = new System.Drawing.Size(253, 26);
            this.tsNewBooking.Text = "New Booking";
            this.tsNewBooking.Click += new System.EventHandler(this.tsNewBooking_Click);
            // 
            // tsEditBooking
            // 
            this.tsEditBooking.Name = "tsEditBooking";
            this.tsEditBooking.Size = new System.Drawing.Size(253, 26);
            this.tsEditBooking.Text = "Edit Bookings";
            this.tsEditBooking.Click += new System.EventHandler(this.tsEditBooking_Click);
            // 
            // tsCancelBooking
            // 
            this.tsCancelBooking.Name = "tsCancelBooking";
            this.tsCancelBooking.Size = new System.Drawing.Size(253, 26);
            this.tsCancelBooking.Text = "Cancel Bookings";
            this.tsCancelBooking.Click += new System.EventHandler(this.tsCancelBooking_Click);
            // 
            // tsRoomAvailability
            // 
            this.tsRoomAvailability.Name = "tsRoomAvailability";
            this.tsRoomAvailability.Size = new System.Drawing.Size(253, 26);
            this.tsRoomAvailability.Text = "Check Room Availability";
            this.tsRoomAvailability.Click += new System.EventHandler(this.tsRoomAvailability_Click);
            // 
            // tsReports
            // 
            this.tsReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOccupancyRate,
            this.tsIncomeGenerated});
            this.tsReports.Name = "tsReports";
            this.tsReports.Size = new System.Drawing.Size(74, 24);
            this.tsReports.Text = "Reports";
            // 
            // tsOccupancyRate
            // 
            this.tsOccupancyRate.Name = "tsOccupancyRate";
            this.tsOccupancyRate.Size = new System.Drawing.Size(248, 26);
            this.tsOccupancyRate.Text = "Room Occupancy Rates";
            this.tsOccupancyRate.Click += new System.EventHandler(this.tsOccupancyRate_Click);
            // 
            // tsIncomeGenerated
            // 
            this.tsIncomeGenerated.Name = "tsIncomeGenerated";
            this.tsIncomeGenerated.Size = new System.Drawing.Size(248, 26);
            this.tsIncomeGenerated.Text = "Income Generated";
            this.tsIncomeGenerated.Click += new System.EventHandler(this.tsIncomeGenerated_Click);
            // 
            // tsStaff
            // 
            this.tsStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegisterStaff,
            this.tsStaffTrackRecord});
            this.tsStaff.Name = "tsStaff";
            this.tsStaff.Size = new System.Drawing.Size(54, 24);
            this.tsStaff.Text = "Staff";
            // 
            // tsRegisterStaff
            // 
            this.tsRegisterStaff.Name = "tsRegisterStaff";
            this.tsRegisterStaff.Size = new System.Drawing.Size(212, 26);
            this.tsRegisterStaff.Text = "Register Staff";
            this.tsRegisterStaff.Click += new System.EventHandler(this.tsRegisterStaff_Click);
            // 
            // tsStaffTrackRecord
            // 
            this.tsStaffTrackRecord.Name = "tsStaffTrackRecord";
            this.tsStaffTrackRecord.Size = new System.Drawing.Size(212, 26);
            this.tsStaffTrackRecord.Text = "Staff Track Record";
            this.tsStaffTrackRecord.Click += new System.EventHandler(this.tsStaffTrackRecord_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogout,
            this.tsExit});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.accountToolStripMenuItem.Text = "Program";
            // 
            // tsLogout
            // 
            this.tsLogout.Name = "tsLogout";
            this.tsLogout.Size = new System.Drawing.Size(139, 26);
            this.tsLogout.Text = "Logout";
            this.tsLogout.Click += new System.EventHandler(this.tsLogout_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(139, 26);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsName,
            this.tsDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(993, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsName
            // 
            this.tsName.BackColor = System.Drawing.SystemColors.Control;
            this.tsName.Name = "tsName";
            this.tsName.Size = new System.Drawing.Size(49, 20);
            this.tsName.Text = "Name";
            // 
            // tsDate
            // 
            this.tsDate.BackColor = System.Drawing.SystemColors.Control;
            this.tsDate.Name = "tsDate";
            this.tsDate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsDate.Size = new System.Drawing.Size(41, 20);
            this.tsDate.Text = "Date";
            this.tsDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDateUpdate
            // 
            this.timerDateUpdate.Enabled = true;
            this.timerDateUpdate.Interval = 1000;
            this.timerDateUpdate.Tick += new System.EventHandler(this.timerDateUpdate_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(993, 670);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureHotel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHotel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsManageCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsBookings;
        private System.Windows.Forms.ToolStripMenuItem tsNewBooking;
        private System.Windows.Forms.ToolStripMenuItem tsEditBooking;
        private System.Windows.Forms.ToolStripMenuItem tsCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem tsRoomAvailability;
        private System.Windows.Forms.ToolStripMenuItem tsReports;
        private System.Windows.Forms.ToolStripMenuItem tsOccupancyRate;
        private System.Windows.Forms.ToolStripMenuItem tsIncomeGenerated;
        private System.Windows.Forms.ToolStripMenuItem tsStaff;
        private System.Windows.Forms.ToolStripMenuItem tsRegisterStaff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsName;
        private System.Windows.Forms.Timer timerDateUpdate;
        private System.Windows.Forms.ToolStripStatusLabel tsDate;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsLogout;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsStaffTrackRecord;
    }
}