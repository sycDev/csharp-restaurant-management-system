namespace RestaurantManagementSystem.Model
{
    partial class posForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(posForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.dineInBtn = new System.Windows.Forms.Button();
            this.takeAwayBtn = new System.Windows.Forms.Button();
            this.deliveryBtn = new System.Windows.Forms.Button();
            this.kotBtn = new System.Windows.Forms.Button();
            this.billListBtn = new System.Windows.Forms.Button();
            this.holdBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.waiterLabel = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.powerOffBtn = new System.Windows.Forms.PictureBox();
            this.posIcon = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.totalTxtLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderDatagrid = new System.Windows.Forms.DataGridView();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posIcon)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.topPanel.Controls.Add(this.dineInBtn);
            this.topPanel.Controls.Add(this.takeAwayBtn);
            this.topPanel.Controls.Add(this.deliveryBtn);
            this.topPanel.Controls.Add(this.kotBtn);
            this.topPanel.Controls.Add(this.billListBtn);
            this.topPanel.Controls.Add(this.holdBtn);
            this.topPanel.Controls.Add(this.newBtn);
            this.topPanel.Controls.Add(this.waiterLabel);
            this.topPanel.Controls.Add(this.tableLabel);
            this.topPanel.Controls.Add(this.posLabel);
            this.topPanel.Controls.Add(this.powerOffBtn);
            this.topPanel.Controls.Add(this.posIcon);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1600, 120);
            this.topPanel.TabIndex = 0;
            // 
            // dineInBtn
            // 
            this.dineInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.dineInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dineInBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.dineInBtn.FlatAppearance.BorderSize = 2;
            this.dineInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dineInBtn.ForeColor = System.Drawing.Color.White;
            this.dineInBtn.Image = global::RestaurantManagementSystem.Properties.Resources.dineInBtn;
            this.dineInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dineInBtn.Location = new System.Drawing.Point(824, 9);
            this.dineInBtn.Name = "dineInBtn";
            this.dineInBtn.Size = new System.Drawing.Size(100, 100);
            this.dineInBtn.TabIndex = 8;
            this.dineInBtn.Text = "Dine In";
            this.dineInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dineInBtn.UseVisualStyleBackColor = false;
            this.dineInBtn.Click += new System.EventHandler(this.dineInBtn_Click);
            // 
            // takeAwayBtn
            // 
            this.takeAwayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.takeAwayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.takeAwayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.takeAwayBtn.FlatAppearance.BorderSize = 2;
            this.takeAwayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeAwayBtn.ForeColor = System.Drawing.Color.White;
            this.takeAwayBtn.Image = global::RestaurantManagementSystem.Properties.Resources.takeAwayBtn;
            this.takeAwayBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.takeAwayBtn.Location = new System.Drawing.Point(718, 9);
            this.takeAwayBtn.Name = "takeAwayBtn";
            this.takeAwayBtn.Size = new System.Drawing.Size(100, 100);
            this.takeAwayBtn.TabIndex = 7;
            this.takeAwayBtn.Text = "Take Away";
            this.takeAwayBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.takeAwayBtn.UseVisualStyleBackColor = false;
            this.takeAwayBtn.Click += new System.EventHandler(this.takeAwayBtn_Click);
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.deliveryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.deliveryBtn.FlatAppearance.BorderSize = 2;
            this.deliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryBtn.ForeColor = System.Drawing.Color.White;
            this.deliveryBtn.Image = global::RestaurantManagementSystem.Properties.Resources.deliveryBtn;
            this.deliveryBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deliveryBtn.Location = new System.Drawing.Point(612, 9);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(100, 100);
            this.deliveryBtn.TabIndex = 6;
            this.deliveryBtn.Text = "Delivery";
            this.deliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deliveryBtn.UseVisualStyleBackColor = false;
            this.deliveryBtn.Click += new System.EventHandler(this.deliveryBtn_Click);
            // 
            // kotBtn
            // 
            this.kotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.kotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kotBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.kotBtn.FlatAppearance.BorderSize = 2;
            this.kotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kotBtn.ForeColor = System.Drawing.Color.White;
            this.kotBtn.Image = global::RestaurantManagementSystem.Properties.Resources.kotBtn;
            this.kotBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kotBtn.Location = new System.Drawing.Point(506, 9);
            this.kotBtn.Name = "kotBtn";
            this.kotBtn.Size = new System.Drawing.Size(100, 100);
            this.kotBtn.TabIndex = 5;
            this.kotBtn.Text = "KOT";
            this.kotBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kotBtn.UseVisualStyleBackColor = false;
            this.kotBtn.Click += new System.EventHandler(this.kotBtn_Click);
            // 
            // billListBtn
            // 
            this.billListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.billListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.billListBtn.FlatAppearance.BorderSize = 2;
            this.billListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billListBtn.ForeColor = System.Drawing.Color.White;
            this.billListBtn.Image = global::RestaurantManagementSystem.Properties.Resources.billListBtn;
            this.billListBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billListBtn.Location = new System.Drawing.Point(400, 9);
            this.billListBtn.Name = "billListBtn";
            this.billListBtn.Size = new System.Drawing.Size(100, 100);
            this.billListBtn.TabIndex = 4;
            this.billListBtn.Text = "Bill List";
            this.billListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.billListBtn.UseVisualStyleBackColor = false;
            // 
            // holdBtn
            // 
            this.holdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.holdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.holdBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.holdBtn.FlatAppearance.BorderSize = 2;
            this.holdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holdBtn.ForeColor = System.Drawing.Color.White;
            this.holdBtn.Image = global::RestaurantManagementSystem.Properties.Resources.holdBtn;
            this.holdBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.holdBtn.Location = new System.Drawing.Point(294, 9);
            this.holdBtn.Name = "holdBtn";
            this.holdBtn.Size = new System.Drawing.Size(100, 100);
            this.holdBtn.TabIndex = 3;
            this.holdBtn.Text = "Hold";
            this.holdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.holdBtn.UseVisualStyleBackColor = false;
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.newBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.newBtn.FlatAppearance.BorderSize = 2;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.Image = global::RestaurantManagementSystem.Properties.Resources.newOrderBtn;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newBtn.Location = new System.Drawing.Point(188, 9);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(100, 100);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "New";
            this.newBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // waiterLabel
            // 
            this.waiterLabel.AutoSize = true;
            this.waiterLabel.BackColor = System.Drawing.Color.Transparent;
            this.waiterLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waiterLabel.ForeColor = System.Drawing.Color.White;
            this.waiterLabel.Location = new System.Drawing.Point(943, 59);
            this.waiterLabel.Name = "waiterLabel";
            this.waiterLabel.Size = new System.Drawing.Size(80, 31);
            this.waiterLabel.TabIndex = 0;
            this.waiterLabel.Text = "Waiter";
            this.waiterLabel.Visible = false;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.Color.White;
            this.tableLabel.Location = new System.Drawing.Point(943, 28);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(67, 31);
            this.tableLabel.TabIndex = 0;
            this.tableLabel.Text = "Table";
            this.tableLabel.Visible = false;
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.BackColor = System.Drawing.Color.Transparent;
            this.posLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLabel.ForeColor = System.Drawing.Color.White;
            this.posLabel.Location = new System.Drawing.Point(92, 41);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(58, 31);
            this.posLabel.TabIndex = 1;
            this.posLabel.Text = "POS";
            // 
            // powerOffBtn
            // 
            this.powerOffBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerOffBtn.BackColor = System.Drawing.Color.Transparent;
            this.powerOffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerOffBtn.Image = global::RestaurantManagementSystem.Properties.Resources.powerOffBtn;
            this.powerOffBtn.Location = new System.Drawing.Point(1531, 41);
            this.powerOffBtn.Name = "powerOffBtn";
            this.powerOffBtn.Size = new System.Drawing.Size(35, 35);
            this.powerOffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.powerOffBtn.TabIndex = 0;
            this.powerOffBtn.TabStop = false;
            this.powerOffBtn.Click += new System.EventHandler(this.powerOffBtn_Click);
            // 
            // posIcon
            // 
            this.posIcon.BackColor = System.Drawing.Color.Transparent;
            this.posIcon.Image = global::RestaurantManagementSystem.Properties.Resources.POS;
            this.posIcon.Location = new System.Drawing.Point(26, 28);
            this.posIcon.Name = "posIcon";
            this.posIcon.Size = new System.Drawing.Size(60, 60);
            this.posIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posIcon.TabIndex = 0;
            this.posIcon.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bottomPanel.Controls.Add(this.totalTxtLabel);
            this.bottomPanel.Controls.Add(this.totalLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 800);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1600, 100);
            this.bottomPanel.TabIndex = 6;
            // 
            // totalTxtLabel
            // 
            this.totalTxtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTxtLabel.AutoSize = true;
            this.totalTxtLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTxtLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxtLabel.ForeColor = System.Drawing.Color.White;
            this.totalTxtLabel.Location = new System.Drawing.Point(1272, 36);
            this.totalTxtLabel.Name = "totalTxtLabel";
            this.totalTxtLabel.Size = new System.Drawing.Size(55, 31);
            this.totalTxtLabel.TabIndex = 10;
            this.totalTxtLabel.Text = "0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(1208, 36);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(68, 31);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            // 
            // categoryPanel
            // 
            this.categoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryPanel.Location = new System.Drawing.Point(13, 162);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(232, 632);
            this.categoryPanel.TabIndex = 3;
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPanel.AutoScroll = true;
            this.productPanel.Location = new System.Drawing.Point(251, 162);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(950, 632);
            this.productPanel.TabIndex = 4;
            // 
            // orderDatagrid
            // 
            this.orderDatagrid.AllowUserToAddRows = false;
            this.orderDatagrid.AllowUserToDeleteRows = false;
            this.orderDatagrid.AllowUserToResizeColumns = false;
            this.orderDatagrid.AllowUserToResizeRows = false;
            this.orderDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orderDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.orderDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.orderDatagrid.ColumnHeadersHeight = 40;
            this.orderDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.orderDetailsId,
            this.productId,
            this.productName,
            this.orderQty,
            this.productPrice,
            this.orderAmount});
            this.orderDatagrid.EnableHeadersVisualStyles = false;
            this.orderDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.orderDatagrid.Location = new System.Drawing.Point(1207, 162);
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
            this.orderDatagrid.Size = new System.Drawing.Size(381, 632);
            this.orderDatagrid.TabIndex = 5;
            this.orderDatagrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.orderDatagrid_CellFormatting);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(311, 129);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(309, 30);
            this.searchTextbox.TabIndex = 2;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(248, 132);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(61, 23);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // orderNo
            // 
            this.orderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderNo.FillWeight = 30F;
            this.orderNo.HeaderText = "#";
            this.orderNo.MinimumWidth = 30;
            this.orderNo.Name = "orderNo";
            this.orderNo.ReadOnly = true;
            this.orderNo.Width = 30;
            // 
            // orderDetailsId
            // 
            this.orderDetailsId.FillWeight = 50F;
            this.orderDetailsId.HeaderText = "odID";
            this.orderDetailsId.MinimumWidth = 50;
            this.orderDetailsId.Name = "orderDetailsId";
            this.orderDetailsId.ReadOnly = true;
            this.orderDetailsId.Visible = false;
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productId.FillWeight = 50F;
            this.productId.HeaderText = "ID";
            this.productId.MinimumWidth = 50;
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 50;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // orderQty
            // 
            this.orderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderQty.FillWeight = 40F;
            this.orderQty.HeaderText = "Qty";
            this.orderQty.MinimumWidth = 40;
            this.orderQty.Name = "orderQty";
            this.orderQty.ReadOnly = true;
            this.orderQty.Width = 40;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productPrice.FillWeight = 70F;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 70;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 70;
            // 
            // orderAmount
            // 
            this.orderAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderAmount.FillWeight = 75F;
            this.orderAmount.HeaderText = "Amount";
            this.orderAmount.MinimumWidth = 75;
            this.orderAmount.Name = "orderAmount";
            this.orderAmount.ReadOnly = true;
            this.orderAmount.Width = 75;
            // 
            // posForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.orderDatagrid);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "posForm";
            this.Text = "iRestaurant - POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.posForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posIcon)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox posIcon;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Button dineInBtn;
        private System.Windows.Forms.Button takeAwayBtn;
        private System.Windows.Forms.Button deliveryBtn;
        private System.Windows.Forms.Button kotBtn;
        private System.Windows.Forms.Button billListBtn;
        private System.Windows.Forms.Button holdBtn;
        private System.Windows.Forms.Label waiterLabel;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.PictureBox powerOffBtn;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.FlowLayoutPanel productPanel;
        private System.Windows.Forms.DataGridView orderDatagrid;
        public System.Windows.Forms.TextBox searchTextbox;
        public System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalTxtLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmount;
    }
}