namespace Bay_View_Hotel
{
    partial class FormRoomAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomAvailability));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBack = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRoomAvailability = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.cbSearchAccessible = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtSearchEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtSearchStartDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.lstAvailableRooms = new System.Windows.Forms.ListBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(966, 31);
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
            this.tsBack.Click += new System.EventHandler(this.tsBack_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblRoomAvailability);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 51);
            this.panel2.TabIndex = 28;
            // 
            // lblRoomAvailability
            // 
            this.lblRoomAvailability.AutoSize = true;
            this.lblRoomAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomAvailability.ForeColor = System.Drawing.Color.White;
            this.lblRoomAvailability.Location = new System.Drawing.Point(64, 2);
            this.lblRoomAvailability.Name = "lblRoomAvailability";
            this.lblRoomAvailability.Size = new System.Drawing.Size(302, 39);
            this.lblRoomAvailability.TabIndex = 13;
            this.lblRoomAvailability.Text = "Room Availability";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(18, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 622);
            this.panel1.TabIndex = 27;
            // 
            // cbRoomType
            // 
            this.cbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cbRoomType.Location = new System.Drawing.Point(216, 97);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(242, 28);
            this.cbRoomType.TabIndex = 55;
            this.cbRoomType.Text = "Single";
            // 
            // cbSearchAccessible
            // 
            this.cbSearchAccessible.AutoSize = true;
            this.cbSearchAccessible.Location = new System.Drawing.Point(220, 165);
            this.cbSearchAccessible.Name = "cbSearchAccessible";
            this.cbSearchAccessible.Size = new System.Drawing.Size(15, 14);
            this.cbSearchAccessible.TabIndex = 46;
            this.cbSearchAccessible.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(62, 157);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 24);
            this.label19.TabIndex = 45;
            this.label19.Text = "W/C Accessible?";
            // 
            // dtSearchEndDate
            // 
            this.dtSearchEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchEndDate.Location = new System.Drawing.Point(344, 128);
            this.dtSearchEndDate.Name = "dtSearchEndDate";
            this.dtSearchEndDate.Size = new System.Drawing.Size(114, 26);
            this.dtSearchEndDate.TabIndex = 44;
            // 
            // dtSearchStartDate
            // 
            this.dtSearchStartDate.CustomFormat = "dd-MM-yy";
            this.dtSearchStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearchStartDate.Location = new System.Drawing.Point(216, 128);
            this.dtSearchStartDate.Name = "dtSearchStartDate";
            this.dtSearchStartDate.Size = new System.Drawing.Size(114, 26);
            this.dtSearchStartDate.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(149, 130);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 24);
            this.label18.TabIndex = 42;
            this.label18.Text = "Dates:";
            // 
            // lstAvailableRooms
            // 
            this.lstAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailableRooms.FormattingEnabled = true;
            this.lstAvailableRooms.ItemHeight = 16;
            this.lstAvailableRooms.Location = new System.Drawing.Point(508, 97);
            this.lstAvailableRooms.Name = "lstAvailableRooms";
            this.lstAvailableRooms.Size = new System.Drawing.Size(410, 340);
            this.lstAvailableRooms.TabIndex = 41;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoom.Location = new System.Drawing.Point(344, 202);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(114, 36);
            this.btnSearchRoom.TabIndex = 40;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.UseVisualStyleBackColor = false;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoom.Location = new System.Drawing.Point(98, 97);
            this.labelRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(114, 24);
            this.labelRoom.TabIndex = 39;
            this.labelRoom.Text = "Room Type:";
            // 
            // FormRoomAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(966, 458);
            this.ControlBox = false;
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.cbSearchAccessible);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtSearchEndDate);
            this.Controls.Add(this.dtSearchStartDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lstAvailableRooms);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.labelRoom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRoomAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Availability";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRoomAvailability;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.CheckBox cbSearchAccessible;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtSearchEndDate;
        private System.Windows.Forms.DateTimePicker dtSearchStartDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstAvailableRooms;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Label labelRoom;
    }
}