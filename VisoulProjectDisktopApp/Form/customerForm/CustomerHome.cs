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
    public partial class CustomerHome : Form
    {
        private CustomerModel customer;

        private CustomerRepo customerRepo = new CustomerRepo();
        private StoreRepo storeRepo = new StoreRepo();
        
        public CustomerHome(int id)
        {
            this.customer = customerRepo.getCustomerById(id);
            InitializeComponent();
        }

        private void toSetting(object sender, EventArgs e)
        {
            CustomerSetting setting= new CustomerSetting(customer.Id);
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
            CustomerPreviosOrder preOrder= new CustomerPreviosOrder(customer.Id);
            this.Hide();
            preOrder.ShowDialog();
            this.Dispose();
        }

        private void toWarehouse(object sender, EventArgs e)
        {
            CustomerWarehouse warehouse= new CustomerWarehouse(customer.Id);
            this.Hide();
            warehouse.ShowDialog();
            this.Dispose();
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

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            customerNameLabel.Text = customer.Name;
            loadWarehouse();
        }

        private void loadWarehouse()
        {
            warehouseDataGrid.Rows.Clear();
            warehouseDataGrid.CellContentClick += new DataGridViewCellEventHandler(onExploerClick);
            List<StoreModel> stores = storeRepo.getStores();

            foreach (StoreModel store in stores)
            {
                warehouseDataGrid.Rows.Add(store.name,store.location,store.phone,store.ID);
            }
        }

        private void onExploerClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == exploreBtn.Index && e.ColumnIndex != -1)
            {
                DataGridViewRow clickedRow = warehouseDataGrid.Rows[e.RowIndex];
                string id = clickedRow.Cells["warehouseId"].Value.ToString();

                CustomerWarehouseProductShow show = new CustomerWarehouseProductShow(customer.Id, int.Parse(id));
                this.Hide();
                show.ShowDialog();
                this.Dispose();
            }
        }
    }
}
