using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;
using VisoulProjectDisktopApp.Repository;

namespace VisoulProjectDisktopApp
{
    public partial class MainForm : Form
    {
        DataGridView productGridView;

        private FactroryModel factrory = new FactroryModel();

        private FactoryRepo factoryRepo = new FactoryRepo();
        private ProductRepo productRepo = new ProductRepo();

        private CookieManager cookieManager;
        String username;
        public MainForm(CookieManager cookieManager)
        {
            this.cookieManager = cookieManager;
            InitializeComponent();
        }

        private  void MainForm_Load(object sender, EventArgs e)
        {
            CookieCollection cookies = cookieManager.GetCookie().GetCookies(new Uri("http://localhost")); ;
            if (cookies["username"] != null)
            {
                username = cookies["username"].Value;
            }
            factoryRepo.loadFactory(factrory, username);
            setInfo();
        }

        private void setInfo()
        {
            usernameLabel.Text = username;
        }


        private void storeBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Label l = new Label();
            l.Text = "store name";
            mainPanel.Controls.Add(l); 
        }

        private void requestBox_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Label l = new Label();
            l.Text = "hi there";
            mainPanel.Controls.Add(l);
        }

        private void storgBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            List<ProductModel> products = productRepo.getProductsByFactoryID(factrory.id);
            productGridView = new DataGridView();
            productGridView.Dock = DockStyle.Fill;
            productGridView.AutoGenerateColumns = false;
            productGridView.Columns.Add("Name", "Product Name");
            productGridView.Columns.Add("Description", "Description");
            productGridView.Columns.Add("Code", "Product Code");
            productGridView.Columns.Add("Amount", "Product Amount");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Button Column";
            buttonColumn.Text = "update";
            buttonColumn.UseColumnTextForButtonValue = true;
            productGridView.Columns.Add(buttonColumn);

            if (products != null)
            {
                foreach (ProductModel product in products)
                {
                    productGridView.Rows.Add(product.name, product.description, product.code, product.amount);
                }
            }
            mainPanel.Controls.Add(productGridView);
        }

        private void onUpdateRecordClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                String name = (String)productGridView.Rows[e.RowIndex].Cells["Name"].Value;
            }
        }



        private void settingBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.RowCount = 4;
            tableLayout.ColumnCount = 2;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            Label SusernameLabel = new Label();
            SusernameLabel.Text = factrory.name;
            tableLayout.Controls.Add(SusernameLabel, 0, 0);

            Label SlocationLabel = new Label();
            SlocationLabel.Text = factrory.location;
            tableLayout.Controls.Add(SlocationLabel, 0, 1);

            Label SphoneNumLabel = new Label();
            SphoneNumLabel.Text = factrory.phoneNum;
            tableLayout.Controls.Add(SphoneNumLabel, 1, 0);

            Label SpasswordLabel = new Label();
            SpasswordLabel.Text = factrory.password;
            tableLayout.Controls.Add(SpasswordLabel, 1, 1);

            mainPanel.Controls.Add(tableLayout);
        }

    }
}
