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
    public partial class CustomerPreviosOrder : Form
    {
        private CustomerModel customer;

        private CustomerRepo customerRepo = new CustomerRepo();

        public CustomerPreviosOrder(int id)
        {
            customer = customerRepo.getCustomerById(id);
            InitializeComponent();
        }

        private void toSetting(object sender, EventArgs e)
        {
            CustomerSetting setting = new CustomerSetting(customer.Id);
            this.Hide();
            setting.ShowDialog();
            this.Dispose();
        }

        private void CustomerPreviosOrder_Load(object sender, EventArgs e)
        {
            customerNameLabel.Text = customer.Name;
        }

        private void toOrder(object sender, EventArgs e)
        {
            CustomerMyOrder order = new CustomerMyOrder(customer.Id);
            this.Hide();
            order.ShowDialog();
            this.Dispose();
        }

        private void toHome(object sender, EventArgs e)
        {
            CustomerHome home= new CustomerHome(customer.Id);
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }

        private void toWarehouse(object sender, EventArgs e)
        {
            CustomerWarehouse warehouse = new CustomerWarehouse(customer.Id);
            this.Hide();
            warehouse.ShowDialog();
            this.Dispose();
        }
    }
}
