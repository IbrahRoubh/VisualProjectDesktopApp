﻿using System;
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
    public partial class FactorySettingsForm : Form
    {
        private FactoryModel factory;
        public FactorySettingsForm(FactoryModel factory)
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

        public void toManufacturingRequests(Object sender, EventArgs e)
        {
            FactoryManufacturingRequestsForm requestsForm = new FactoryManufacturingRequestsForm(factory);
            this.Hide();
            requestsForm.ShowDialog();
            this.Dispose();
        }

        private void FactorySettingsForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = factory.name;
            emailTxt.Text = factory.email;
            nameTxt.Text = factory.name;
            locationTxt.Text = factory.location;
            phoneTxt.Text = factory.phoneNum;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
