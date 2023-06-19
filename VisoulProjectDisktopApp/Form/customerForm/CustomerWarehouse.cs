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

    public partial class CustomerWarehouse : Form
    {
        private CustomerModel customer;

        private CustomerRepo customerRepo = new CustomerRepo();
        private StoreRepo storeRepo = new StoreRepo();


        public CustomerWarehouse(int id)
        {
            this.customer = customerRepo.getCustomerById(id);
            InitializeComponent();
        }

        private void CustomerWarehouse_Load(object sender, EventArgs e)
        {
            customerNameLabel.Text = customer.Name;
            loadWarehouses();
        }

        private void loadWarehouses()
        {
            warehouseDataGrid.Rows.Clear();
            warehouseDataGrid.CellContentClick += new DataGridViewCellEventHandler(onExploerClick);

            List<StoreModel> stores = storeRepo.getStores();

            foreach(StoreModel store in stores)
            {
                warehouseDataGrid.Rows.Add(store.name, store.location, store.phone);
            }
        }

        private void onExploerClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void toSetting(object sender, EventArgs e)
        {
            CustomerSetting setting = new CustomerSetting(customer.Id);
            this.Hide();
            setting.ShowDialog();
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

        private void toHome(object sender, EventArgs e)
        {
            CustomerHome home= new CustomerHome(customer.Id);
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }
    }
}
