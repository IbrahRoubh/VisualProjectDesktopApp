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
    public partial class CustomerSetting : Form
    {
        private CustomerModel customer;

        private CustomerRepo customerRepo = new CustomerRepo();
        public CustomerSetting(int id)
        {
            this.customer = customerRepo.getCustomerById(id);
            InitializeComponent();
        }

        private void CustomerSetting_Load(object sender, EventArgs e)
        {
            customerNameLabel.Text = customer.Name;
            emailTxt.Text = customer.Email;
            nameTxt.Text = customer.Name;
            locationTxt.Text = customer.Location;
            phoneTxt.Text = customer.Phone;
        }

        private void toHome(object sender, EventArgs e)
        {
            CustomerHome home= new CustomerHome(customer.Id);
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }

        private void toOrder(object sender, EventArgs e)
        {
            CustomerMyOrder order = new CustomerMyOrder(customer.Id);
            this.Hide();
            order.ShowDialog();
            this.Dispose();
        }

        private void toPrevOrder(object sender, EventArgs e)
        {
            CustomerPreviosOrder preOrder = new CustomerPreviosOrder(customer.Id);
            this.Hide();
            preOrder.ShowDialog();
            this.Dispose();
        }

        private void toWarehouse(object sender, EventArgs e)
        {
            CustomerWarehouse warehouse = new CustomerWarehouse(customer.Id);
            this.Hide();
            warehouse.ShowDialog();
            this.Dispose();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Boolean isValid = isVaildUpdateInfo();

            if (isValid)
            {
                string password;
                if (newPasswordTxt.Text.Trim().Length != 0)
                    password = newPasswordTxt.Text.Trim();
                else
                    password = customer.Password;

                customerRepo.updateCustomer(customer.Id, nameTxt.Text, locationTxt.Text, phoneTxt.Text, password);
            }
        }

        private Boolean isVaildUpdateInfo()
        {
            Boolean isValid = true;

            if (nameTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                nameValidateMsg.Text = "this can not be empty";
                nameValidateMsg.Visible = true;
            }
            else
            {
                nameValidateMsg.Visible = false;
            }

            if (locationTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                locationValidateMsg.Text = "this can not be empty";
                locationValidateMsg.Visible = true;
            }
            else
            {
                locationValidateMsg.Visible = false;
            }

            if (phoneTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                phoneValidateMsg.Text = "this can not be empty";
                phoneValidateMsg.Visible = true;
            }
            else
            {
                phoneValidateMsg.Visible = false;
            }


            if (oldPasswordTxt.Text.Trim().Length == 0)
            {
                if (newPasswordTxt.Text.Trim().Length > 0)
                {
                    isValid = false;
                    oldPasswordValidateMsg.Text = "this can not be empty";
                    oldPasswordValidateMsg.Visible = true;
                    if (newPasswordTxt.Text.Trim().Length < 6)
                    {
                        newPasswordValidateMsg.Text = "length must be more than 6";
                        newPasswordValidateMsg.Visible = true;
                    }
                    else
                    {
                        newPasswordValidateMsg.Visible = false;
                    }
                }
                else
                {
                    oldPasswordValidateMsg.Visible = false;
                }
            }
            else
            {
                if (oldPasswordTxt.Text != customer.Password)
                {
                    isValid = false;
                    oldPasswordValidateMsg.Text = "wrong password";
                    oldPasswordValidateMsg.Visible = true;
                }
                else
                {
                    oldPasswordValidateMsg.Visible = false;
                }

                if (newPasswordTxt.Text.Trim().Length < 6)
                {
                    isValid = false;
                    newPasswordValidateMsg.Text = "min number should be 6";
                    newPasswordValidateMsg.Visible = true;
                }
                else
                {
                    newPasswordValidateMsg.Visible = false;
                }
            }

            return isValid;
        }
    }
}
