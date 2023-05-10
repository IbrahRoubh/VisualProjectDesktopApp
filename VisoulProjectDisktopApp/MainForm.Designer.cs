namespace VisoulProjectDisktopApp
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.storeBox = new System.Windows.Forms.GroupBox();
            this.storeLabel = new System.Windows.Forms.Label();
            this.userInfoBox = new System.Windows.Forms.GroupBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.requestBox = new System.Windows.Forms.GroupBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.storgBox = new System.Windows.Forms.GroupBox();
            this.storgLabel = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.GroupBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.seetingBox = new System.Windows.Forms.GroupBox();
            this.settingBox = new System.Windows.Forms.Label();
            this.trackOrdersBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.storeBox.SuspendLayout();
            this.userInfoBox.SuspendLayout();
            this.requestBox.SuspendLayout();
            this.storgBox.SuspendLayout();
            this.productBox.SuspendLayout();
            this.seetingBox.SuspendLayout();
            this.trackOrdersBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainPanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.storeBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userInfoBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.requestBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.storgBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.productBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.seetingBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.trackOrdersBox, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // storeBox
            // 
            this.storeBox.Controls.Add(this.storeLabel);
            this.storeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeBox.Location = new System.Drawing.Point(3, 88);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(256, 53);
            this.storeBox.TabIndex = 1;
            this.storeBox.TabStop = false;
            this.storeBox.Click += new System.EventHandler(this.storeBox_onClick);
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(3, 16);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(69, 25);
            this.storeLabel.TabIndex = 0;
            this.storeLabel.Text = "Stores";
            this.storeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storeLabel.Click += new System.EventHandler(this.storeBox_onClick);
            // 
            // userInfoBox
            // 
            this.userInfoBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userInfoBox.Controls.Add(this.usernameLabel);
            this.userInfoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoBox.Location = new System.Drawing.Point(3, 3);
            this.userInfoBox.Name = "userInfoBox";
            this.userInfoBox.Size = new System.Drawing.Size(256, 79);
            this.userInfoBox.TabIndex = 2;
            this.userInfoBox.TabStop = false;
            this.userInfoBox.Text = "User Info";
            this.userInfoBox.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(104, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // requestBox
            // 
            this.requestBox.Controls.Add(this.requestLabel);
            this.requestBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestBox.Location = new System.Drawing.Point(3, 269);
            this.requestBox.Name = "requestBox";
            this.requestBox.Size = new System.Drawing.Size(256, 54);
            this.requestBox.TabIndex = 3;
            this.requestBox.TabStop = false;
            this.requestBox.Click += new System.EventHandler(this.requestBox_Click);
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.Location = new System.Drawing.Point(3, 16);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(216, 25);
            this.requestLabel.TabIndex = 0;
            this.requestLabel.Text = "Manufacturing requests";
            this.requestLabel.Click += new System.EventHandler(this.requestBox_Click);
            // 
            // storgBox
            // 
            this.storgBox.Controls.Add(this.storgLabel);
            this.storgBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storgBox.Location = new System.Drawing.Point(3, 147);
            this.storgBox.Name = "storgBox";
            this.storgBox.Size = new System.Drawing.Size(256, 52);
            this.storgBox.TabIndex = 4;
            this.storgBox.TabStop = false;
            this.storgBox.Click += new System.EventHandler(this.storgBox_onClick);
            // 
            // storgLabel
            // 
            this.storgLabel.AutoSize = true;
            this.storgLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.storgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storgLabel.Location = new System.Drawing.Point(3, 16);
            this.storgLabel.Name = "storgLabel";
            this.storgLabel.Size = new System.Drawing.Size(91, 25);
            this.storgLabel.TabIndex = 0;
            this.storgLabel.Text = "My Storg";
            this.storgLabel.Click += new System.EventHandler(this.storgBox_onClick);
            // 
            // productBox
            // 
            this.productBox.Controls.Add(this.productLabel);
            this.productBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productBox.Location = new System.Drawing.Point(3, 205);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(256, 58);
            this.productBox.TabIndex = 5;
            this.productBox.TabStop = false;
            this.productBox.Click += new System.EventHandler(this.productBox_onClick);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(3, 16);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(120, 25);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Add Product";
            this.productLabel.Click += new System.EventHandler(this.productBox_onClick);
            // 
            // seetingBox
            // 
            this.seetingBox.Controls.Add(this.settingBox);
            this.seetingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seetingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seetingBox.Location = new System.Drawing.Point(3, 389);
            this.seetingBox.Name = "seetingBox";
            this.seetingBox.Size = new System.Drawing.Size(256, 50);
            this.seetingBox.TabIndex = 6;
            this.seetingBox.TabStop = false;
            this.seetingBox.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // settingBox
            // 
            this.settingBox.AutoSize = true;
            this.settingBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingBox.Location = new System.Drawing.Point(3, 16);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(73, 25);
            this.settingBox.TabIndex = 0;
            this.settingBox.Text = "Setting";
            this.settingBox.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // trackOrdersBox
            // 
            this.trackOrdersBox.Controls.Add(this.label1);
            this.trackOrdersBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackOrdersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackOrdersBox.Location = new System.Drawing.Point(3, 329);
            this.trackOrdersBox.Name = "trackOrdersBox";
            this.trackOrdersBox.Size = new System.Drawing.Size(256, 54);
            this.trackOrdersBox.TabIndex = 7;
            this.trackOrdersBox.TabStop = false;
            this.trackOrdersBox.Click += new System.EventHandler(this.tracikOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track Orders";
            this.label1.Click += new System.EventHandler(this.tracikOrder_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(534, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.storeBox.ResumeLayout(false);
            this.storeBox.PerformLayout();
            this.userInfoBox.ResumeLayout(false);
            this.userInfoBox.PerformLayout();
            this.requestBox.ResumeLayout(false);
            this.requestBox.PerformLayout();
            this.storgBox.ResumeLayout(false);
            this.storgBox.PerformLayout();
            this.productBox.ResumeLayout(false);
            this.productBox.PerformLayout();
            this.seetingBox.ResumeLayout(false);
            this.seetingBox.PerformLayout();
            this.trackOrdersBox.ResumeLayout(false);
            this.trackOrdersBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox storeBox;
        private System.Windows.Forms.GroupBox userInfoBox;
        private System.Windows.Forms.GroupBox requestBox;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.GroupBox storgBox;
        private System.Windows.Forms.Label storgLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.GroupBox productBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.GroupBox seetingBox;
        private System.Windows.Forms.Label settingBox;
        private System.Windows.Forms.GroupBox trackOrdersBox;
        private System.Windows.Forms.Label label1;
    }
}