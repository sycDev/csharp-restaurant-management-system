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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextbox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(366, 100);
            this.topPanel.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.Location = new System.Drawing.Point(45, 163);
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.categoryNameTextbox.TabIndex = 0;
            // 
            // categoryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.categoryNameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "categoryDetailsForm";
            this.Text = "categoryDetailsForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.categoryNameTextbox, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox categoryNameTextbox;
    }
}