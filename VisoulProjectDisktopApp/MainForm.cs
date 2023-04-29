using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisoulProjectDisktopApp
{
    public partial class MainForm : Form
    {
        private CookieManager cookieManager;
        String username;
        public MainForm(CookieManager cookieManager)
        {
            this.cookieManager = cookieManager;
            InitializeComponent();
        }

        private  void MainForm_Load(object sender, EventArgs e)
        {
            CookieCollection cookies = cookieManager.GetCookie().GetCookies();
            if (cookies["username"] != null)
            {
                username = cookies["username"].Value;
            }
            setInfo();
        }

        private void setInfo()
        {
            usernameLabel.Text = username;
        }


        private void storeBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Label l = new Label();
            l.Text = "store name";
            mainPanel.Controls.Add(l); 
        }

        private void requestBox_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Label l = new Label();
            l.Text = "hi there";
            mainPanel.Controls.Add(l);
        }

        private void storgBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
        }

        private void settingBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Label l = new Label();
            l.Text = "seeting page>:";
            mainPanel.Controls.Add(l);
        }

    }
}
