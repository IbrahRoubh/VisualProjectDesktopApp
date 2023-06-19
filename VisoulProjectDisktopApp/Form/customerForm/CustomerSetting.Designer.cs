namespace VisoulProjectDisktopApp
{
    partial class CustomerSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.oldPasswordTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.nameValidateMsg = new System.Windows.Forms.Label();
            this.locationValidateMsg = new System.Windows.Forms.Label();
            this.phoneValidateMsg = new System.Windows.Forms.Label();
            this.oldPasswordValidateMsg = new System.Windows.Forms.Label();
            this.newPasswordValidateMsg = new System.Windows.Forms.Label();
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
            this.prevOrderPanel.Click += new System.EventHandler(this.toPrevOrder);
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
            this.prevOrderLabel.Click += new System.EventHandler(this.toPrevOrder);
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
            // 
            // settingsLabel
            // 
            this.settingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(18, 26);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(61, 16);
            this.settingsLabel.TabIndex = 0;
            this.settingsLabel.Text = "settings";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "old password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "new password";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(645, 370);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 31);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(335, 150);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.ReadOnly = true;
            this.emailTxt.Size = new System.Drawing.Size(125, 20);
            this.emailTxt.TabIndex = 0;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(335, 215);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(125, 20);
            this.locationTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(609, 150);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(125, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // oldPasswordTxt
            // 
            this.oldPasswordTxt.Location = new System.Drawing.Point(335, 281);
            this.oldPasswordTxt.Name = "oldPasswordTxt";
            this.oldPasswordTxt.PasswordChar = '*';
            this.oldPasswordTxt.Size = new System.Drawing.Size(125, 20);
            this.oldPasswordTxt.TabIndex = 4;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(609, 281);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PasswordChar = '*';
            this.newPasswordTxt.Size = new System.Drawing.Size(125, 20);
            this.newPasswordTxt.TabIndex = 5;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(609, 212);
            this.phoneTxt.Mask = "(999) 000-0000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(125, 20);
            this.phoneTxt.TabIndex = 3;
            // 
            // nameValidateMsg
            // 
            this.nameValidateMsg.AutoSize = true;
            this.nameValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.nameValidateMsg.Location = new System.Drawing.Point(624, 180);
            this.nameValidateMsg.Name = "nameValidateMsg";
            this.nameValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.nameValidateMsg.TabIndex = 16;
            this.nameValidateMsg.Text = "Validate MSG";
            this.nameValidateMsg.Visible = false;
            // 
            // locationValidateMsg
            // 
            this.locationValidateMsg.AutoSize = true;
            this.locationValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.locationValidateMsg.Location = new System.Drawing.Point(344, 242);
            this.locationValidateMsg.Name = "locationValidateMsg";
            this.locationValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.locationValidateMsg.TabIndex = 17;
            this.locationValidateMsg.Text = "Validate MSG";
            this.locationValidateMsg.Visible = false;
            // 
            // phoneValidateMsg
            // 
            this.phoneValidateMsg.AutoSize = true;
            this.phoneValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.phoneValidateMsg.Location = new System.Drawing.Point(624, 242);
            this.phoneValidateMsg.Name = "phoneValidateMsg";
            this.phoneValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.phoneValidateMsg.TabIndex = 18;
            this.phoneValidateMsg.Text = "Validate MSG";
            this.phoneValidateMsg.Visible = false;
            // 
            // oldPasswordValidateMsg
            // 
            this.oldPasswordValidateMsg.AutoSize = true;
            this.oldPasswordValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.oldPasswordValidateMsg.Location = new System.Drawing.Point(344, 308);
            this.oldPasswordValidateMsg.Name = "oldPasswordValidateMsg";
            this.oldPasswordValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.oldPasswordValidateMsg.TabIndex = 19;
            this.oldPasswordValidateMsg.Text = "Validate MSG";
            this.oldPasswordValidateMsg.Visible = false;
            // 
            // newPasswordValidateMsg
            // 
            this.newPasswordValidateMsg.AutoSize = true;
            this.newPasswordValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.newPasswordValidateMsg.Location = new System.Drawing.Point(624, 308);
            this.newPasswordValidateMsg.Name = "newPasswordValidateMsg";
            this.newPasswordValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.newPasswordValidateMsg.TabIndex = 20;
            this.newPasswordValidateMsg.Text = "Validate MSG";
            this.newPasswordValidateMsg.Visible = false;
            // 
            // CustomerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPasswordValidateMsg);
            this.Controls.Add(this.oldPasswordValidateMsg);
            this.Controls.Add(this.phoneValidateMsg);
            this.Controls.Add(this.locationValidateMsg);
            this.Controls.Add(this.nameValidateMsg);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.oldPasswordTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.CustomerSetting_Load);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox oldPasswordTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.Label nameValidateMsg;
        private System.Windows.Forms.Label locationValidateMsg;
        private System.Windows.Forms.Label phoneValidateMsg;
        private System.Windows.Forms.Label oldPasswordValidateMsg;
        private System.Windows.Forms.Label newPasswordValidateMsg;
    }
}