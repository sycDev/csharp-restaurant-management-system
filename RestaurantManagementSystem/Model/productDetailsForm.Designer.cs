namespace RestaurantManagementSystem.Model
{
    partial class productDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productDetailsForm));
            this.productPriceTextbox = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.imagePlaceholder = new System.Windows.Forms.PictureBox();
            this.browseImageBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlaceholder)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.TabIndex = 8;
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(170, 31);
            this.headerLabel.Text = "Product Details";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.product;
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // productPriceTextbox
            // 
            this.productPriceTextbox.Location = new System.Drawing.Point(36, 224);
            this.productPriceTextbox.Name = "productPriceTextbox";
            this.productPriceTextbox.Size = new System.Drawing.Size(283, 30);
            this.productPriceTextbox.TabIndex = 4;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(32, 197);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(47, 23);
            this.productPriceLabel.TabIndex = 3;
            this.productPriceLabel.Text = "Price";
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(36, 158);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(283, 30);
            this.productNameTextbox.TabIndex = 2;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(32, 131);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(56, 23);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Name";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(32, 262);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(79, 23);
            this.productCategoryLabel.TabIndex = 5;
            this.productCategoryLabel.Text = "Category";
            // 
            // productCategoryCombobox
            // 
            this.productCategoryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryCombobox.FormattingEnabled = true;
            this.productCategoryCombobox.Location = new System.Drawing.Point(36, 288);
            this.productCategoryCombobox.Name = "productCategoryCombobox";
            this.productCategoryCombobox.Size = new System.Drawing.Size(283, 31);
            this.productCategoryCombobox.TabIndex = 6;
            // 
            // imagePlaceholder
            // 
            this.imagePlaceholder.Image = global::RestaurantManagementSystem.Properties.Resources.placeholder;
            this.imagePlaceholder.Location = new System.Drawing.Point(501, 112);
            this.imagePlaceholder.Name = "imagePlaceholder";
            this.imagePlaceholder.Size = new System.Drawing.Size(179, 173);
            this.imagePlaceholder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePlaceholder.TabIndex = 11;
            this.imagePlaceholder.TabStop = false;
            // 
            // browseImageBtn
            // 
            this.browseImageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseImageBtn.Location = new System.Drawing.Point(501, 301);
            this.browseImageBtn.Name = "browseImageBtn";
            this.browseImageBtn.Size = new System.Drawing.Size(179, 43);
            this.browseImageBtn.TabIndex = 7;
            this.browseImageBtn.Text = "BROWSE";
            this.browseImageBtn.UseVisualStyleBackColor = true;
            this.browseImageBtn.Click += new System.EventHandler(this.browseImageBtn_Click);
            // 
            // productDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browseImageBtn);
            this.Controls.Add(this.imagePlaceholder);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productCategoryCombobox);
            this.Controls.Add(this.productPriceTextbox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.productNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productDetailsForm";
            this.Text = "iRestaurant - Product Details";
            this.Load += new System.EventHandler(this.productDetailsForm_Load);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.bottomPanel, 0);
            this.Controls.SetChildIndex(this.productNameLabel, 0);
            this.Controls.SetChildIndex(this.productNameTextbox, 0);
            this.Controls.SetChildIndex(this.productPriceLabel, 0);
            this.Controls.SetChildIndex(this.productPriceTextbox, 0);
            this.Controls.SetChildIndex(this.productCategoryCombobox, 0);
            this.Controls.SetChildIndex(this.productCategoryLabel, 0);
            this.Controls.SetChildIndex(this.imagePlaceholder, 0);
            this.Controls.SetChildIndex(this.browseImageBtn, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlaceholder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox productPriceTextbox;
        private System.Windows.Forms.Label productPriceLabel;
        public System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        public System.Windows.Forms.ComboBox productCategoryCombobox;
        public System.Windows.Forms.PictureBox imagePlaceholder;
        public System.Windows.Forms.Button browseImageBtn;
    }
}