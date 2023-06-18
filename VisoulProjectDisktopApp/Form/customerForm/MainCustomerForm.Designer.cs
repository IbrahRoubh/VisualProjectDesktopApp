namespace VisoulProjectDisktopApp
{
    partial class MainCustomerForm
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
            this.tableLayoutPanel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.prevOrderPanel.SuspendLayout();
            this.warehousePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.70443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.29557F));
            this.tableLayoutPanel1.Controls.Add(this.customerNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.prevOrderPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.warehousePanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.settingsPanel, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(49, 29);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(58, 16);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "ibrahim";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.Silver;
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 78);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(151, 69);
            this.homePanel.TabIndex = 1;
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(46, 27);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(45, 16);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.Silver;
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPanel.Location = new System.Drawing.Point(3, 153);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(151, 69);
            this.orderPanel.TabIndex = 2;
            this.orderPanel.Click += new System.EventHandler(this.toOrder);
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderLabel.AutoSize = true;
            this.orderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(29, 25);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(78, 16);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "my oreder";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderLabel.Click += new System.EventHandler(this.toOrder);
            // 
            // prevOrderPanel
            // 
            this.prevOrderPanel.BackColor = System.Drawing.Color.Silver;
            this.prevOrderPanel.Controls.Add(this.prevOrderLabel);
            this.prevOrderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevOrderPanel.Location = new System.Drawing.Point(3, 228);
            this.prevOrderPanel.Name = "prevOrderPanel";
            this.prevOrderPanel.Size = new System.Drawing.Size(151, 69);
            this.prevOrderPanel.TabIndex = 3;
            this.prevOrderPanel.Click += new System.EventHandler(this.toPrevOrder);
            // 
            // prevOrderLabel
            // 
            this.prevOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevOrderLabel.AutoSize = true;
            this.prevOrderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevOrderLabel.Location = new System.Drawing.Point(20, 29);
            this.prevOrderLabel.Name = "prevOrderLabel";
            this.prevOrderLabel.Size = new System.Drawing.Size(117, 16);
            this.prevOrderLabel.TabIndex = 0;
            this.prevOrderLabel.Text = "previous orders";
            this.prevOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prevOrderLabel.Click += new System.EventHandler(this.toPrevOrder);
            // 
            // warehousePanel
            // 
            this.warehousePanel.BackColor = System.Drawing.Color.Silver;
            this.warehousePanel.Controls.Add(this.warehouseLabel);
            this.warehousePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehousePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warehousePanel.Location = new System.Drawing.Point(3, 303);
            this.warehousePanel.Name = "warehousePanel";
            this.warehousePanel.Size = new System.Drawing.Size(151, 69);
            this.warehousePanel.TabIndex = 4;
            this.warehousePanel.Click += new System.EventHandler(this.toWarehouse);
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabel.Location = new System.Drawing.Point(25, 26);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(82, 16);
            this.warehouseLabel.TabIndex = 0;
            this.warehouseLabel.Text = "warehouse";
            this.warehouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warehouseLabel.Click += new System.EventHandler(this.toWarehouse);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Silver;
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(3, 378);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(151, 69);
            this.settingsPanel.TabIndex = 5;
            this.settingsPanel.Click += new System.EventHandler(this.toSetting);
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(25, 39);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(61, 16);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsLabel.Click += new System.EventHandler(this.toSetting);
            // 
            // MainCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home ";
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
    }
}