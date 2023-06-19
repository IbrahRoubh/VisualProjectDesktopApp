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

namespace VisoulProjectDisktopApp
{
    public partial class FactorySettingsForm : Form
    {
        private FactoryModel factory;
        private FactoryRepo factoryRepo = new FactoryRepo();
        public FactorySettingsForm(int id)
        {
            this.factory = factoryRepo.getFactoryById(id);
            InitializeComponent();
        }

        public void toHome(Object sender, EventArgs e)
        {
            FactoryHomeForm homeForm = new FactoryHomeForm(factory.id);
            this.Hide();
            homeForm.ShowDialog();
            this.Dispose();
        }

        public void toAddProduct(Object sender, EventArgs e)
        {
            FactoryAddProductForm productForm = new FactoryAddProductForm(factory.id);
            this.Hide();
            productForm.ShowDialog();
            this.Dispose();
        }

        public void toManufacturingRequests(Object sender, EventArgs e)
        {
            FactoryManufacturingRequestsForm requestsForm = new FactoryManufacturingRequestsForm(factory.id);
            this.Hide();
            requestsForm.ShowDialog();
            this.Dispose();
        }

        private void FactorySettingsForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = factory.name;
            emailTxt.Text = factory.email;
            nameTxt.Text = factory.name;
            locationTxt.Text = factory.location;
            phoneTxt.Text = factory.phoneNum;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            bool isValid = isValidUpdateInfo();
            if (isValid)
            {
                string password;
                if (newPasswordTxt.Text.Trim().Length != 0)
                    password = newPasswordTxt.Text.Trim();
                else
                    password = factory.password;

                factoryRepo.updateFactory(factory.id,nameTxt.Text,locationTxt.Text,phoneTxt.Text, password);
            }
        }
         private Boolean isValidUpdateInfo()
        {
            Boolean isValid = true;
            if (nameTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                nameValidateLabel.Text = "this can not be empty";
                nameValidateLabel.Visible = true;
            }
            else
            {
                nameValidateLabel.Visible = false;
            }

            if (locationTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                locationValidateLabel.Text = "this can not be empty";
                locationValidateLabel.Visible = true;
            }
            else
            {
                locationValidateLabel.Visible = false;
            }

            if (phoneTxt.Text.Trim().Length == 0)
            {
                isValid = false;
                phoneValidateLabel.Text = "this can not be empty";
                phoneValidateLabel.Visible = true;
            }
            else
            {
                phoneValidateLabel.Visible = false;
            }


            if(oldPasswordTxt.Text.Trim().Length == 0)
            {
                if(newPasswordTxt.Text.Trim().Length> 0)
                {
                    isValid = false;
                    oldPasswordValidateLabel.Text = "this can not be empty";
                    oldPasswordValidateLabel.Visible = true;
                    if (newPasswordTxt.Text.Trim().Length < 6)
                    {
                        newPasswordValidateLabel.Text = "length must be more than 6";
                        newPasswordValidateLabel.Visible = true;
                    }
                    else
                    {
                        newPasswordValidateLabel.Visible = false;
                    }
                }
                else
                {
                    oldPasswordValidateLabel.Visible = false;
                }
            }
            else
            {
                if (oldPasswordTxt.Text != factory.password)
                {
                    isValid = false;
                    oldPasswordValidateLabel.Text = "wrong password";
                    oldPasswordValidateLabel.Visible = true;
                }
                else
                {
                    oldPasswordValidateLabel.Visible = false;
                }

                if (newPasswordTxt.Text.Trim().Length<6)
                {
                    isValid = false;
                    newPasswordValidateLabel.Text = "min number should be 6";
                    newPasswordValidateLabel.Visible = true;
                }
                else
                {
                    newPasswordValidateLabel.Visible = false;
                }
            }

                return isValid;
        }
    }
}
