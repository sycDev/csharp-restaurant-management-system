namespace RestaurantManagementSystem.Model
{
    partial class categoryDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryDetailsForm));
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameTextbox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(366, 100);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Location = new System.Drawing.Point(0, 245);
            this.bottomPanel.Size = new System.Drawing.Size(366, 77);
            this.bottomPanel.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(182, 31);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Category Details";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.category;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(41, 136);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(56, 23);
            this.categoryNameLabel.TabIndex = 1;
            this.categoryNameLabel.Text = "Name";
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.Location = new System.Drawing.Point(45, 163);
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.categoryNameTextbox.TabIndex = 1;
            // 
            // categoryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.categoryNameTextbox);
            this.Controls.Add(this.categoryNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "categoryDetailsForm";
            this.Text = "iRestaurant - Category Details";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.categoryNameLabel, 0);
            this.Controls.SetChildIndex(this.categoryNameTextbox, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        public System.Windows.Forms.TextBox categoryNameTextbox;
    }
}