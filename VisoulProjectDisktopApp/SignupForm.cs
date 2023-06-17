using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;
using VisoulProjectDisktopApp.Repository;

namespace VisoulProjectDisktopApp
{
    public partial class SignupForm : Form
    {
        CustomerRepo customerRepo = new CustomerRepo();

        public SignupForm()
        {
            InitializeComponent();
        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Dispose();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Boolean isValidCustomer = isValidCustomerInfo();

            if (isValidCustomer)
            {
                CustomerModel customer = new CustomerModel();
                customer.Name = nameTxt.Text;
                customer.Email = emailTxt.Text;
                customer.Location = locationTxt.Text;
                customer.Phone = phoneTxt.Text;
                customer.Password = passwrodTxt.Text;

                if (customerRepo.addCustomer(customer))
                {
                    LoginForm loginform = new LoginForm();
                    this.Hide();
                    loginform.ShowDialog();
                    this.Dispose();
                }
            }
        }

        private Boolean isValidCustomerInfo()
        {
            Boolean isValidCustomer = true;
            
            //name validate
            if (string.IsNullOrEmpty(nameTxt.Text) || nameTxt.Text.Trim().Length == 0)
            {
                nameValidateMsg.Visible = true;
                nameValidateMsg.Text = "can not be empty!!";
                isValidCustomer = false;
            }
            else
            {
                nameValidateMsg.Visible = false;
            }

            //email validate
            if(string.IsNullOrEmpty(emailTxt.Text) || emailTxt.Text.Trim().Length == 0)
            {
                emailValidateMsg.Visible = true;
                emailValidateMsg.Text = "can not be empty!!";
                isValidCustomer = false;
            }
            else if(!Regex.IsMatch(emailTxt.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                emailValidateMsg.Visible = true;
                emailValidateMsg.Text = "invaild email format";
                isValidCustomer = false;
            }
            else if (!customerRepo.isValidEmail(emailTxt.Text))
            {
                emailValidateMsg.Visible = true;
                emailValidateMsg.Text = "this email is used";
                isValidCustomer = false;
            }
            else
            {
                emailValidateMsg.Visible = false;
            }

            //phone validate
            if (string.IsNullOrEmpty(phoneTxt.Text) || phoneTxt.Text.Trim().Length == 0)
            {
                phoneValidateMsg.Visible = true;
                phoneValidateMsg.Text = "can not be empty!!";
                isValidCustomer = false;
            }
            else if (!Regex.IsMatch(phoneTxt.Text.Trim(), @"^\d+$"))
            {
                phoneValidateMsg.Visible = true;
                phoneValidateMsg.Text = "invalid phone number";
                isValidCustomer = false;
            }
            else
            {
                phoneValidateMsg.Visible = false;
            }

            //location validate
            if (string.IsNullOrEmpty(locationTxt.Text) || locationTxt.Text.Trim().Length == 0)
            {
                locationValidateMsg.Visible = true;
                locationValidateMsg.Text = "can not be empty!!";
                isValidCustomer = false;
            }
            else
            {
                locationValidateMsg.Visible = false;
            }

            //password validate
            if (string.IsNullOrEmpty(passwrodTxt.Text) || passwrodTxt.Text.Trim().Length < 6)
            {
                passwordValidateMsg.Visible = true;
                passwordValidateMsg.Text = "password length should be 6 or more";
                isValidCustomer = false;
            }
            else
            {
                passwordValidateMsg.Visible = false;
            }

            //match password validate
            if(repasswordTxt.Text != passwrodTxt.Text)
            {
                repasswordValidateMsg.Visible = true;
                repasswordValidateMsg.Text = "password does not match";
                isValidCustomer = false;
            }
            else
            {
                repasswordValidateMsg.Visible = false;
            }

            return isValidCustomer;
        }
    }
}
