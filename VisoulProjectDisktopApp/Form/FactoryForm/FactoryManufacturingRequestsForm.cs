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
        public FactoryManufacturingRequestsForm(FactoryModel factory)
        {
            this.factory = factory;
            InitializeComponent();
        }

        public void toHome(Object sender, EventArgs e)
        {
            FactoryHomeForm homeForm = new FactoryHomeForm(factory);
            this.Hide();
            homeForm.ShowDialog();
            this.Dispose();
        }

        public void toAddProduct(Object sender, EventArgs e)
        {
            FactoryAddProductForm productForm = new FactoryAddProductForm(factory);
            this.Hide();
            productForm.ShowDialog();
            this.Dispose();
        }

        public void toSetting(Object sender, EventArgs e)
        {
            FactorySettingsForm settingsForm = new FactorySettingsForm(factory);
            this.Hide();
            settingsForm.ShowDialog();
            this.Dispose();
        }
    }
}
