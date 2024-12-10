namespace RestaurantManagementSystem.Model
{
    partial class tableDetailsForm
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
            this.tableNameTextbox = new System.Windows.Forms.TextBox();
            this.tableNameLabel = new System.Windows.Forms.Label();
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
            this.headerLabel.Size = new System.Drawing.Size(143, 31);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Table Details";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.tablesBtn;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // tableNameTextbox
            // 
            this.tableNameTextbox.Location = new System.Drawing.Point(45, 163);
            this.tableNameTextbox.Name = "tableNameTextbox";
            this.tableNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.tableNameTextbox.TabIndex = 1;
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(41, 136);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(56, 23);
            this.tableNameLabel.TabIndex = 1;
            this.tableNameLabel.Text = "Name";
            // 
            // tableDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 322);
            this.Controls.Add(this.tableNameTextbox);
            this.Controls.Add(this.tableNameLabel);
            this.Name = "tableDetailsForm";
            this.Text = "tableDetailsForm";
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.tableNameLabel, 0);
            this.Controls.SetChildIndex(this.tableNameTextbox, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tableNameTextbox;
        private System.Windows.Forms.Label tableNameLabel;
    }
}