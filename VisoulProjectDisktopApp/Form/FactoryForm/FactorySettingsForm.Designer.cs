namespace VisoulProjectDisktopApp
{
    partial class FactorySettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.oldPasswordTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.nameValidateLabel = new System.Windows.Forms.Label();
            this.locationValidateLabel = new System.Windows.Forms.Label();
            this.phoneValidateLabel = new System.Windows.Forms.Label();
            this.oldPasswordValidateLabel = new System.Windows.Forms.Label();
            this.newPasswordValidateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.addProductPanel.SuspendLayout();
            this.manufacturingRequestPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(75, 35);
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
            this.homePanel.Size = new System.Drawing.Size(194, 84);
            this.homePanel.TabIndex = 1;
            this.homePanel.Click += new System.EventHandler(this.toHome);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(71, 35);
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
            this.addProductPanel.Size = new System.Drawing.Size(194, 84);
            this.addProductPanel.TabIndex = 2;
            this.addProductPanel.Click += new System.EventHandler(this.toAddProduct);
            // 
            // addProductLabel
            // 
            this.addProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(49, 39);
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
            this.manufacturingRequestPanel.Size = new System.Drawing.Size(194, 84);
            this.manufacturingRequestPanel.TabIndex = 3;
            this.manufacturingRequestPanel.Click += new System.EventHandler(this.toManufacturingRequests);
            // 
            // manufacturingRequestsLabel
            // 
            this.manufacturingRequestsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturingRequestsLabel.AutoSize = true;
            this.manufacturingRequestsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingRequestsLabel.Location = new System.Drawing.Point(10, 32);
            this.manufacturingRequestsLabel.Name = "manufacturingRequestsLabel";
            this.manufacturingRequestsLabel.Size = new System.Drawing.Size(177, 20);
            this.manufacturingRequestsLabel.TabIndex = 0;
            this.manufacturingRequestsLabel.Text = "manufacturing requests";
            this.manufacturingRequestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manufacturingRequestsLabel.Click += new System.EventHandler(this.toManufacturingRequests);
            // 
            // settingPanel
            // 
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingPanel.Controls.Add(this.settingLabel);
            this.settingPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(3, 363);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(194, 84);
            this.settingPanel.TabIndex = 4;
            // 
            // settingLabel
            // 
            this.settingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingLabel.AutoSize = true;
            this.settingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(63, 37);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(57, 20);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "setting";
            this.settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(689, 334);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "old password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(553, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "new password";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(392, 132);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.ReadOnly = true;
            this.emailTxt.Size = new System.Drawing.Size(135, 20);
            this.emailTxt.TabIndex = 0;
            // 
            // oldPasswordTxt
            // 
            this.oldPasswordTxt.Location = new System.Drawing.Point(392, 253);
            this.oldPasswordTxt.Name = "oldPasswordTxt";
            this.oldPasswordTxt.PasswordChar = '*';
            this.oldPasswordTxt.Size = new System.Drawing.Size(135, 20);
            this.oldPasswordTxt.TabIndex = 4;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(392, 189);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(135, 20);
            this.locationTxt.TabIndex = 2;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(653, 253);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PasswordChar = '*';
            this.newPasswordTxt.Size = new System.Drawing.Size(135, 20);
            this.newPasswordTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(653, 132);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(135, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(653, 189);
            this.phoneTxt.Mask = "(999) 000-0000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(135, 20);
            this.phoneTxt.TabIndex = 3;
            // 
            // nameValidateLabel
            // 
            this.nameValidateLabel.AutoSize = true;
            this.nameValidateLabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidateLabel.Location = new System.Drawing.Point(671, 155);
            this.nameValidateLabel.Name = "nameValidateLabel";
            this.nameValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.nameValidateLabel.TabIndex = 9;
            this.nameValidateLabel.Text = "Validate MSG";
            this.nameValidateLabel.Visible = false;
            // 
            // locationValidateLabel
            // 
            this.locationValidateLabel.AutoSize = true;
            this.locationValidateLabel.ForeColor = System.Drawing.Color.Red;
            this.locationValidateLabel.Location = new System.Drawing.Point(407, 212);
            this.locationValidateLabel.Name = "locationValidateLabel";
            this.locationValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.locationValidateLabel.TabIndex = 10;
            this.locationValidateLabel.Text = "Validate MSG";
            this.locationValidateLabel.Visible = false;
            // 
            // phoneValidateLabel
            // 
            this.phoneValidateLabel.AutoSize = true;
            this.phoneValidateLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneValidateLabel.Location = new System.Drawing.Point(674, 216);
            this.phoneValidateLabel.Name = "phoneValidateLabel";
            this.phoneValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.phoneValidateLabel.TabIndex = 11;
            this.phoneValidateLabel.Text = "Validate MSG";
            this.phoneValidateLabel.Visible = false;
            // 
            // oldPasswordValidateLabel
            // 
            this.oldPasswordValidateLabel.AutoSize = true;
            this.oldPasswordValidateLabel.ForeColor = System.Drawing.Color.Red;
            this.oldPasswordValidateLabel.Location = new System.Drawing.Point(407, 280);
            this.oldPasswordValidateLabel.Name = "oldPasswordValidateLabel";
            this.oldPasswordValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.oldPasswordValidateLabel.TabIndex = 12;
            this.oldPasswordValidateLabel.Text = "Validate MSG";
            this.oldPasswordValidateLabel.Visible = false;
            // 
            // newPasswordValidateLabel
            // 
            this.newPasswordValidateLabel.AutoSize = true;
            this.newPasswordValidateLabel.ForeColor = System.Drawing.Color.Red;
            this.newPasswordValidateLabel.Location = new System.Drawing.Point(650, 280);
            this.newPasswordValidateLabel.Name = "newPasswordValidateLabel";
            this.newPasswordValidateLabel.Size = new System.Drawing.Size(72, 13);
            this.newPasswordValidateLabel.TabIndex = 13;
            this.newPasswordValidateLabel.Text = "Validate MSG";
            this.newPasswordValidateLabel.Visible = false;
            // 
            // FactorySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newPasswordValidateLabel);
            this.Controls.Add(this.oldPasswordValidateLabel);
            this.Controls.Add(this.phoneValidateLabel);
            this.Controls.Add(this.locationValidateLabel);
            this.Controls.Add(this.nameValidateLabel);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.oldPasswordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FactorySettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FactorySettingsForm_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox oldPasswordTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.Label nameValidateLabel;
        private System.Windows.Forms.Label locationValidateLabel;
        private System.Windows.Forms.Label phoneValidateLabel;
        private System.Windows.Forms.Label oldPasswordValidateLabel;
        private System.Windows.Forms.Label newPasswordValidateLabel;
    }
}