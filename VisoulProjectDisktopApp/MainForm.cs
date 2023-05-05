using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisoulProjectDisktopApp.model;
using VisoulProjectDisktopApp.Repository;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VisoulProjectDisktopApp
{
    public partial class MainForm : Form
    {
        


        private FactroryModel factrory = new FactroryModel();

        private FactoryRepo factoryRepo = new FactoryRepo();
        private ProductRepo productRepo = new ProductRepo();
        private StoreRepo storeRepo = new StoreRepo();

        private CookieManager cookieManager;
        String username;
        public MainForm(CookieManager cookieManager)
        {
            this.cookieManager = cookieManager;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
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

        DataGridView storeGridView;
        private void storeBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            List<StoreModel> stores = storeRepo.getStores();
            storeGridView = new DataGridView();
            storeGridView.Dock = DockStyle.Fill;
            storeGridView.AutoGenerateColumns = false;
            storeGridView.Columns.Add("ID", "Store ID");
            storeGridView.Columns.Add("name", "Store Name");
            storeGridView.Columns.Add("location", "Store Location");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Store Select";
            buttonColumn.Text = "Select";
            buttonColumn.UseColumnTextForButtonValue = true;
            storeGridView.Columns.Add(buttonColumn);
            storeGridView.CellContentClick += new DataGridViewCellEventHandler(onSelectStoreClick);

            if (stores != null)
            {
                foreach (StoreModel store in stores)
                {
                    storeGridView.Rows.Add(store.ID, store.name, store.location);
                }
            }

            mainPanel.Controls.Add(storeGridView);
        }

        DataGridView ProductDataGridView = new DataGridView();
        private void onSelectStoreClick(object sender, DataGridViewCellEventArgs e)
        {
            if (storeGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int ID = (int)storeGridView.Rows[e.RowIndex].Cells["ID"].Value;
                mainPanel.Controls.Clear();
                List<ProductModel> products = storeRepo.getStoreProduscts(ID);

                ProductDataGridView.Dock = DockStyle.Fill;
                ProductDataGridView.Columns.Add("ID", "Product id");
                ProductDataGridView.Columns.Add("name", "Name");
                ProductDataGridView.Columns.Add("description", "Description");
                ProductDataGridView.Columns.Add("code", "Code");
                ProductDataGridView.Columns.Add("amount", "Amount in store");

                foreach(ProductModel product in products)
                {
                    ProductDataGridView.Rows.Add(product.id, product.name, product.description, product.code, product.amount);
                }

                DataGridViewButtonColumn orderColumn = new DataGridViewButtonColumn();
                orderColumn.HeaderText = "Order";
                orderColumn.Text = "Order";
                orderColumn.UseColumnTextForButtonValue = true;
                ProductDataGridView.Columns.Add(orderColumn);
                ProductDataGridView.CellContentClick += new DataGridViewCellEventHandler(toSlelectOrderAmount);
                mainPanel.Controls.Add(ProductDataGridView);
            }
        }

        private void toSlelectOrderAmount(object sender, DataGridViewCellEventArgs e)
        {
            Label amountLabel = new Label();
            TextBox amountTxt = new TextBox();
            Button orderBtn = new Button();

            amountLabel.Text = "Amount";
            amountLabel.Location = new System.Drawing.Point(10, 10);

            amountTxt.Location = new System.Drawing.Point(110, 10);

            orderBtn.Text = "Order";
            orderBtn.Location = new System.Drawing.Point(300, 10);
            
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(amountLabel);
            mainPanel.Controls.Add(amountTxt);
            mainPanel.Controls.Add(orderBtn);
        }
        
        private void requestBox_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Label l = new Label();
            l.Text = "hi there";
            mainPanel.Controls.Add(l);
        }

        DataGridView productGridView;
        private void storgBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            List<ProductModel> products = productRepo.getProductsByFactoryID(factrory.id);
            productGridView = new DataGridView();
            productGridView.Dock = DockStyle.Fill;
            productGridView.AutoGenerateColumns = false;
            productGridView.Columns.Add("ID", "ID");
            productGridView.Columns.Add("Name", "Product Name");
            productGridView.Columns.Add("Description", "Description");
            productGridView.Columns.Add("Code", "Product Code");
            productGridView.Columns.Add("Amount", "Product Amount");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Button Column";
            buttonColumn.Text = "update";
            buttonColumn.UseColumnTextForButtonValue = true;
            productGridView.Columns.Add(buttonColumn);
            productGridView.CellContentClick += new DataGridViewCellEventHandler(onUpdateRecordClick);


            if (products != null)
            {
                foreach (ProductModel product in products)
                {
                    productGridView.Rows.Add(product.id,product.name, product.description, product.code, product.amount);
                }
            }
            mainPanel.Controls.Add(productGridView);
        }

        TextBox idtextBox1;
        TextBox nametextBox1;
        TextBox descriptiontextBox1;
        TextBox codetextBox1;
        TextBox amounttextBox1;
        private void onUpdateRecordClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                String name = (String)productGridView.Rows[e.RowIndex].Cells["Name"].Value;
                String description = (String)productGridView.Rows[e.RowIndex].Cells["Description"].Value;
                String code = (String)productGridView.Rows[e.RowIndex].Cells["Code"].Value;
                int amount = (int)productGridView.Rows[e.RowIndex].Cells["Amount"].Value;
                int id = (int)productGridView.Rows[e.RowIndex].Cells["ID"].Value;

                mainPanel.Controls.Clear();

                Label idLabel = new Label();
                idLabel.Location = new Point(10, 10);
                idLabel.Size = new Size(100, 20);
                idLabel.Text = "ID";

                idtextBox1 = new TextBox();
                idtextBox1.Location = new Point(120, 10);
                idtextBox1.Size = new Size(200, 20);
                idtextBox1.Text = id.ToString();
                idtextBox1.ReadOnly = true;

                Label nameLabel = new Label();
                nameLabel.Location = new Point(10, 40);
                nameLabel.Size = new Size(100, 20);
                nameLabel.Text = "Name";

                nametextBox1 = new TextBox();
                nametextBox1.Location = new Point(120, 40);
                nametextBox1.Size = new Size(200, 20);
                nametextBox1.Text = name;
                nametextBox1.ReadOnly = true;

                Label descriptionLabel = new Label();
                descriptionLabel.Location = new Point(10, 70);
                descriptionLabel.Size = new Size(100, 20);
                descriptionLabel.Text = "Description";

                descriptiontextBox1 = new TextBox();
                descriptiontextBox1.Location = new Point(120, 70);
                descriptiontextBox1.Size = new Size(200, 20);
                descriptiontextBox1.Text = description;

                Label codeLabel = new Label();
                codeLabel.Location = new Point(10, 100);
                codeLabel.Size = new Size(100, 20);
                codeLabel.Text = "Code";

                codetextBox1 = new TextBox();
                codetextBox1.Location = new Point(120, 100);
                codetextBox1.Size = new Size(200, 20);
                codetextBox1.Text = code;

                Label amountlabel = new Label();
                amountlabel.Location = new Point(10, 130);
                amountlabel.Size = new Size(100, 20);
                amountlabel.Text = "Amount";

                amounttextBox1 = new TextBox();
                amounttextBox1.Location = new Point(120, 130);
                amounttextBox1.Size = new Size(200, 20);
                amounttextBox1.Text = amount.ToString();

                Button updateButton = new Button();
                updateButton.Text = "Update";
                updateButton.Location = new Point(330, 10);
                updateButton.Size = new Size(100, 60);
                updateButton.BackColor = Color.Silver;
                updateButton.Click += new System.EventHandler(this.onUpdateClick);

                mainPanel.Controls.Add(idLabel);
                mainPanel.Controls.Add(idtextBox1);
                mainPanel.Controls.Add(nameLabel);
                mainPanel.Controls.Add(nametextBox1);
                mainPanel.Controls.Add(descriptionLabel);
                mainPanel.Controls.Add(descriptiontextBox1);
                mainPanel.Controls.Add(codeLabel);
                mainPanel.Controls.Add(codetextBox1);
                mainPanel.Controls.Add(amountlabel);
                mainPanel.Controls.Add(amounttextBox1);
                mainPanel.Controls.Add(updateButton);
            }
        }

        private void onUpdateClick(object sender, EventArgs e)
        {
            productRepo.productUpdate(factrory.id, int.Parse(idtextBox1.Text),nametextBox1.Text,descriptiontextBox1.Text,codetextBox1.Text,amounttextBox1.Text);
            MessageBox.Show("Update completed successfully");
            storgBox_onClick(sender,e);
        }

        TextBox SusernameTextbox;
        TextBox SlocationTextbox;
        TextBox SphoneNumTextbox;
        TextBox SpasswordTextbox;
        private void settingBox_onClick(object sender, EventArgs e)
        {
            factoryRepo.loadFactory(factrory, factrory.name);
            mainPanel.Controls.Clear();
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.RowCount = 5;
            tableLayout.ColumnCount = 3;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));

            Label SIdLabel = new Label();
            SIdLabel.Text = "ID:";
            tableLayout.Controls.Add(SIdLabel, 0, 0);

            TextBox SIdTextbox = new TextBox();
            SIdTextbox.Text = factrory.id.ToString();
            SIdTextbox.ReadOnly = true;
            tableLayout.Controls.Add(SIdTextbox, 1, 0);


            Label SusernameLabel = new Label();
            SusernameLabel.Text = "Username:";
            tableLayout.Controls.Add(SusernameLabel, 0, 1);

            SusernameTextbox = new TextBox();
            SusernameTextbox.Text = factrory.name;
            SusernameTextbox.ReadOnly = true;
            tableLayout.Controls.Add(SusernameTextbox, 1, 1);

            Label SlocationLabel = new Label();
            SlocationLabel.Text = "Location:";
            tableLayout.Controls.Add(SlocationLabel, 0, 2);

            SlocationTextbox = new TextBox();
            SlocationTextbox.Text = factrory.location;
            tableLayout.Controls.Add(SlocationTextbox, 1, 2);

            Label SphoneNumLabel = new Label();
            SphoneNumLabel.Text = "Phone Number:";
            tableLayout.Controls.Add(SphoneNumLabel, 0, 3);

            SphoneNumTextbox = new TextBox();
            SphoneNumTextbox.Text = factrory.phoneNum;
            tableLayout.Controls.Add(SphoneNumTextbox, 1, 3);

            Label SpasswordLabel = new Label();
            SpasswordLabel.Text = "Password:";
            tableLayout.Controls.Add(SpasswordLabel, 0, 4);

            SpasswordTextbox = new TextBox();
            SpasswordTextbox.Text = factrory.password;
            tableLayout.Controls.Add(SpasswordTextbox, 1, 4);

            Button updateButton = new Button();
            updateButton.Text = "Update";
            updateButton.Click += new EventHandler(onUpdateUserClick);
            tableLayout.Controls.Add(updateButton, 2, 4);

            mainPanel.Controls.Add(tableLayout);
        }

        public void onUpdateUserClick(object sender,EventArgs e)
        {
            factoryRepo.updateFactory(factrory.id,SusernameTextbox.Text,SlocationTextbox.Text,SphoneNumTextbox.Text,SpasswordTextbox.Text);

        }

        TextBox PnameTextBox;
        TextBox PdescriptionTextBox;
        TextBox PcodeTextBox;
        TextBox PamountTextBox;
        private void productBox_onClick(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            PnameTextBox = new TextBox();
            PdescriptionTextBox = new TextBox();
            PcodeTextBox = new TextBox();
            PamountTextBox = new TextBox();

            PnameTextBox.Width = 200;
            PdescriptionTextBox.Width = 200;
            PcodeTextBox.Width = 200;
            PamountTextBox.Width = 200;

            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(10, 10);

            PnameTextBox.Location = new Point(110, 10);

            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Description:";
            descriptionLabel.Location = new Point(10, 40);

            PdescriptionTextBox.Location = new Point(110, 40);

            Label codeLabel = new Label();
            codeLabel.Text = "Code:";
            codeLabel.Location = new Point(10, 70);

            PcodeTextBox.Location = new Point(110, 70);

            Label amountLabel = new Label();
            amountLabel.Text = "Amount:";
            amountLabel.Location = new Point(10, 100);

            PamountTextBox.Location = new Point(110, 100);

            Button addButton = new Button();
            addButton.Text = "Add Product";
            addButton.Location = new Point(100, 130);
            addButton.Click += new EventHandler(onAddProductClick);
            addButton.BackColor = Color.Silver;

            mainPanel.Controls.Add(nameLabel);
            mainPanel.Controls.Add(PnameTextBox);
            mainPanel.Controls.Add(descriptionLabel);
            mainPanel.Controls.Add(PdescriptionTextBox);
            mainPanel.Controls.Add(codeLabel);
            mainPanel.Controls.Add(PcodeTextBox);
            mainPanel.Controls.Add(amountLabel);
            mainPanel.Controls.Add(PamountTextBox);
            mainPanel.Controls.Add(addButton);
        }

        private void onAddProductClick(object sender, EventArgs e)
        {
            try
            {
                if (PnameTextBox.Text != null && PnameTextBox.Text != "" && PcodeTextBox.Text != null && PcodeTextBox.Text != "")
                {
                    if (PamountTextBox.Text == "" || PamountTextBox.Text == null)
                        PamountTextBox.Text = "0";
                    productRepo.addProduct(PnameTextBox.Text, PdescriptionTextBox.Text, PcodeTextBox.Text, int.Parse(PamountTextBox.Text), factrory.id);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }
    }
}
