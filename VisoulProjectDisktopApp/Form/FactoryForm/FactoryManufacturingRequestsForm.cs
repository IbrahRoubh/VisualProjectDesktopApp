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
    public partial class FactoryManufacturingRequestsForm : Form
    {
        private FactoryModel factory;
        
        private FactoryRepo factoryRepo = new FactoryRepo();
        private StoreRepo storeRepo = new StoreRepo();
        private ProductRepo productRepo = new ProductRepo();
        private SuppliesRepo suppliesRepo = new SuppliesRepo();

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
            manfacturRequesDataGrid.Rows.Clear();
            manfacturRequesDataGrid.CellContentClick += new DataGridViewCellEventHandler(onDoneShippedClick);

            List <SuppliesModel> supplies = factoryRepo.getRequest(factory.id);

            foreach(SuppliesModel supply in supplies)
            {
                StoreModel store = storeRepo.getStoreById(supply.SID);
                ProductModel product = productRepo.getProduct(supply.PID);
                manfacturRequesDataGrid.Rows.Add(supply.id,store.name, store.location, product.name, product.code, supply.amount);
            }
        }

        private void onDoneShippedClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)manfacturRequesDataGrid.Rows[e.RowIndex].Cells["supplieId"].Value;

            DialogResult result = MessageBox.Show("Do you want to report request which have id=" + id + " as shipped?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (suppliesRepo.requestSend(id))
                {
                    MessageBox.Show("State change, thank you");
                    loadManfacturingRequest();
                }
                else
                {
                    MessageBox.Show("For some resoun we could not change the state!!!");
                }
            }
        }

    }
}
