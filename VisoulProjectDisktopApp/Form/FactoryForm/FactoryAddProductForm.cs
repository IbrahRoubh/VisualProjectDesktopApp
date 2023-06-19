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
            try
            {
                if (productNameTxt.Text != null && productNameTxt.Text.Trim().Length != 0 && productCodeTxt.Text != null && productCodeTxt.Text.Trim().Length != 0)
                {
                    if (productAmountTxt.Text.Trim().Length == 0 || productAmountTxt.Text == null)
                        productAmountTxt.Text = "0";
                    productRepo.addProduct(productNameTxt.Text, productDescriptionTxt.Text, productCodeTxt.Text, int.Parse(productAmountTxt.Text), factory.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        private void productAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ignore the input by handling the event
                e.Handled = true;
            }
        }
    }
}
