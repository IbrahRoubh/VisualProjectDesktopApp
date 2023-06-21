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
    public partial class CustomerWarehouseProductShow : Form
    {
        private CustomerModel customer;
        private StoreModel store;

        private CustomerRepo customerRepo = new CustomerRepo();
        private StoreRepo storeRepo = new StoreRepo();

        public CustomerWarehouseProductShow(int id, int warehouseId)
        {
            customer = customerRepo.getCustomerById(id);
            store = storeRepo.getStoreById(warehouseId);
            InitializeComponent();
        }

        private void toHomeBtn_Click(object sender, EventArgs e)
        {
            CustomerHome home = new CustomerHome(customer.Id);
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }
    }
}
