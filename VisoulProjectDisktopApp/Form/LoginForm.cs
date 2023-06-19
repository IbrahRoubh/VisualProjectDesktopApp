using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;
using VisoulProjectDisktopApp.Repository;

namespace VisoulProjectDisktopApp
{
    public partial class LoginForm : Form
    {
        CustomerRepo customerRepo = new CustomerRepo();
        FactoryRepo factoryRepo= new FactoryRepo();
        CookieManager cookieManager = new CookieManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = 0;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(emailTxt.Text != null && emailTxt.Text.Trim().Length  > 0 && passwordTxt.Text != null && passwordTxt.Text.Trim().Length > 0)
            {
                if ((String)roleComboBox.SelectedItem=="Customer") 
                {
                    CustomerModel customer = customerRepo.isUser(emailTxt.Text, passwordTxt.Text);
                    if(customer!=null){
                        CustomerHome mainCustomerForm = new CustomerHome(customer.Id);
                        this.Hide();
                        mainCustomerForm.ShowDialog();
                        this.Dispose();
                    }

                }else if ((String)roleComboBox.SelectedItem == "Factory")
                {
                    FactoryModel factory = factoryRepo.getUser(emailTxt.Text, passwordTxt.Text);
                    if (factory!=null)
                    {
                        FactoryHomeForm homeForm = new FactoryHomeForm(factory.id);
                        this.Hide();
                        homeForm.ShowDialog();
                        this.Dispose();
                    }
                }
                else
                {

                }
            }
                errorMsg.Visible = true;
        }

        private void signupLink_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            this.Hide();
            signupForm.ShowDialog();
            this.Dispose();
        }
    }
}
