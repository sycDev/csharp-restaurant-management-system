namespace RestaurantManagementSystem.View
{
    partial class productViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productViewForm));
            this.productDatagrid = new System.Windows.Forms.DataGridView();
            this.productNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.productDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(135, 31);
            this.headerLabel.Text = "Product List";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.productDatagrid);
            // 
            // productDatagrid
            // 
            this.productDatagrid.AllowUserToAddRows = false;
            this.productDatagrid.AllowUserToDeleteRows = false;
            this.productDatagrid.AllowUserToResizeColumns = false;
            this.productDatagrid.AllowUserToResizeRows = false;
            this.productDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.productDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productDatagrid.ColumnHeadersHeight = 40;
            this.productDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNo,
            this.productId,
            this.productName,
            this.productPrice,
            this.productCategoryId,
            this.productCategory,
            this.productImage,
            this.productEdit,
            this.productDelete});
            this.productDatagrid.EnableHeadersVisualStyles = false;
            this.productDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.productDatagrid.Location = new System.Drawing.Point(59, 6);
            this.productDatagrid.Name = "productDatagrid";
            this.productDatagrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDatagrid.RowHeadersVisible = false;
            this.productDatagrid.RowHeadersWidth = 51;
            this.productDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productDatagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.productDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.productDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDatagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.productDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDatagrid.RowTemplate.Height = 40;
            this.productDatagrid.Size = new System.Drawing.Size(1082, 535);
            this.productDatagrid.TabIndex = 1;
            this.productDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDatagrid_CellClick);
            // 
            // productNo
            // 
            this.productNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNo.FillWeight = 70F;
            this.productNo.HeaderText = "#";
            this.productNo.MinimumWidth = 70;
            this.productNo.Name = "productNo";
            this.productNo.ReadOnly = true;
            this.productNo.Width = 70;
            // 
            // productId
            // 
            this.productId.HeaderText = "ID";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price (RM)";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productCategoryId
            // 
            this.productCategoryId.HeaderText = "Category ID";
            this.productCategoryId.MinimumWidth = 6;
            this.productCategoryId.Name = "productCategoryId";
            this.productCategoryId.ReadOnly = true;
            this.productCategoryId.Visible = false;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // productImage
            // 
            this.productImage.HeaderText = "Image";
            this.productImage.MinimumWidth = 6;
            this.productImage.Name = "productImage";
            this.productImage.ReadOnly = true;
            this.productImage.Visible = false;
            // 
            // productEdit
            // 
            this.productEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productEdit.FillWeight = 50F;
            this.productEdit.HeaderText = "";
            this.productEdit.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.productEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productEdit.MinimumWidth = 50;
            this.productEdit.Name = "productEdit";
            this.productEdit.ReadOnly = true;
            this.productEdit.Width = 50;
            // 
            // productDelete
            // 
            this.productDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productDelete.FillWeight = 50F;
            this.productDelete.HeaderText = "";
            this.productDelete.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.productDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productDelete.MinimumWidth = 50;
            this.productDelete.Name = "productDelete";
            this.productDelete.ReadOnly = true;
            this.productDelete.Width = 50;
            // 
            // productViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productViewForm";
            this.Text = "iRestaurant - Product";
            this.Load += new System.EventHandler(this.productViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImage;
        private System.Windows.Forms.DataGridViewImageColumn productEdit;
        private System.Windows.Forms.DataGridViewImageColumn productDelete;
    }
}