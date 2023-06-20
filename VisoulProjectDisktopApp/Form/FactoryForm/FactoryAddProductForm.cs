using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;
using VisoulProjectDisktopApp.Repository;

namespace VisoulProjectDisktopApp
{


    public partial class FactoryAddProductForm : Form
    {
        private ProductRepo productRepo = new ProductRepo();
        private FactoryRepo factoryRepo = new FactoryRepo();
        private FactoryModel factory;

        public FactoryAddProductForm(int id)
        {
            this.factory = factoryRepo.getFactoryById(id);
            InitializeComponent();
        }

        private void FactoryAddProductForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = factory.name;
        }

        public void toHome(Object sender, EventArgs e)
        {
            FactoryHomeForm homeForm = new FactoryHomeForm(factory.id);
            this.Hide();
            homeForm.ShowDialog();
            this.Dispose();
        }

        public void toManufacturingRequests(Object sender, EventArgs e)
        {
            FactoryManufacturingRequestsForm requestsForm = new FactoryManufacturingRequestsForm(factory.id);
            this.Hide();
            requestsForm.ShowDialog();
            this.Dispose();
        }

        public void toSetting(Object sender, EventArgs e)
        {
            FactorySettingsForm settingsForm = new FactorySettingsForm(factory.id);
            this.Hide();
            settingsForm.ShowDialog();
            this.Dispose();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (isVaildProductInfo())
            {
                if (productAmountTxt.Text.Trim().Length == 0 || productAmountTxt.Text == null)
                    productAmountTxt.Text = "0";
                if (priceTxt.Text.Trim().Length == 0 || priceTxt.Text == null)
                    priceTxt.Text = "0";

                productRepo.addProduct(productNameTxt.Text, productDescriptionTxt.Text, productCodeTxt.Text, int.Parse(productAmountTxt.Text), decimal.Parse(priceTxt.Text), factory.id);
            }
        }

        private Boolean isVaildProductInfo()
        {
            Boolean isVaild = true;
            
            if (productNameTxt.Text.Trim().Length == 0 )
            {
                nameValidateMsg.Text = "can not be empty";
                nameValidateMsg.Visible = true;
                isVaild = false;
            }
            else
            {
                nameValidateMsg.Visible = false;
            }

            if (productCodeTxt.Text.Trim().Length == 0)
            {

                codeValidateMsg.Text = "can not be empty";
                codeValidateMsg.Visible = true;
                isVaild = false;
            }
            else
            {
                codeValidateMsg.Visible = false;
            }

            if (!decimal.TryParse(priceTxt.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal result))
            {
                priceValidateMsg.Text = "wrong money formaly";
                priceValidateMsg.Visible = true;
                isVaild = false;
            }
            else
            {
                priceValidateMsg.Visible = false;
            }

            return isVaild;
        }

        private void productAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignore the input by handling the event
                e.Handled = true;
            }
        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
