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
    public partial class FactoryHomeForm : Form
    {
        private FactoryModel factory;
        private FactoryRepo factoryRepo = new FactoryRepo();

        public FactoryHomeForm(int id)
        {
            this.factory = factoryRepo.getFactoryById(id);
            InitializeComponent();
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

        public void toSetting(Object sender, EventArgs e)
        {
            FactorySettingsForm settingsForm= new FactorySettingsForm(factory.id);
            this.Hide();
            settingsForm.ShowDialog();
            this.Dispose();
        }

        private void FactoryHomeForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = factory.name;
            manfactoryRecoustAmountTxt.Text =  factoryRepo.getReustAmount(factory.id).ToString();
            loadProducts();
        }

        private void loadProducts()
        {
            List<ProductModel> products = factoryRepo.getFactoryProducts(factory.id);
            if (products != null)
            {
                foreach (ProductModel product in products)
                {
                    int amount = factoryRepo.getProductAmount(product.id, factory.id);
                    myProductDataGrid.Rows.Add(product.name, product.code, product.description, product.price, amount);
                }
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                toLogin();
            }
        }

        private void toLogin()
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
