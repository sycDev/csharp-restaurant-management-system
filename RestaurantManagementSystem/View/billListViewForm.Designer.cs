namespace RestaurantManagementSystem.View
{
    partial class billListViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billListViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.orderDatagrid = new System.Windows.Forms.DataGridView();
            this.billNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.orderDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Controls.Add(this.headerLabel);
            this.topPanel.Controls.Add(this.picturebox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 100);
            this.topPanel.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1140, 31);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 35);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(107, 31);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(86, 31);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Bill List";
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Image = global::RestaurantManagementSystem.Properties.Resources.billList;
            this.picturebox.Location = new System.Drawing.Point(16, 12);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(72, 72);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // orderDatagrid
            // 
            this.orderDatagrid.AllowUserToAddRows = false;
            this.orderDatagrid.AllowUserToDeleteRows = false;
            this.orderDatagrid.AllowUserToResizeColumns = false;
            this.orderDatagrid.AllowUserToResizeRows = false;
            this.orderDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.orderDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderDatagrid.ColumnHeadersHeight = 40;
            this.orderDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billNo,
            this.orderId,
            this.tableName,
            this.waiterName,
            this.orderType,
            this.orderStatus,
            this.orderTotal,
            this.orderEdit,
            this.orderDelete});
            this.orderDatagrid.EnableHeadersVisualStyles = false;
            this.orderDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.orderDatagrid.Location = new System.Drawing.Point(62, 119);
            this.orderDatagrid.Name = "orderDatagrid";
            this.orderDatagrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDatagrid.RowHeadersVisible = false;
            this.orderDatagrid.RowHeadersWidth = 51;
            this.orderDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderDatagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.orderDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.orderDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDatagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.orderDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDatagrid.RowTemplate.Height = 40;
            this.orderDatagrid.Size = new System.Drawing.Size(1082, 535);
            this.orderDatagrid.TabIndex = 2;
            this.orderDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDatagrid_CellClick);
            // 
            // billNo
            // 
            this.billNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.billNo.FillWeight = 70F;
            this.billNo.HeaderText = "#";
            this.billNo.MinimumWidth = 70;
            this.billNo.Name = "billNo";
            this.billNo.ReadOnly = true;
            this.billNo.Width = 70;
            // 
            // orderId
            // 
            this.orderId.HeaderText = "ID";
            this.orderId.MinimumWidth = 6;
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // tableName
            // 
            this.tableName.HeaderText = "Table";
            this.tableName.MinimumWidth = 6;
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            // 
            // waiterName
            // 
            this.waiterName.HeaderText = "Waiter";
            this.waiterName.MinimumWidth = 6;
            this.waiterName.Name = "waiterName";
            this.waiterName.ReadOnly = true;
            // 
            // orderType
            // 
            this.orderType.HeaderText = "Order Type";
            this.orderType.MinimumWidth = 6;
            this.orderType.Name = "orderType";
            this.orderType.ReadOnly = true;
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Status";
            this.orderStatus.MinimumWidth = 6;
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            // 
            // orderTotal
            // 
            this.orderTotal.HeaderText = "Total";
            this.orderTotal.MinimumWidth = 6;
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.ReadOnly = true;
            // 
            // orderEdit
            // 
            this.orderEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderEdit.FillWeight = 50F;
            this.orderEdit.HeaderText = "";
            this.orderEdit.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.orderEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.orderEdit.MinimumWidth = 50;
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.ReadOnly = true;
            this.orderEdit.Width = 50;
            // 
            // orderDelete
            // 
            this.orderDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderDelete.FillWeight = 50F;
            this.orderDelete.HeaderText = "";
            this.orderDelete.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.orderDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.orderDelete.MinimumWidth = 50;
            this.orderDelete.Name = "orderDelete";
            this.orderDelete.ReadOnly = true;
            this.orderDelete.Visible = false;
            this.orderDelete.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // billListViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.orderDatagrid);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "billListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iRestaurant - Bill List";
            this.Load += new System.EventHandler(this.billListViewForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.DataGridView orderDatagrid;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn waiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotal;
        private System.Windows.Forms.DataGridViewImageColumn orderEdit;
        private System.Windows.Forms.DataGridViewImageColumn orderDelete;
    }
}