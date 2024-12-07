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
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(474, 84);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(362, 30);
            this.searchTextbox.TabIndex = 0;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(470, 58);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(61, 23);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.addBtn;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(48, 56);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(62, 58);
            this.addBtn.TabIndex = 2;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.addBtn);
            this.splitContainer.Panel1.Controls.Add(this.headerLabel);
            this.splitContainer.Panel1.Controls.Add(this.searchTextbox);
            this.splitContainer.Panel1.Controls.Add(this.searchLabel);
            this.splitContainer.Size = new System.Drawing.Size(876, 623);
            this.splitContainer.SplitterDistance = 138;
            this.splitContainer.TabIndex = 3;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(43, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(75, 28);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Header";
            // 
            // viewFormTemplate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewFormTemplate";
            this.Text = "viewFormTemplate";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.TextBox searchTextbox;
        public System.Windows.Forms.Button addBtn;
    }
}