namespace RestaurantManagementSystem.View
{
    partial class tableViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableViewForm));
            this.tableDatagrid = new System.Windows.Forms.DataGridView();
            this.tableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(108, 31);
            this.headerLabel.Text = "Table List";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.tableDatagrid);
            // 
            // tableDatagrid
            // 
            this.tableDatagrid.AllowUserToAddRows = false;
            this.tableDatagrid.AllowUserToDeleteRows = false;
            this.tableDatagrid.AllowUserToResizeColumns = false;
            this.tableDatagrid.AllowUserToResizeRows = false;
            this.tableDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.tableDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableDatagrid.ColumnHeadersHeight = 40;
            this.tableDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableNo,
            this.tableId,
            this.tableName,
            this.tableEdit,
            this.tableDelete});
            this.tableDatagrid.EnableHeadersVisualStyles = false;
            this.tableDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.tableDatagrid.Location = new System.Drawing.Point(59, 6);
            this.tableDatagrid.Name = "tableDatagrid";
            this.tableDatagrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDatagrid.RowHeadersVisible = false;
            this.tableDatagrid.RowHeadersWidth = 51;
            this.tableDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableDatagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tableDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tableDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDatagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.tableDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDatagrid.RowTemplate.Height = 40;
            this.tableDatagrid.Size = new System.Drawing.Size(1082, 535);
            this.tableDatagrid.TabIndex = 0;
            this.tableDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDatagrid_CellClick);
            // 
            // tableNo
            // 
            this.tableNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tableNo.FillWeight = 70F;
            this.tableNo.HeaderText = "#";
            this.tableNo.MinimumWidth = 70;
            this.tableNo.Name = "tableNo";
            this.tableNo.ReadOnly = true;
            this.tableNo.Width = 70;
            // 
            // tableId
            // 
            this.tableId.HeaderText = "ID";
            this.tableId.MinimumWidth = 6;
            this.tableId.Name = "tableId";
            this.tableId.ReadOnly = true;
            // 
            // tableName
            // 
            this.tableName.HeaderText = "Name";
            this.tableName.MinimumWidth = 6;
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            // 
            // tableEdit
            // 
            this.tableEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tableEdit.FillWeight = 50F;
            this.tableEdit.HeaderText = "";
            this.tableEdit.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.tableEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.tableEdit.MinimumWidth = 50;
            this.tableEdit.Name = "tableEdit";
            this.tableEdit.ReadOnly = true;
            this.tableEdit.Width = 50;
            // 
            // tableDelete
            // 
            this.tableDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tableDelete.FillWeight = 50F;
            this.tableDelete.HeaderText = "";
            this.tableDelete.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.tableDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.tableDelete.MinimumWidth = 50;
            this.tableDelete.Name = "tableDelete";
            this.tableDelete.ReadOnly = true;
            this.tableDelete.Width = 50;
            // 
            // tableViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tableViewForm";
            this.Text = "iRestaurant - Table";
            this.Load += new System.EventHandler(this.tableViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableName;
        private System.Windows.Forms.DataGridViewImageColumn tableEdit;
        private System.Windows.Forms.DataGridViewImageColumn tableDelete;
    }
}