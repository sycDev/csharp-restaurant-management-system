namespace RestaurantManagementSystem
{
    partial class viewFormTemplate
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.topbarPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(828, 60);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(61, 23);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.Location = new System.Drawing.Point(832, 86);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(309, 30);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(53, 27);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(88, 31);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Header";
            // 
            // topbarPanel
            // 
            this.topbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.Size = new System.Drawing.Size(1200, 133);
            this.topbarPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 133);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1200, 547);
            this.contentPanel.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Image = global::RestaurantManagementSystem.Properties.Resources.addBtn;
            this.addBtn.Location = new System.Drawing.Point(59, 61);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(55, 55);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBtn.TabIndex = 2;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // viewFormTemplate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.topbarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 680);
            this.Name = "viewFormTemplate";
            this.Text = "viewFormTemplate";
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label searchLabel;
        public System.Windows.Forms.TextBox searchTextbox;
        public System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.PictureBox addBtn;
        public System.Windows.Forms.Panel contentPanel;
        public System.Windows.Forms.Panel topbarPanel;
    }
}