﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisoulProjectDisktopApp
{
    public partial class LoginForm : Form
    {
        FactoryRepo Frepo= new FactoryRepo();
        CookieManager cookieManager = new CookieManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
           if (Frepo.isUser(nameTxt.Text,passwordTxt.Text,cookieManager)) {
                MainForm mainForm = new MainForm(cookieManager);
                this.Hide();
                mainForm.ShowDialog();
                this.Dispose();
            }
            else
                errorMsg.Visible = true;
        }
    }
}
