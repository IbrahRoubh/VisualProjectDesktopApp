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
            this.requestBox = new System.Windows.Forms.GroupBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.storgBox = new System.Windows.Forms.GroupBox();
            this.storgLabel = new System.Windows.Forms.Label();
            this.settingBox = new System.Windows.Forms.GroupBox();
            this.settingLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.storeBox.SuspendLayout();
            this.userInfoBox.SuspendLayout();
            this.requestBox.SuspendLayout();
            this.storgBox.SuspendLayout();
            this.settingBox.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.requestBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.storgBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.settingBox, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // storeBox
            // 
            this.storeBox.Controls.Add(this.storeLabel);
            this.storeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeBox.Location = new System.Drawing.Point(3, 94);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(256, 50);
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
            this.storeLabel.Size = new System.Drawing.Size(59, 25);
            this.storeLabel.TabIndex = 0;
            this.storeLabel.Text = "Store";
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
            this.userInfoBox.Size = new System.Drawing.Size(256, 85);
            this.userInfoBox.TabIndex = 2;
            this.userInfoBox.TabStop = false;
            this.userInfoBox.Text = "User Info";
            this.userInfoBox.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // requestBox
            // 
            this.requestBox.Controls.Add(this.requestLabel);
            this.requestBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestBox.Location = new System.Drawing.Point(3, 150);
            this.requestBox.Name = "requestBox";
            this.requestBox.Size = new System.Drawing.Size(256, 50);
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
            this.storgBox.Location = new System.Drawing.Point(3, 206);
            this.storgBox.Name = "storgBox";
            this.storgBox.Size = new System.Drawing.Size(256, 48);
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
            this.storgLabel.Size = new System.Drawing.Size(59, 25);
            this.storgLabel.TabIndex = 0;
            this.storgLabel.Text = "Storg";
            this.storgLabel.Click += new System.EventHandler(this.storgBox_onClick);
            // 
            // settingBox
            // 
            this.settingBox.Controls.Add(this.settingLabel);
            this.settingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingBox.Location = new System.Drawing.Point(3, 260);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(256, 49);
            this.settingBox.TabIndex = 5;
            this.settingBox.TabStop = false;
            this.settingBox.Click += new System.EventHandler(this.settingBox_onClick);
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(3, 16);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(83, 25);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "Settings";
            this.settingLabel.Click += new System.EventHandler(this.settingBox_onClick);
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
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(104, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "label1";
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
            this.settingBox.ResumeLayout(false);
            this.settingBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox settingBox;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}