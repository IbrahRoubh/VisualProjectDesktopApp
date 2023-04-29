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
        FactoryRepo Frepo= new FactoryRepo();   
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
           if (Frepo.isUser(nameTxt.Text,passwordTxt.Text)) {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Dispose();
            }
            else
                errorMsg.Visible = true;
        }

    }
}
