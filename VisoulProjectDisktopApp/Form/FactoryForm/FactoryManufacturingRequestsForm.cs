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
    public partial class FactoryManufacturingRequestsForm : Form
    {
        private FactoryModel factory;
        private FactoryRepo factoryRepo = new FactoryRepo();
        public FactoryManufacturingRequestsForm(int id)
        {
            this.factory = factoryRepo.getFactoryById(id);
            InitializeComponent();
        }

        private void FactoryManufacturingRequestsForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = factory.name;
            loadManfacturingRequest();
        }

        private void toHome(Object sender, EventArgs e)
        {
            FactoryHomeForm homeForm = new FactoryHomeForm(factory.id);
            this.Hide();
            homeForm.ShowDialog();
            this.Dispose();
        }

        private void toAddProduct(Object sender, EventArgs e)
        {
            FactoryAddProductForm productForm = new FactoryAddProductForm(factory.id);
            this.Hide();
            productForm.ShowDialog();
            this.Dispose();
        }

        private void toSetting(Object sender, EventArgs e)
        {
            FactorySettingsForm settingsForm = new FactorySettingsForm(factory.id);
            this.Hide();
            settingsForm.ShowDialog();
            this.Dispose();
        }

        private void loadManfacturingRequest()
        {
            //manfacturRequesDataGrid

        }
    }
}
