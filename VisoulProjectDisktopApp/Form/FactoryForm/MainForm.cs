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
        private FactoryModel factrory = new FactoryModel();

        private FactoryRepo factoryRepo = new FactoryRepo();
        private ProductRepo productRepo = new ProductRepo();
        private StoreRepo storeRepo = new StoreRepo();
        private SuppliesRepo suppliesRepo = new SuppliesRepo();
        public MainForm()
        {
            InitializeComponent();
        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        DataGridView storeGridView;
        private void storeBox_onClick(object sender, EventArgs e)
        {
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
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(storeGridView);
        }

        DataGridView ProductDataGridView;
        int SID;
        private void onSelectStoreClick(object sender, DataGridViewCellEventArgs e)
        {
            if (storeGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                SID = (int)storeGridView.Rows[e.RowIndex].Cells["ID"].Value;
                List<ProductModel> products = storeRepo.getStoreProduscts(SID);

                ProductDataGridView = new DataGridView();
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
                mainPanel.Controls.Clear();
                ProductDataGridView.Columns.Add(orderColumn);
                ProductDataGridView.CellContentClick += new DataGridViewCellEventHandler(toSlelectOrderAmount);
                mainPanel.Controls.Add(ProductDataGridView);
            }
        }

        
        int PID;
        private TextBox amountTxt;
        private void toSlelectOrderAmount(object sender, DataGridViewCellEventArgs e)
        {
                PID = (int)ProductDataGridView.Rows[e.RowIndex].Cells["ID"].Value;

                Label amountLabel = new Label();
                amountTxt= new TextBox();
                Button orderBtn = new Button();

                amountLabel.Text = "Amount";
                amountLabel.Location = new System.Drawing.Point(10, 10);

                amountTxt.Location = new System.Drawing.Point(110, 10);

                orderBtn.Text = "Order";
                orderBtn.Location = new System.Drawing.Point(300, 10);
                orderBtn.Click += new EventHandler(onOrderBtnClick);

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(amountLabel);
                mainPanel.Controls.Add(amountTxt);
                mainPanel.Controls.Add(orderBtn);
        }
        
        private void onOrderBtnClick(object sender, EventArgs e)
        {
            if (int.TryParse(amountTxt.Text, out int amount))
            {
                if(storeRepo.productOrderFromStore(PID, factrory.id, SID, amount))
                {
                    MessageBox.Show("The order done successful");
                    storeBox_onClick(sender,e);
                }
            }
            else
            {
                MessageBox.Show("error invalid input, it should be number");
            }
        }

        
        DataGridView requestDataGrid;
        private void requestBox_Click(object sender, EventArgs e)
        {
            
            List<SuppliesModel> supplies = factoryRepo.getRequest(factrory.id);

            requestDataGrid = new DataGridView();
            requestDataGrid.Dock = DockStyle.Fill;
            requestDataGrid.AutoGenerateColumns = false;
            requestDataGrid.Columns.Add("ID","ID");
            requestDataGrid.Columns.Add("PName", "Product name");
            requestDataGrid.Columns.Add("PCode", "Product code");
            requestDataGrid.Columns.Add("Amount", "Amount");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Button Column";
            buttonColumn.Text = "done and shipped";
            buttonColumn.UseColumnTextForButtonValue = true;
            requestDataGrid.Columns.Add(buttonColumn);
            requestDataGrid.CellContentClick += new DataGridViewCellEventHandler(onDoneShippedClick);

            if (supplies != null)
            {
                foreach (SuppliesModel supplie in supplies)
                {
                    ProductModel product = productRepo.getProduct(supplie.PID);
                    if(product != null)
                    requestDataGrid.Rows.Add(supplie.id, product.name, product.code, supplie.amount);
                }
            }

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(requestDataGrid);
        }

        
        private void onDoneShippedClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)requestDataGrid.Rows[e.RowIndex].Cells["ID"].Value;

            DialogResult result = MessageBox.Show("Do you want to report request which have id=" + id + " as shipped?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (suppliesRepo.isStateChange(id, "s"))
                {
                    MessageBox.Show("State change, thank you");
                    requestBox_Click(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("For some resoun we could not change the state!!!");
                }
            }
        }

        DataGridView productGridView;
        private void storgBox_onClick(object sender, EventArgs e)
        {
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
            mainPanel.Controls.Clear();
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

                mainPanel.Controls.Clear();
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
        private void toSetting(object sender, EventArgs e)
        {
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

            mainPanel.Controls.Clear();
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

        
        DataGridView trackOrderTable;
        private void tracikOrder_Click(object sender, EventArgs e)
        {
            List<SuppliesModel> supplies = factoryRepo.getOrders(factrory.id);

            trackOrderTable= new DataGridView();
            trackOrderTable.Dock = DockStyle.Fill;
            trackOrderTable.AutoGenerateColumns = false;
            trackOrderTable.Columns.Add("ID","ID");
            trackOrderTable.Columns.Add("Pname", "Product name");
            trackOrderTable.Columns.Add("Pcode", "Product code");
            trackOrderTable.Columns.Add("amount", "Amount");
            trackOrderTable.Columns.Add("state", "Shipment status");
            trackOrderTable.Columns.Add("Date", "Arrival date");

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Button Column";
            buttonColumn.Text = "Shipment received";
            buttonColumn.UseColumnTextForButtonValue = true;
            trackOrderTable.Columns.Add(buttonColumn);
            trackOrderTable.CellContentClick += new DataGridViewCellEventHandler(onShipmentReceivedClick);

            if (supplies != null)
            {
                foreach(SuppliesModel supplie in supplies)
                {
                    ProductModel product = productRepo.getProduct(supplie.PID);
                    String state = null;
                    if (string.Equals(supplie.status, 'o'.ToString()))
                    {
                        state = "Ordered";
                    }
                    else if(string.Equals(supplie.status, 's'.ToString()))
                    {
                        state = "Shipped";
                    }
                    if (product != null)
                    {
                        trackOrderTable.Rows.Add(supplie.id, product.name, product.code, supplie.amount, state, supplie.date_of_arrival);
                    }
                }
            }
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(trackOrderTable);
        }

        private void onShipmentReceivedClick(object sender, DataGridViewCellEventArgs e)
        {
            int id=(int)trackOrderTable.Rows[e.RowIndex].Cells["ID"].Value;

            DialogResult result = MessageBox.Show("Do you want to report Shippend which have id="+id+" as recived?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (suppliesRepo.isStateChange(id,"d"))
                {
                    MessageBox.Show("State change, thank you");
                    tracikOrder_Click(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("For some resoun we could not change the state!!!");
                }
            }
        }
    }
}