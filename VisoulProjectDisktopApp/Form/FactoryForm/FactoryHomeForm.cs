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
    }
}
