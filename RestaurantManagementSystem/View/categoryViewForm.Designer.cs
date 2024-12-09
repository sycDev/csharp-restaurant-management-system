namespace RestaurantManagementSystem.View
{
    partial class categoryViewForm
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
            this.categoryDatagrid = new System.Windows.Forms.DataGridView();
            this.categoryNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(147, 31);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Category List";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.categoryDatagrid);
            this.contentPanel.TabIndex = 3;
            // 
            // topbarPanel
            // 
            this.topbarPanel.TabIndex = 0;
            // 
            // categoryDatagrid
            // 
            this.categoryDatagrid.AllowUserToAddRows = false;
            this.categoryDatagrid.AllowUserToDeleteRows = false;
            this.categoryDatagrid.AllowUserToResizeColumns = false;
            this.categoryDatagrid.AllowUserToResizeRows = false;
            this.categoryDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.categoryDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryDatagrid.ColumnHeadersHeight = 40;
            this.categoryDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNo,
            this.categoryId,
            this.categoryName,
            this.categoryEdit,
            this.categoryDelete});
            this.categoryDatagrid.EnableHeadersVisualStyles = false;
            this.categoryDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.categoryDatagrid.Location = new System.Drawing.Point(59, 6);
            this.categoryDatagrid.Name = "categoryDatagrid";
            this.categoryDatagrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDatagrid.RowHeadersWidth = 51;
            this.categoryDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.categoryDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDatagrid.RowTemplate.Height = 40;
            this.categoryDatagrid.Size = new System.Drawing.Size(1082, 535);
            this.categoryDatagrid.TabIndex = 0;
            this.categoryDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDatagrid_CellClick);
            // 
            // categoryNo
            // 
            this.categoryNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoryNo.FillWeight = 70F;
            this.categoryNo.HeaderText = "#";
            this.categoryNo.MinimumWidth = 70;
            this.categoryNo.Name = "categoryNo";
            this.categoryNo.ReadOnly = true;
            this.categoryNo.Width = 70;
            // 
            // categoryId
            // 
            this.categoryId.HeaderText = "ID";
            this.categoryId.MinimumWidth = 6;
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "Name";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            // 
            // categoryEdit
            // 
            this.categoryEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoryEdit.FillWeight = 50F;
            this.categoryEdit.HeaderText = "";
            this.categoryEdit.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.categoryEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.categoryEdit.MinimumWidth = 50;
            this.categoryEdit.Name = "categoryEdit";
            this.categoryEdit.ReadOnly = true;
            this.categoryEdit.Width = 50;
            // 
            // categoryDelete
            // 
            this.categoryDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categoryDelete.FillWeight = 50F;
            this.categoryDelete.HeaderText = "";
            this.categoryDelete.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.categoryDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.categoryDelete.MinimumWidth = 50;
            this.categoryDelete.Name = "categoryDelete";
            this.categoryDelete.ReadOnly = true;
            this.categoryDelete.Width = 50;
            // 
            // categoryViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Name = "categoryViewForm";
            this.Text = "categoryViewForm";
            this.Load += new System.EventHandler(this.categoryViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewImageColumn categoryEdit;
        private System.Windows.Forms.DataGridViewImageColumn categoryDelete;
    }
}