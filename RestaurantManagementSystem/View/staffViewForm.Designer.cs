namespace RestaurantManagementSystem.View
{
    partial class staffViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffViewForm));
            this.staffDatagrid = new System.Windows.Forms.DataGridView();
            this.staffNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.staffDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Size = new System.Drawing.Size(100, 31);
            this.headerLabel.Text = "Staff List";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.staffDatagrid);
            // 
            // staffDatagrid
            // 
            this.staffDatagrid.AllowUserToAddRows = false;
            this.staffDatagrid.AllowUserToDeleteRows = false;
            this.staffDatagrid.AllowUserToResizeColumns = false;
            this.staffDatagrid.AllowUserToResizeRows = false;
            this.staffDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.staffDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.staffDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffDatagrid.ColumnHeadersHeight = 40;
            this.staffDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffNo,
            this.staffId,
            this.staffName,
            this.staffPhone,
            this.staffRole,
            this.staffEdit,
            this.staffDelete});
            this.staffDatagrid.EnableHeadersVisualStyles = false;
            this.staffDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.staffDatagrid.Location = new System.Drawing.Point(59, 6);
            this.staffDatagrid.Name = "staffDatagrid";
            this.staffDatagrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffDatagrid.RowHeadersWidth = 51;
            this.staffDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.staffDatagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.staffDatagrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.staffDatagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffDatagrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffDatagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.staffDatagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffDatagrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffDatagrid.RowTemplate.Height = 40;
            this.staffDatagrid.Size = new System.Drawing.Size(1082, 535);
            this.staffDatagrid.TabIndex = 1;
            this.staffDatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDatagrid_CellClick);
            // 
            // staffNo
            // 
            this.staffNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.staffNo.FillWeight = 70F;
            this.staffNo.HeaderText = "#";
            this.staffNo.MinimumWidth = 70;
            this.staffNo.Name = "staffNo";
            this.staffNo.ReadOnly = true;
            this.staffNo.Width = 70;
            // 
            // staffId
            // 
            this.staffId.HeaderText = "ID";
            this.staffId.MinimumWidth = 6;
            this.staffId.Name = "staffId";
            this.staffId.ReadOnly = true;
            // 
            // staffName
            // 
            this.staffName.HeaderText = "Name";
            this.staffName.MinimumWidth = 6;
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            // 
            // staffPhone
            // 
            this.staffPhone.HeaderText = "Phone";
            this.staffPhone.MinimumWidth = 6;
            this.staffPhone.Name = "staffPhone";
            this.staffPhone.ReadOnly = true;
            // 
            // staffRole
            // 
            this.staffRole.HeaderText = "Role";
            this.staffRole.MinimumWidth = 6;
            this.staffRole.Name = "staffRole";
            this.staffRole.ReadOnly = true;
            // 
            // staffEdit
            // 
            this.staffEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.staffEdit.FillWeight = 50F;
            this.staffEdit.HeaderText = "";
            this.staffEdit.Image = global::RestaurantManagementSystem.Properties.Resources.editBtn;
            this.staffEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.staffEdit.MinimumWidth = 50;
            this.staffEdit.Name = "staffEdit";
            this.staffEdit.ReadOnly = true;
            this.staffEdit.Width = 50;
            // 
            // staffDelete
            // 
            this.staffDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.staffDelete.FillWeight = 50F;
            this.staffDelete.HeaderText = "";
            this.staffDelete.Image = global::RestaurantManagementSystem.Properties.Resources.deleteBtn;
            this.staffDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.staffDelete.MinimumWidth = 50;
            this.staffDelete.Name = "staffDelete";
            this.staffDelete.ReadOnly = true;
            this.staffDelete.Width = 50;
            // 
            // staffViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "staffViewForm";
            this.Text = "iRestaurant - Staff";
            this.Load += new System.EventHandler(this.staffViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView staffDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffRole;
        private System.Windows.Forms.DataGridViewImageColumn staffEdit;
        private System.Windows.Forms.DataGridViewImageColumn staffDelete;
    }
}