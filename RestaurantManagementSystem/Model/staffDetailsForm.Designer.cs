namespace RestaurantManagementSystem.Model
{
    partial class staffDetailsForm
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
            this.staffNameTextbox = new System.Windows.Forms.TextBox();
            this.staffNameLabel = new System.Windows.Forms.Label();
            this.staffPhoneTextbox = new System.Windows.Forms.TextBox();
            this.staffPhoneLabel = new System.Windows.Forms.Label();
            this.staffRoleCombobox = new System.Windows.Forms.ComboBox();
            this.staffRoleLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(368, 100);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Size = new System.Drawing.Size(368, 77);
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(135, 31);
            this.headerLabel.Text = "Staff Details";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.staff;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // staffNameTextbox
            // 
            this.staffNameTextbox.Location = new System.Drawing.Point(41, 165);
            this.staffNameTextbox.Name = "staffNameTextbox";
            this.staffNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.staffNameTextbox.TabIndex = 2;
            // 
            // staffNameLabel
            // 
            this.staffNameLabel.AutoSize = true;
            this.staffNameLabel.Location = new System.Drawing.Point(37, 138);
            this.staffNameLabel.Name = "staffNameLabel";
            this.staffNameLabel.Size = new System.Drawing.Size(56, 23);
            this.staffNameLabel.TabIndex = 1;
            this.staffNameLabel.Text = "Name";
            // 
            // staffPhoneTextbox
            // 
            this.staffPhoneTextbox.Location = new System.Drawing.Point(41, 231);
            this.staffPhoneTextbox.Name = "staffPhoneTextbox";
            this.staffPhoneTextbox.Size = new System.Drawing.Size(283, 30);
            this.staffPhoneTextbox.TabIndex = 4;
            // 
            // staffPhoneLabel
            // 
            this.staffPhoneLabel.AutoSize = true;
            this.staffPhoneLabel.Location = new System.Drawing.Point(37, 204);
            this.staffPhoneLabel.Name = "staffPhoneLabel";
            this.staffPhoneLabel.Size = new System.Drawing.Size(59, 23);
            this.staffPhoneLabel.TabIndex = 3;
            this.staffPhoneLabel.Text = "Phone";
            // 
            // staffRoleCombobox
            // 
            this.staffRoleCombobox.FormattingEnabled = true;
            this.staffRoleCombobox.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Cleaner",
            "Manager",
            "Other"});
            this.staffRoleCombobox.Location = new System.Drawing.Point(41, 296);
            this.staffRoleCombobox.Name = "staffRoleCombobox";
            this.staffRoleCombobox.Size = new System.Drawing.Size(283, 31);
            this.staffRoleCombobox.TabIndex = 6;
            // 
            // staffRoleLabel
            // 
            this.staffRoleLabel.AutoSize = true;
            this.staffRoleLabel.Location = new System.Drawing.Point(37, 270);
            this.staffRoleLabel.Name = "staffRoleLabel";
            this.staffRoleLabel.Size = new System.Drawing.Size(43, 23);
            this.staffRoleLabel.TabIndex = 5;
            this.staffRoleLabel.Text = "Role";
            // 
            // staffDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.staffRoleLabel);
            this.Controls.Add(this.staffRoleCombobox);
            this.Controls.Add(this.staffPhoneTextbox);
            this.Controls.Add(this.staffPhoneLabel);
            this.Controls.Add(this.staffNameTextbox);
            this.Controls.Add(this.staffNameLabel);
            this.Name = "staffDetailsForm";
            this.Text = "staffDetailsForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.staffNameLabel, 0);
            this.Controls.SetChildIndex(this.staffNameTextbox, 0);
            this.Controls.SetChildIndex(this.staffPhoneLabel, 0);
            this.Controls.SetChildIndex(this.staffPhoneTextbox, 0);
            this.Controls.SetChildIndex(this.staffRoleCombobox, 0);
            this.Controls.SetChildIndex(this.staffRoleLabel, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox staffNameTextbox;
        private System.Windows.Forms.Label staffNameLabel;
        public System.Windows.Forms.TextBox staffPhoneTextbox;
        private System.Windows.Forms.Label staffPhoneLabel;
        public System.Windows.Forms.ComboBox staffRoleCombobox;
        private System.Windows.Forms.Label staffRoleLabel;
    }
}