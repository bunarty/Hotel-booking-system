namespace Bay_View_Hotel
{
    partial class FormCancelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelBooking));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBack = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowNonCancelled = new System.Windows.Forms.Button();
            this.btnShowCancelled = new System.Windows.Forms.Button();
            this.txtFindBooking = new System.Windows.Forms.TextBox();
            this.LabelFindBooking = new System.Windows.Forms.Label();
            this.ShowCancelledBooking = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.rtbCancReason = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelGrid)).BeginInit();
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
            this.panel2.Controls.Add(this.lblCancel);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 51);
            this.panel2.TabIndex = 30;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(65, 6);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(273, 39);
            this.lblCancel.TabIndex = 13;
            this.lblCancel.Text = "Cancel Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 600);
            this.panel1.TabIndex = 29;
            // 
            // CancelGrid
            // 
            this.CancelGrid.BackgroundColor = System.Drawing.Color.White;
            this.CancelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancelGrid.GridColor = System.Drawing.Color.White;
            this.CancelGrid.Location = new System.Drawing.Point(642, 116);
            this.CancelGrid.MultiSelect = false;
            this.CancelGrid.Name = "CancelGrid";
            this.CancelGrid.RowHeadersWidth = 51;
            this.CancelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CancelGrid.Size = new System.Drawing.Size(569, 502);
            this.CancelGrid.TabIndex = 43;
            this.CancelGrid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.CancelGrid_RowStateChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnShowNonCancelled);
            this.panel3.Controls.Add(this.btnShowCancelled);
            this.panel3.Controls.Add(this.txtFindBooking);
            this.panel3.Controls.Add(this.LabelFindBooking);
            this.panel3.Controls.Add(this.ShowCancelledBooking);
            this.panel3.Location = new System.Drawing.Point(72, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 170);
            this.panel3.TabIndex = 44;
            // 
            // btnShowNonCancelled
            // 
            this.btnShowNonCancelled.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowNonCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowNonCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNonCancelled.ForeColor = System.Drawing.Color.White;
            this.btnShowNonCancelled.Location = new System.Drawing.Point(8, 63);
            this.btnShowNonCancelled.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowNonCancelled.Name = "btnShowNonCancelled";
            this.btnShowNonCancelled.Size = new System.Drawing.Size(535, 41);
            this.btnShowNonCancelled.TabIndex = 58;
            this.btnShowNonCancelled.Text = "Show All Non Cancelled Booking";
            this.btnShowNonCancelled.UseVisualStyleBackColor = false;
            this.btnShowNonCancelled.Click += new System.EventHandler(this.btnShowNonCancelled_Click);
            // 
            // btnShowCancelled
            // 
            this.btnShowCancelled.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCancelled.ForeColor = System.Drawing.Color.White;
            this.btnShowCancelled.Location = new System.Drawing.Point(8, 12);
            this.btnShowCancelled.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowCancelled.Name = "btnShowCancelled";
            this.btnShowCancelled.Size = new System.Drawing.Size(535, 41);
            this.btnShowCancelled.TabIndex = 57;
            this.btnShowCancelled.Text = "Show All Cancelled Booking";
            this.btnShowCancelled.UseVisualStyleBackColor = false;
            this.btnShowCancelled.Click += new System.EventHandler(this.btnShowCancelled_Click);
            // 
            // txtFindBooking
            // 
            this.txtFindBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindBooking.Location = new System.Drawing.Point(122, 123);
            this.txtFindBooking.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindBooking.Name = "txtFindBooking";
            this.txtFindBooking.Size = new System.Drawing.Size(265, 29);
            this.txtFindBooking.TabIndex = 49;
            // 
            // LabelFindBooking
            // 
            this.LabelFindBooking.AutoSize = true;
            this.LabelFindBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFindBooking.Location = new System.Drawing.Point(4, 126);
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
            this.ShowCancelledBooking.Location = new System.Drawing.Point(401, 115);
            this.ShowCancelledBooking.Margin = new System.Windows.Forms.Padding(0);
            this.ShowCancelledBooking.Name = "ShowCancelledBooking";
            this.ShowCancelledBooking.Size = new System.Drawing.Size(142, 41);
            this.ShowCancelledBooking.TabIndex = 47;
            this.ShowCancelledBooking.Text = "Show Booking";
            this.ShowCancelledBooking.UseVisualStyleBackColor = false;
            this.ShowCancelledBooking.Click += new System.EventHandler(this.ShowAllStaff_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(72, 575);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(554, 41);
            this.btnCancelBooking.TabIndex = 45;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 410);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cancelation Reason:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 366);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 47;
            this.label10.Text = "Booking No:";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.Enabled = false;
            this.txtBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingNo.Location = new System.Drawing.Point(189, 363);
            this.txtBookingNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.Size = new System.Drawing.Size(53, 29);
            this.txtBookingNo.TabIndex = 46;
            // 
            // rtbCancReason
            // 
            this.rtbCancReason.Location = new System.Drawing.Point(260, 410);
            this.rtbCancReason.Name = "rtbCancReason";
            this.rtbCancReason.Size = new System.Drawing.Size(366, 96);
            this.rtbCancReason.TabIndex = 53;
            this.rtbCancReason.Text = "";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(0, 303);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 36);
            this.panel5.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 526);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Staff No:";
            // 
            // txtStaffNo
            // 
            this.txtStaffNo.Enabled = false;
            this.txtStaffNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNo.Location = new System.Drawing.Point(154, 523);
            this.txtStaffNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffNo.Name = "txtStaffNo";
            this.txtStaffNo.Size = new System.Drawing.Size(87, 29);
            this.txtStaffNo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(260, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 47);
            this.label3.TabIndex = 57;
            this.label3.Text = "Note: A booking may be cancelled without cost provided it is cancelled three week" +
    "s prior to the start of the booking. Booking cancelled after this time are subje" +
    "ct to a 15% cancellation fee.\r\n";
            // 
            // FormCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1220, 630);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStaffNo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.rtbCancReason);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBookingNo);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.CancelGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCancelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Bookings";
            this.Load += new System.EventHandler(this.FormCancelBooking_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelGrid)).EndInit();
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
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CancelGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFindBooking;
        private System.Windows.Forms.Label LabelFindBooking;
        private System.Windows.Forms.Button ShowCancelledBooking;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.RichTextBox rtbCancReason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffNo;
        private System.Windows.Forms.Button btnShowCancelled;
        private System.Windows.Forms.Button btnShowNonCancelled;
        private System.Windows.Forms.Label label3;
    }
}