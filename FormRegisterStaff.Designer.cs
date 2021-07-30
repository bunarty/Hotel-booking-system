namespace Bay_View_Hotel
{
    partial class FormRegisterStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterStaff));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBack = new System.Windows.Forms.ToolStripButton();
            this.btnNewStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaffUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffRole = new System.Windows.Forms.ComboBox();
            this.StaffGrid = new System.Windows.Forms.DataGridView();
            this.bntStaffSearch = new System.Windows.Forms.Button();
            this.ShowAllStaff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFindStaff = new System.Windows.Forms.TextBox();
            this.LabelFindStaff = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1170, 31);
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
            // btnNewStaff
            // 
            this.btnNewStaff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStaff.ForeColor = System.Drawing.Color.White;
            this.btnNewStaff.Location = new System.Drawing.Point(94, 529);
            this.btnNewStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(274, 41);
            this.btnNewStaff.TabIndex = 21;
            this.btnNewStaff.Text = "New";
            this.btnNewStaff.UseVisualStyleBackColor = false;
            this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaff.ForeColor = System.Drawing.Color.White;
            this.btnEditStaff.Location = new System.Drawing.Point(372, 529);
            this.btnEditStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(277, 41);
            this.btnEditStaff.TabIndex = 22;
            this.btnEditStaff.Text = "Update";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(35, 76);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(162, 41);
            this.btnDeleteStaff.TabIndex = 23;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblStaff);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 51);
            this.panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1110, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 48);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.White;
            this.lblStaff.Location = new System.Drawing.Point(65, 6);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(94, 39);
            this.lblStaff.TabIndex = 13;
            this.lblStaff.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 622);
            this.panel1.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(0, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 36);
            this.panel5.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(67, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Manage Staff";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 416);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Password:";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffPassword.Location = new System.Drawing.Point(196, 414);
            this.txtStaffPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(453, 29);
            this.txtStaffPassword.TabIndex = 33;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(346, 316);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(305, 29);
            this.txtStaffName.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 24);
            this.label11.TabIndex = 31;
            this.label11.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Staff No:";
            // 
            // txtStaffNo
            // 
            this.txtStaffNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNo.Location = new System.Drawing.Point(196, 316);
            this.txtStaffNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaffNo.Name = "txtStaffNo";
            this.txtStaffNo.Size = new System.Drawing.Size(71, 29);
            this.txtStaffNo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username:";
            // 
            // txtStaffUsername
            // 
            this.txtStaffUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffUsername.Location = new System.Drawing.Point(196, 365);
            this.txtStaffUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaffUsername.Name = "txtStaffUsername";
            this.txtStaffUsername.Size = new System.Drawing.Size(453, 29);
            this.txtStaffUsername.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 463);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Staff Role:";
            // 
            // txtStaffRole
            // 
            this.txtStaffRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffRole.FormattingEnabled = true;
            this.txtStaffRole.Items.AddRange(new object[] {
            "Managment",
            "Regular"});
            this.txtStaffRole.Location = new System.Drawing.Point(196, 463);
            this.txtStaffRole.Name = "txtStaffRole";
            this.txtStaffRole.Size = new System.Drawing.Size(453, 32);
            this.txtStaffRole.TabIndex = 40;
            // 
            // StaffGrid
            // 
            this.StaffGrid.BackgroundColor = System.Drawing.Color.White;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffGrid.GridColor = System.Drawing.Color.White;
            this.StaffGrid.Location = new System.Drawing.Point(661, 100);
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.RowHeadersWidth = 51;
            this.StaffGrid.Size = new System.Drawing.Size(498, 502);
            this.StaffGrid.TabIndex = 41;
            this.StaffGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGrid_CellClick);
            // 
            // bntStaffSearch
            // 
            this.bntStaffSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.bntStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStaffSearch.ForeColor = System.Drawing.Color.White;
            this.bntStaffSearch.Location = new System.Drawing.Point(93, 100);
            this.bntStaffSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bntStaffSearch.Name = "bntStaffSearch";
            this.bntStaffSearch.Size = new System.Drawing.Size(307, 41);
            this.bntStaffSearch.TabIndex = 42;
            this.bntStaffSearch.Text = "Show All Staff";
            this.bntStaffSearch.UseVisualStyleBackColor = false;
            this.bntStaffSearch.Click += new System.EventHandler(this.bntStaffSearch_Click);
            // 
            // ShowAllStaff
            // 
            this.ShowAllStaff.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowAllStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowAllStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllStaff.ForeColor = System.Drawing.Color.White;
            this.ShowAllStaff.Location = new System.Drawing.Point(14, 16);
            this.ShowAllStaff.Margin = new System.Windows.Forms.Padding(0);
            this.ShowAllStaff.Name = "ShowAllStaff";
            this.ShowAllStaff.Size = new System.Drawing.Size(117, 41);
            this.ShowAllStaff.TabIndex = 43;
            this.ShowAllStaff.Text = "Show Staff";
            this.ShowAllStaff.UseVisualStyleBackColor = false;
            this.ShowAllStaff.Click += new System.EventHandler(this.ShowAllStaff_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtFindStaff);
            this.panel3.Controls.Add(this.LabelFindStaff);
            this.panel3.Controls.Add(this.ShowAllStaff);
            this.panel3.Location = new System.Drawing.Point(93, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 75);
            this.panel3.TabIndex = 44;
            // 
            // txtFindStaff
            // 
            this.txtFindStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindStaff.Location = new System.Drawing.Point(219, 23);
            this.txtFindStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindStaff.Name = "txtFindStaff";
            this.txtFindStaff.Size = new System.Drawing.Size(73, 29);
            this.txtFindStaff.TabIndex = 46;
            // 
            // LabelFindStaff
            // 
            this.LabelFindStaff.AutoSize = true;
            this.LabelFindStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFindStaff.Location = new System.Drawing.Point(144, 27);
            this.LabelFindStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFindStaff.Name = "LabelFindStaff";
            this.LabelFindStaff.Size = new System.Drawing.Size(69, 20);
            this.LabelFindStaff.TabIndex = 45;
            this.LabelFindStaff.Text = "Staff ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtStaff);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnDeleteStaff);
            this.panel4.Location = new System.Drawing.Point(410, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 135);
            this.panel4.TabIndex = 45;
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(35, 39);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(162, 29);
            this.txtStaff.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Staff ID:";
            // 
            // FormRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1170, 612);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bntStaffSearch);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.StaffGrid);
            this.Controls.Add(this.txtStaffRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStaffUsername);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStaffPassword);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStaffNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewStaff);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRegisterStaff";
            this.Text = "New Staff";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBack;
        private System.Windows.Forms.Button btnNewStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStaffNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaffUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtStaffRole;
        private System.Windows.Forms.DataGridView StaffGrid;
        private System.Windows.Forms.Button bntStaffSearch;
        private System.Windows.Forms.Button ShowAllStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFindStaff;
        private System.Windows.Forms.Label LabelFindStaff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label label3;
    }
}