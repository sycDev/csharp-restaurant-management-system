namespace RestaurantManagementSystem.Model
{
    partial class productUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productUserControl));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.pNamePanel = new System.Windows.Forms.Panel();
            this.pNameLabel = new System.Windows.Forms.Label();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.containerPanel.SuspendLayout();
            this.pNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.White;
            this.containerPanel.Controls.Add(this.pNamePanel);
            this.containerPanel.Controls.Add(this.pImage);
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(200, 200);
            this.containerPanel.TabIndex = 0;
            // 
            // pNamePanel
            // 
            this.pNamePanel.Controls.Add(this.pNameLabel);
            this.pNamePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pNamePanel.Location = new System.Drawing.Point(0, 153);
            this.pNamePanel.Name = "pNamePanel";
            this.pNamePanel.Size = new System.Drawing.Size(200, 47);
            this.pNamePanel.TabIndex = 1;
            // 
            // pNameLabel
            // 
            this.pNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.pNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameLabel.Location = new System.Drawing.Point(0, 0);
            this.pNameLabel.Name = "pNameLabel";
            this.pNameLabel.Size = new System.Drawing.Size(200, 47);
            this.pNameLabel.TabIndex = 0;
            this.pNameLabel.Text = "Product Name";
            this.pNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pImage
            // 
            this.pImage.BackColor = System.Drawing.Color.Transparent;
            this.pImage.Image = ((System.Drawing.Image)(resources.GetObject("pImage.Image")));
            this.pImage.Location = new System.Drawing.Point(32, 10);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(135, 135);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pImage.TabIndex = 0;
            this.pImage.TabStop = false;
            this.pImage.Click += new System.EventHandler(this.pImage_Click);
            // 
            // productUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.containerPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "productUserControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.containerPanel.ResumeLayout(false);
            this.pNamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Panel pNamePanel;
        private System.Windows.Forms.Label pNameLabel;
    }
}
