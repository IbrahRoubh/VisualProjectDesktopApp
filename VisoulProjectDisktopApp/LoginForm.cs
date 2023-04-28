using System;
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (isValidUser()) {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
                errorMsg.Visible = true;
        }

        private Boolean isValidUser()
        {
            return true;
        }

    }
}
