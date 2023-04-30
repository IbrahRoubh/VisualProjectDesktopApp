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


        private void productBox_onClick(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }
    }
}
