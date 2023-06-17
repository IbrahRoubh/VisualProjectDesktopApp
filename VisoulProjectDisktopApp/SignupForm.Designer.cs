namespace VisoulProjectDisktopApp
{
    partial class SignupForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.repasswordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.passwrodTxt = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.repasswordValidateMsg = new System.Windows.Forms.Label();
            this.nameValidateMsg = new System.Windows.Forms.Label();
            this.emailValidateMsg = new System.Windows.Forms.Label();
            this.phoneValidateMsg = new System.Windows.Forms.Label();
            this.locationValidateMsg = new System.Windows.Forms.Label();
            this.passwordValidateMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(287, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Signup";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.ForeColor = System.Drawing.Color.Blue;
            this.loginLink.Location = new System.Drawing.Point(436, 330);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(191, 20);
            this.loginLink.TabIndex = 7;
            this.loginLink.Text = "Already have account?";
            this.loginLink.Click += new System.EventHandler(this.loginLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "repassword";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(468, 80);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(160, 20);
            this.emailTxt.TabIndex = 1;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(468, 142);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(160, 20);
            this.locationTxt.TabIndex = 3;
            // 
            // repasswordTxt
            // 
            this.repasswordTxt.Location = new System.Drawing.Point(468, 202);
            this.repasswordTxt.Name = "repasswordTxt";
            this.repasswordTxt.PasswordChar = '*';
            this.repasswordTxt.Size = new System.Drawing.Size(160, 20);
            this.repasswordTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(153, 80);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(160, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(153, 142);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(160, 20);
            this.phoneTxt.TabIndex = 2;
            // 
            // passwrodTxt
            // 
            this.passwrodTxt.Location = new System.Drawing.Point(153, 202);
            this.passwrodTxt.Name = "passwrodTxt";
            this.passwrodTxt.PasswordChar = '*';
            this.passwrodTxt.Size = new System.Drawing.Size(160, 20);
            this.passwrodTxt.TabIndex = 4;
            // 
            // signupBtn
            // 
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Location = new System.Drawing.Point(523, 265);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(104, 36);
            this.signupBtn.TabIndex = 6;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // repasswordValidateMsg
            // 
            this.repasswordValidateMsg.AutoSize = true;
            this.repasswordValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.repasswordValidateMsg.Location = new System.Drawing.Point(502, 225);
            this.repasswordValidateMsg.Name = "repasswordValidateMsg";
            this.repasswordValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.repasswordValidateMsg.TabIndex = 14;
            this.repasswordValidateMsg.Text = "MSG label";
            this.repasswordValidateMsg.Visible = false;
            // 
            // nameValidateMsg
            // 
            this.nameValidateMsg.AutoSize = true;
            this.nameValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.nameValidateMsg.Location = new System.Drawing.Point(190, 103);
            this.nameValidateMsg.Name = "nameValidateMsg";
            this.nameValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.nameValidateMsg.TabIndex = 15;
            this.nameValidateMsg.Text = "MSG label";
            this.nameValidateMsg.Visible = false;
            // 
            // emailValidateMsg
            // 
            this.emailValidateMsg.AutoSize = true;
            this.emailValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.emailValidateMsg.Location = new System.Drawing.Point(502, 103);
            this.emailValidateMsg.Name = "emailValidateMsg";
            this.emailValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.emailValidateMsg.TabIndex = 16;
            this.emailValidateMsg.Text = "MSG label";
            this.emailValidateMsg.Visible = false;
            // 
            // phoneValidateMsg
            // 
            this.phoneValidateMsg.AutoSize = true;
            this.phoneValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.phoneValidateMsg.Location = new System.Drawing.Point(190, 165);
            this.phoneValidateMsg.Name = "phoneValidateMsg";
            this.phoneValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.phoneValidateMsg.TabIndex = 17;
            this.phoneValidateMsg.Text = "MSG label";
            this.phoneValidateMsg.Visible = false;
            // 
            // locationValidateMsg
            // 
            this.locationValidateMsg.AutoSize = true;
            this.locationValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.locationValidateMsg.Location = new System.Drawing.Point(502, 165);
            this.locationValidateMsg.Name = "locationValidateMsg";
            this.locationValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.locationValidateMsg.TabIndex = 18;
            this.locationValidateMsg.Text = "MSG label";
            this.locationValidateMsg.Visible = false;
            // 
            // passwordValidateMsg
            // 
            this.passwordValidateMsg.AutoSize = true;
            this.passwordValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.passwordValidateMsg.Location = new System.Drawing.Point(150, 225);
            this.passwordValidateMsg.Name = "passwordValidateMsg";
            this.passwordValidateMsg.Size = new System.Drawing.Size(56, 13);
            this.passwordValidateMsg.TabIndex = 19;
            this.passwordValidateMsg.Text = "MSG label";
            this.passwordValidateMsg.Visible = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 395);
            this.Controls.Add(this.passwordValidateMsg);
            this.Controls.Add(this.locationValidateMsg);
            this.Controls.Add(this.phoneValidateMsg);
            this.Controls.Add(this.emailValidateMsg);
            this.Controls.Add(this.nameValidateMsg);
            this.Controls.Add(this.repasswordValidateMsg);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.passwrodTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.repasswordTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignupForm";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label loginLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.TextBox repasswordTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox passwrodTxt;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label repasswordValidateMsg;
        private System.Windows.Forms.Label nameValidateMsg;
        private System.Windows.Forms.Label emailValidateMsg;
        private System.Windows.Forms.Label phoneValidateMsg;
        private System.Windows.Forms.Label locationValidateMsg;
        private System.Windows.Forms.Label passwordValidateMsg;
    }
}