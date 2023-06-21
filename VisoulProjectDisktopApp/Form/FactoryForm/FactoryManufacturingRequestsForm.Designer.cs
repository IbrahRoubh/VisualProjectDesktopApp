namespace VisoulProjectDisktopApp
{
    partial class FactoryManufacturingRequestsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.manufacturingRequestPanel = new System.Windows.Forms.Panel();
            this.manufacturingRequestsLabel = new System.Windows.Forms.Label();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingLabel = new System.Windows.Forms.Label();
            this.manfacturRequesDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.supplieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseLoaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.addProductPanel.SuspendLayout();
            this.manufacturingRequestPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manfacturRequesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55445F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addProductPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.manufacturingRequestPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.settingPanel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 93);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(188, 84);
            this.homePanel.TabIndex = 1;
            this.homePanel.Click += new System.EventHandler(this.toHome);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(68, 35);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(49, 20);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.toHome);
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductPanel.Controls.Add(this.addProductLabel);
            this.addProductPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductPanel.Location = new System.Drawing.Point(3, 183);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(188, 84);
            this.addProductPanel.TabIndex = 2;
            this.addProductPanel.Click += new System.EventHandler(this.toAddProduct);
            // 
            // addProductLabel
            // 
            this.addProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(46, 39);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(94, 20);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "add product";
            this.addProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProductLabel.Click += new System.EventHandler(this.toAddProduct);
            // 
            // manufacturingRequestPanel
            // 
            this.manufacturingRequestPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manufacturingRequestPanel.Controls.Add(this.manufacturingRequestsLabel);
            this.manufacturingRequestPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingRequestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manufacturingRequestPanel.Location = new System.Drawing.Point(3, 273);
            this.manufacturingRequestPanel.Name = "manufacturingRequestPanel";
            this.manufacturingRequestPanel.Size = new System.Drawing.Size(188, 84);
            this.manufacturingRequestPanel.TabIndex = 3;
            // 
            // manufacturingRequestsLabel
            // 
            this.manufacturingRequestsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturingRequestsLabel.AutoSize = true;
            this.manufacturingRequestsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingRequestsLabel.Location = new System.Drawing.Point(7, 32);
            this.manufacturingRequestsLabel.Name = "manufacturingRequestsLabel";
            this.manufacturingRequestsLabel.Size = new System.Drawing.Size(177, 20);
            this.manufacturingRequestsLabel.TabIndex = 0;
            this.manufacturingRequestsLabel.Text = "manufacturing requests";
            this.manufacturingRequestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingPanel
            // 
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingPanel.Controls.Add(this.settingLabel);
            this.settingPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(3, 363);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(188, 84);
            this.settingPanel.TabIndex = 4;
            this.settingPanel.Click += new System.EventHandler(this.toSetting);
            // 
            // settingLabel
            // 
            this.settingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingLabel.AutoSize = true;
            this.settingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(60, 37);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(57, 20);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "setting";
            this.settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingLabel.Click += new System.EventHandler(this.toSetting);
            // 
            // manfacturRequesDataGrid
            // 
            this.manfacturRequesDataGrid.AllowUserToAddRows = false;
            this.manfacturRequesDataGrid.AllowUserToDeleteRows = false;
            this.manfacturRequesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.manfacturRequesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manfacturRequesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manfacturRequesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieId,
            this.warehouseName,
            this.warehouseLoaction,
            this.productName,
            this.productCode,
            this.productAmount,
            this.submitBtn});
            this.manfacturRequesDataGrid.Location = new System.Drawing.Point(3, 152);
            this.manfacturRequesDataGrid.Name = "manfacturRequesDataGrid";
            this.manfacturRequesDataGrid.ReadOnly = true;
            this.manfacturRequesDataGrid.Size = new System.Drawing.Size(655, 244);
            this.manfacturRequesDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manufacturing Request";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.manfacturRequesDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 450);
            this.panel1.TabIndex = 3;
            // 
            // supplieId
            // 
            this.supplieId.HeaderText = "request ID";
            this.supplieId.Name = "supplieId";
            this.supplieId.ReadOnly = true;
            this.supplieId.Visible = false;
            // 
            // warehouseName
            // 
            this.warehouseName.HeaderText = "warehouse";
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.ReadOnly = true;
            // 
            // warehouseLoaction
            // 
            this.warehouseLoaction.HeaderText = "warehouse location";
            this.warehouseLoaction.Name = "warehouseLoaction";
            this.warehouseLoaction.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "product";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "product code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productAmount
            // 
            this.productAmount.HeaderText = "product amount";
            this.productAmount.Name = "productAmount";
            this.productAmount.ReadOnly = true;
            // 
            // submitBtn
            // 
            this.submitBtn.HeaderText = "order sent";
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.ReadOnly = true;
            // 
            // FactoryManufacturingRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FactoryManufacturingRequestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturing Requests";
            this.Load += new System.EventHandler(this.FactoryManufacturingRequestsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            this.manufacturingRequestPanel.ResumeLayout(false);
            this.manufacturingRequestPanel.PerformLayout();
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manfacturRequesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.Panel manufacturingRequestPanel;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label manufacturingRequestsLabel;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.DataGridView manfacturRequesDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseLoaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmount;
        private System.Windows.Forms.DataGridViewButtonColumn submitBtn;
    }
}