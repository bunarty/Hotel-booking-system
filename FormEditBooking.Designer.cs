namespace Bay_View_Hotel
{
    partial class FormEditBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBooking));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBack = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEdit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAllBooking = new System.Windows.Forms.Button();
            this.txtFindBooking = new System.Windows.Forms.TextBox();
            this.LabelFindBooking = new System.Windows.Forms.Label();
            this.ShowCancelledBooking = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBreakfast = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1220, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBack
            // 
            this.tsBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBack.Image")));
            this.tsBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBack.Name = "tsBack";
            this.tsBack.Size = new System.Drawing.Size(28, 28);
            this.tsBack.Text = "toolStripButton1";
            this.tsBack.ToolTipText = "Back";
            this.tsBack.Click += new System.EventHandler(this.tsBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblEdit);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 51);
            this.panel2.TabIndex = 32;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(65, 6);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(223, 39);
            this.lblEdit.TabIndex = 13;
            this.lblEdit.Text = "Edit Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(21, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 600);
            this.panel1.TabIndex = 31;
            // 
            // EditGrid
            // 
            this.EditGrid.BackgroundColor = System.Drawing.Color.White;
            this.EditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditGrid.GridColor = System.Drawing.Color.White;
            this.EditGrid.Location = new System.Drawing.Point(640, 116);
            this.EditGrid.Name = "EditGrid";
            this.EditGrid.RowHeadersWidth = 51;
            this.EditGrid.Size = new System.Drawing.Size(568, 502);
            this.EditGrid.TabIndex = 44;
            this.EditGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGrid_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAllBooking);
            this.panel3.Controls.Add(this.txtFindBooking);
            this.panel3.Controls.Add(this.LabelFindBooking);
            this.panel3.Controls.Add(this.ShowCancelledBooking);
            this.panel3.Location = new System.Drawing.Point(72, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 125);
            this.panel3.TabIndex = 45;
            // 
            // btnAllBooking
            // 
            this.btnAllBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAllBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBooking.ForeColor = System.Drawing.Color.White;
            this.btnAllBooking.Location = new System.Drawing.Point(8, 11);
            this.btnAllBooking.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllBooking.Name = "btnAllBooking";
            this.btnAllBooking.Size = new System.Drawing.Size(535, 41);
            this.btnAllBooking.TabIndex = 58;
            this.btnAllBooking.Text = "Show All Booking";
            this.btnAllBooking.UseVisualStyleBackColor = false;
            this.btnAllBooking.Click += new System.EventHandler(this.btnShowNonCancelled_Click);
            // 
            // txtFindBooking
            // 
            this.txtFindBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindBooking.Location = new System.Drawing.Point(122, 74);
            this.txtFindBooking.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindBooking.Name = "txtFindBooking";
            this.txtFindBooking.Size = new System.Drawing.Size(265, 29);
            this.txtFindBooking.TabIndex = 49;
            // 
            // LabelFindBooking
            // 
            this.LabelFindBooking.AutoSize = true;
            this.LabelFindBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFindBooking.Location = new System.Drawing.Point(4, 77);
            this.LabelFindBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFindBooking.Name = "LabelFindBooking";
            this.LabelFindBooking.Size = new System.Drawing.Size(114, 24);
            this.LabelFindBooking.TabIndex = 48;
            this.LabelFindBooking.Text = "Booking No:";
            // 
            // ShowCancelledBooking
            // 
            this.ShowCancelledBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowCancelledBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowCancelledBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCancelledBooking.ForeColor = System.Drawing.Color.White;
            this.ShowCancelledBooking.Location = new System.Drawing.Point(401, 66);
            this.ShowCancelledBooking.Margin = new System.Windows.Forms.Padding(0);
            this.ShowCancelledBooking.Name = "ShowCancelledBooking";
            this.ShowCancelledBooking.Size = new System.Drawing.Size(142, 41);
            this.ShowCancelledBooking.TabIndex = 47;
            this.ShowCancelledBooking.Text = "Show Booking";
            this.ShowCancelledBooking.UseVisualStyleBackColor = false;
            this.ShowCancelledBooking.Click += new System.EventHandler(this.ShowCancelledBooking_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(0, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 36);
            this.panel5.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(67, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Manage Booking";
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBooking.ForeColor = System.Drawing.Color.White;
            this.btnEditBooking.Location = new System.Drawing.Point(81, 555);
            this.btnEditBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(545, 41);
            this.btnEditBooking.TabIndex = 56;
            this.btnEditBooking.Text = "Edit Booking";
            this.btnEditBooking.UseVisualStyleBackColor = false;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(114, 504);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 70;
            this.label16.Text = "Guests";
            // 
            // txtGuests
            // 
            this.txtGuests.Enabled = false;
            this.txtGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuests.Location = new System.Drawing.Point(195, 501);
            this.txtGuests.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(197, 29);
            this.txtGuests.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 463);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Start Date";
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Enabled = false;
            this.txtCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNo.Location = new System.Drawing.Point(427, 322);
            this.txtCustomerNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(156, 29);
            this.txtCustomerNo.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Customer No";
            // 
            // txtStaffNo
            // 
            this.txtStaffNo.Enabled = false;
            this.txtStaffNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNo.Location = new System.Drawing.Point(195, 368);
            this.txtStaffNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffNo.Name = "txtStaffNo";
            this.txtStaffNo.Size = new System.Drawing.Size(103, 29);
            this.txtStaffNo.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "Staff No";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(427, 370);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(156, 29);
            this.txtRoomNo.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Room No";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.Enabled = false;
            this.txtBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingNo.Location = new System.Drawing.Point(195, 323);
            this.txtBookingNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.Size = new System.Drawing.Size(103, 29);
            this.txtBookingNo.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Booking No";
            // 
            // cbBreakfast
            // 
            this.cbBreakfast.AutoSize = true;
            this.cbBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBreakfast.Location = new System.Drawing.Point(533, 511);
            this.cbBreakfast.Name = "cbBreakfast";
            this.cbBreakfast.Size = new System.Drawing.Size(15, 14);
            this.cbBreakfast.TabIndex = 72;
            this.cbBreakfast.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(423, 504);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 24);
            this.label17.TabIndex = 71;
            this.label17.Text = "Breakfast?";
            // 
            // dpStartDate
            // 
            this.dpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStartDate.Location = new System.Drawing.Point(195, 416);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(197, 27);
            this.dpStartDate.TabIndex = 73;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.Location = new System.Drawing.Point(195, 461);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(197, 27);
            this.dpEndDate.TabIndex = 74;
            // 
            // FormEditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1220, 630);
            this.ControlBox = false;
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.cbBreakfast);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStaffNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBookingNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EditGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditBooking";
            this.Text = "Edit Bookings";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView EditGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAllBooking;
        private System.Windows.Forms.TextBox txtFindBooking;
        private System.Windows.Forms.Label LabelFindBooking;
        private System.Windows.Forms.Button ShowCancelledBooking;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbBreakfast;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.DateTimePicker dpEndDate;
    }
}