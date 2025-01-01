namespace RestaurantManagementSystem.Model
{
    partial class customerDetailsForm
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
            this.driverLabel = new System.Windows.Forms.Label();
            this.driverCombobox = new System.Windows.Forms.ComboBox();
            this.cusPhoneTextbox = new System.Windows.Forms.TextBox();
            this.staffPhoneLabel = new System.Windows.Forms.Label();
            this.cusNameTextbox = new System.Windows.Forms.TextBox();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(16, 13);
            this.cancelBtn.Size = new System.Drawing.Size(335, 52);
            this.cancelBtn.Text = "CLOSE";
            // 
            // saveBtn
            // 
            this.saveBtn.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(366, 100);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Size = new System.Drawing.Size(366, 77);
            this.bottomPanel.TabIndex = 7;
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(112, 31);
            this.headerLabel.Text = "Customer";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.staff;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(37, 269);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(55, 23);
            this.driverLabel.TabIndex = 5;
            this.driverLabel.Text = "Driver";
            // 
            // driverCombobox
            // 
            this.driverCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverCombobox.FormattingEnabled = true;
            this.driverCombobox.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Cleaner",
            "Manager",
            "Other"});
            this.driverCombobox.Location = new System.Drawing.Point(41, 295);
            this.driverCombobox.Name = "driverCombobox";
            this.driverCombobox.Size = new System.Drawing.Size(283, 31);
            this.driverCombobox.TabIndex = 6;
            this.driverCombobox.SelectedIndexChanged += new System.EventHandler(this.driverCombobox_SelectedIndexChanged);
            // 
            // cusPhoneTextbox
            // 
            this.cusPhoneTextbox.Location = new System.Drawing.Point(41, 230);
            this.cusPhoneTextbox.Name = "cusPhoneTextbox";
            this.cusPhoneTextbox.Size = new System.Drawing.Size(283, 30);
            this.cusPhoneTextbox.TabIndex = 4;
            // 
            // staffPhoneLabel
            // 
            this.staffPhoneLabel.AutoSize = true;
            this.staffPhoneLabel.Location = new System.Drawing.Point(37, 203);
            this.staffPhoneLabel.Name = "staffPhoneLabel";
            this.staffPhoneLabel.Size = new System.Drawing.Size(59, 23);
            this.staffPhoneLabel.TabIndex = 3;
            this.staffPhoneLabel.Text = "Phone";
            // 
            // cusNameTextbox
            // 
            this.cusNameTextbox.Location = new System.Drawing.Point(41, 164);
            this.cusNameTextbox.Name = "cusNameTextbox";
            this.cusNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.cusNameTextbox.TabIndex = 2;
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.Location = new System.Drawing.Point(37, 137);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(56, 23);
            this.staffNameLabel.TabIndex = 1;
            this.staffNameLabel.Text = "Name";
            // 
            // customerDetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.driverCombobox);
            this.Controls.Add(this.cusPhoneTextbox);
            this.Controls.Add(this.staffPhoneLabel);
            this.Controls.Add(this.cusNameTextbox);
            this.Controls.Add(this.staffNameLabel);
            this.Name = "customerDetailsForm";
            this.Text = "iRestaurant - Customer";
            this.Load += new System.EventHandler(this.customerDetailsForm_Load);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.staffNameLabel, 0);
            this.Controls.SetChildIndex(this.cusNameTextbox, 0);
            this.Controls.SetChildIndex(this.staffPhoneLabel, 0);
            this.Controls.SetChildIndex(this.cusPhoneTextbox, 0);
            this.Controls.SetChildIndex(this.driverCombobox, 0);
            this.Controls.SetChildIndex(this.driverLabel, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driverLabel;
        public System.Windows.Forms.ComboBox driverCombobox;
        public System.Windows.Forms.TextBox cusPhoneTextbox;
        private System.Windows.Forms.Label staffPhoneLabel;
        public System.Windows.Forms.TextBox cusNameTextbox;
        private System.Windows.Forms.Label staffNameLabel;
    }
}