namespace VisoulProjectDisktopApp
{
    partial class CustomerPreviosOrder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderLabel = new System.Windows.Forms.Label();
            this.prevOrderPanel = new System.Windows.Forms.Panel();
            this.prevOrderLabel = new System.Windows.Forms.Label();
            this.warehousePanel = new System.Windows.Forms.Panel();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.previousOrderDataGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareHouseLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.prevOrderPanel.SuspendLayout();
            this.warehousePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousOrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.70443F));
            this.tableLayoutPanel1.Controls.Add(this.customerNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.prevOrderPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.warehousePanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.settingsPanel, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(50, 29);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(45, 16);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "name";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.homePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 78);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(140, 69);
            this.homePanel.TabIndex = 1;
            this.homePanel.Click += new System.EventHandler(this.toHome);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(39, 25);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(45, 16);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.toHome);
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.orderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPanel.Location = new System.Drawing.Point(3, 153);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(140, 69);
            this.orderPanel.TabIndex = 2;
            this.orderPanel.Click += new System.EventHandler(this.toOrder);
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderLabel.AutoSize = true;
            this.orderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(22, 23);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(77, 16);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "my oreder";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderLabel.Click += new System.EventHandler(this.toOrder);
            // 
            // prevOrderPanel
            // 
            this.prevOrderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prevOrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prevOrderPanel.Controls.Add(this.prevOrderLabel);
            this.prevOrderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevOrderPanel.Location = new System.Drawing.Point(3, 228);
            this.prevOrderPanel.Name = "prevOrderPanel";
            this.prevOrderPanel.Size = new System.Drawing.Size(140, 69);
            this.prevOrderPanel.TabIndex = 3;
            // 
            // prevOrderLabel
            // 
            this.prevOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevOrderLabel.AutoSize = true;
            this.prevOrderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevOrderLabel.Location = new System.Drawing.Point(13, 27);
            this.prevOrderLabel.Name = "prevOrderLabel";
            this.prevOrderLabel.Size = new System.Drawing.Size(116, 16);
            this.prevOrderLabel.TabIndex = 0;
            this.prevOrderLabel.Text = "previous orders";
            this.prevOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warehousePanel
            // 
            this.warehousePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.warehousePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.warehousePanel.Controls.Add(this.warehouseLabel);
            this.warehousePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehousePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehousePanel.Location = new System.Drawing.Point(3, 303);
            this.warehousePanel.Name = "warehousePanel";
            this.warehousePanel.Size = new System.Drawing.Size(140, 69);
            this.warehousePanel.TabIndex = 4;
            this.warehousePanel.Click += new System.EventHandler(this.toWarehouse);
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabel.Location = new System.Drawing.Point(18, 24);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(82, 16);
            this.warehouseLabel.TabIndex = 0;
            this.warehouseLabel.Text = "warehouse";
            this.warehouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warehouseLabel.Click += new System.EventHandler(this.toWarehouse);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(3, 378);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(140, 69);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.Click += new System.EventHandler(this.toSetting);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(18, 37);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(61, 16);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsLabel.Click += new System.EventHandler(this.toSetting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousOrderDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(146, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous order";
            // 
            // previousOrderDataGrid
            // 
            this.previousOrderDataGrid.AllowUserToAddRows = false;
            this.previousOrderDataGrid.AllowUserToDeleteRows = false;
            this.previousOrderDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.previousOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productDescription,
            this.productCode,
            this.productPrice,
            this.warehouseName,
            this.wareHouseLocation});
            this.previousOrderDataGrid.Location = new System.Drawing.Point(6, 132);
            this.previousOrderDataGrid.Name = "previousOrderDataGrid";
            this.previousOrderDataGrid.ReadOnly = true;
            this.previousOrderDataGrid.Size = new System.Drawing.Size(636, 254);
            this.previousOrderDataGrid.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.HeaderText = "product";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // warehouseName
            // 
            this.warehouseName.HeaderText = "warehouse";
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.ReadOnly = true;
            // 
            // wareHouseLocation
            // 
            this.wareHouseLocation.HeaderText = "location";
            this.wareHouseLocation.Name = "wareHouseLocation";
            this.wareHouseLocation.ReadOnly = true;
            // 
            // CustomerPreviosOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerPreviosOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previous order";
            this.Load += new System.EventHandler(this.CustomerPreviosOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.prevOrderPanel.ResumeLayout(false);
            this.prevOrderPanel.PerformLayout();
            this.warehousePanel.ResumeLayout(false);
            this.warehousePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousOrderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Panel prevOrderPanel;
        private System.Windows.Forms.Label prevOrderLabel;
        private System.Windows.Forms.Panel warehousePanel;
        private System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView previousOrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareHouseLocation;
    }
}