namespace RestaurantManagementSystem.Model
{
    partial class checkoutDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkoutDetailsForm));
            this.changeLabel = new System.Windows.Forms.Label();
            this.receivedTextbox = new System.Windows.Forms.TextBox();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.changeTextbox = new System.Windows.Forms.TextBox();
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
            this.headerLabel.Size = new System.Drawing.Size(109, 31);
            this.headerLabel.Text = "Checkout";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.billList;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(30, 270);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(69, 23);
            this.changeLabel.TabIndex = 11;
            this.changeLabel.Text = "Change";
            // 
            // receivedTextbox
            // 
            this.receivedTextbox.Location = new System.Drawing.Point(34, 232);
            this.receivedTextbox.Name = "receivedTextbox";
            this.receivedTextbox.Size = new System.Drawing.Size(283, 30);
            this.receivedTextbox.TabIndex = 10;
            this.receivedTextbox.TextChanged += new System.EventHandler(this.receivedTextbox_TextChanged);
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Location = new System.Drawing.Point(30, 205);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(148, 23);
            this.receivedLabel.TabIndex = 9;
            this.receivedLabel.Text = "Payment Received";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Enabled = false;
            this.amountTextbox.Location = new System.Drawing.Point(34, 166);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(283, 30);
            this.amountTextbox.TabIndex = 8;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(30, 139);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(99, 23);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Bill Amount";
            // 
            // changeTextbox
            // 
            this.changeTextbox.Enabled = false;
            this.changeTextbox.Location = new System.Drawing.Point(34, 300);
            this.changeTextbox.Name = "changeTextbox";
            this.changeTextbox.Size = new System.Drawing.Size(283, 30);
            this.changeTextbox.TabIndex = 12;
            this.changeTextbox.Text = "0.00";
            // 
            // checkoutDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.changeTextbox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.receivedTextbox);
            this.Controls.Add(this.receivedLabel);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.amountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkoutDetailsForm";
            this.Text = "checkoutDetailsForm";
            this.Load += new System.EventHandler(this.checkoutDetailsForm_Load);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.amountLabel, 0);
            this.Controls.SetChildIndex(this.amountTextbox, 0);
            this.Controls.SetChildIndex(this.receivedLabel, 0);
            this.Controls.SetChildIndex(this.receivedTextbox, 0);
            this.Controls.SetChildIndex(this.changeLabel, 0);
            this.Controls.SetChildIndex(this.changeTextbox, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label changeLabel;
        public System.Windows.Forms.TextBox receivedTextbox;
        private System.Windows.Forms.Label receivedLabel;
        public System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label amountLabel;
        public System.Windows.Forms.TextBox changeTextbox;
    }
}