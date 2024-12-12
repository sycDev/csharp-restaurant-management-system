namespace RestaurantManagementSystem
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.appLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarHeaderPanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.posBtn = new System.Windows.Forms.Button();
            this.kitchenBtn = new System.Windows.Forms.Button();
            this.sidebarPanel.SuspendLayout();
            this.sidebarHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.appLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.ForeColor = System.Drawing.Color.White;
            this.appLabel.Location = new System.Drawing.Point(66, 104);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(164, 37);
            this.appLabel.TabIndex = 0;
            this.appLabel.Text = "iRestaurant";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.sidebarPanel.Controls.Add(this.sidebarHeaderPanel);
            this.sidebarPanel.Controls.Add(this.homeBtn);
            this.sidebarPanel.Controls.Add(this.categoriesBtn);
            this.sidebarPanel.Controls.Add(this.productsBtn);
            this.sidebarPanel.Controls.Add(this.tablesBtn);
            this.sidebarPanel.Controls.Add(this.staffBtn);
            this.sidebarPanel.Controls.Add(this.posBtn);
            this.sidebarPanel.Controls.Add(this.kitchenBtn);
            this.sidebarPanel.Controls.Add(this.settingsBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.MaximumSize = new System.Drawing.Size(300, 0);
            this.sidebarPanel.MinimumSize = new System.Drawing.Size(104, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 913);
            this.sidebarPanel.TabIndex = 11;
            // 
            // sidebarHeaderPanel
            // 
            this.sidebarHeaderPanel.Controls.Add(this.appLabel);
            this.sidebarHeaderPanel.Controls.Add(this.appLogo);
            this.sidebarHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.sidebarHeaderPanel.Name = "sidebarHeaderPanel";
            this.sidebarHeaderPanel.Size = new System.Drawing.Size(297, 149);
            this.sidebarHeaderPanel.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = global::RestaurantManagementSystem.Properties.Resources.settingsNav;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(3, 620);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingsBtn.Size = new System.Drawing.Size(290, 60);
            this.settingsBtn.TabIndex = 8;
            this.settingsBtn.Text = "             Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(300, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1582, 913);
            this.mainPanel.TabIndex = 1;
            // 
            // appLogo
            // 
            this.appLogo.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.icon;
            this.appLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appLogo.Location = new System.Drawing.Point(105, 21);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(85, 80);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 10;
            this.appLogo.TabStop = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = global::RestaurantManagementSystem.Properties.Resources.homeNav;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(3, 158);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(297, 60);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "             Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Image = global::RestaurantManagementSystem.Properties.Resources.categoriesNav;
            this.categoriesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesBtn.Location = new System.Drawing.Point(3, 224);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.categoriesBtn.Size = new System.Drawing.Size(297, 60);
            this.categoriesBtn.TabIndex = 2;
            this.categoriesBtn.Text = "             Categories";
            this.categoriesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.ForeColor = System.Drawing.Color.White;
            this.productsBtn.Image = global::RestaurantManagementSystem.Properties.Resources.productsNav;
            this.productsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.Location = new System.Drawing.Point(3, 290);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.productsBtn.Size = new System.Drawing.Size(297, 60);
            this.productsBtn.TabIndex = 3;
            this.productsBtn.Text = "             Products";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // tablesBtn
            // 
            this.tablesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablesBtn.FlatAppearance.BorderSize = 0;
            this.tablesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesBtn.ForeColor = System.Drawing.Color.White;
            this.tablesBtn.Image = global::RestaurantManagementSystem.Properties.Resources.tablesNav;
            this.tablesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tablesBtn.Location = new System.Drawing.Point(3, 356);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tablesBtn.Size = new System.Drawing.Size(297, 60);
            this.tablesBtn.TabIndex = 4;
            this.tablesBtn.Text = "             Tables";
            this.tablesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tablesBtn.UseVisualStyleBackColor = true;
            this.tablesBtn.Click += new System.EventHandler(this.tablesBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = global::RestaurantManagementSystem.Properties.Resources.staffNav;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(3, 422);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.staffBtn.Size = new System.Drawing.Size(290, 60);
            this.staffBtn.TabIndex = 5;
            this.staffBtn.Text = "             Staff";
            this.staffBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // posBtn
            // 
            this.posBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.posBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.posBtn.FlatAppearance.BorderSize = 0;
            this.posBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posBtn.ForeColor = System.Drawing.Color.White;
            this.posBtn.Image = global::RestaurantManagementSystem.Properties.Resources.posNav;
            this.posBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posBtn.Location = new System.Drawing.Point(3, 488);
            this.posBtn.Name = "posBtn";
            this.posBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.posBtn.Size = new System.Drawing.Size(290, 60);
            this.posBtn.TabIndex = 6;
            this.posBtn.Text = "             POS";
            this.posBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.posBtn.UseVisualStyleBackColor = true;
            this.posBtn.Click += new System.EventHandler(this.posBtn_Click);
            // 
            // kitchenBtn
            // 
            this.kitchenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kitchenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitchenBtn.FlatAppearance.BorderSize = 0;
            this.kitchenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitchenBtn.ForeColor = System.Drawing.Color.White;
            this.kitchenBtn.Image = global::RestaurantManagementSystem.Properties.Resources.kitchenNav;
            this.kitchenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitchenBtn.Location = new System.Drawing.Point(3, 554);
            this.kitchenBtn.Name = "kitchenBtn";
            this.kitchenBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.kitchenBtn.Size = new System.Drawing.Size(290, 60);
            this.kitchenBtn.TabIndex = 7;
            this.kitchenBtn.Text = "             Kitchen";
            this.kitchenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitchenBtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1882, 913);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1900, 960);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iRestaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarHeaderPanel.ResumeLayout(false);
            this.sidebarHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.FlowLayoutPanel sidebarPanel;
        private System.Windows.Forms.Panel sidebarHeaderPanel;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button tablesBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button posBtn;
        private System.Windows.Forms.Button kitchenBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Panel mainPanel;
    }
}