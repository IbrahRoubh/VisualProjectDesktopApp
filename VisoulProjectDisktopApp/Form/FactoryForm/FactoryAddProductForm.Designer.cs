﻿using System.Windows.Forms;

namespace VisoulProjectDisktopApp
{
    partial class FactoryAddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.addProductPanel = new System.Windows.Forms.Panel();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.manufacturingRequestPanel = new System.Windows.Forms.Panel();
            this.manufacturingRequestsLabel = new System.Windows.Forms.Label();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.productCodeTxt = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.Label();
            this.productDescriptionTxt = new System.Windows.Forms.TextBox();
            this.prdouctAmountLabel = new System.Windows.Forms.Label();
            this.productAmountTxt = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceValidateMsg = new System.Windows.Forms.Label();
            this.nameValidateMsg = new System.Windows.Forms.Label();
            this.codeValidateMsg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.addProductPanel.SuspendLayout();
            this.manufacturingRequestPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55445F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homePanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addProductPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.manufacturingRequestPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.settingPanel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(72, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(3, 93);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(187, 84);
            this.homePanel.TabIndex = 1;
            this.homePanel.Click += new System.EventHandler(this.toHome);
            // 
            // homeLabel
            // 
            this.homeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeLabel.AutoSize = true;
            this.homeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(67, 35);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(49, 20);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.toHome);
            // 
            // addProductPanel
            // 
            this.addProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addProductPanel.Controls.Add(this.addProductLabel);
            this.addProductPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProductPanel.Location = new System.Drawing.Point(3, 183);
            this.addProductPanel.Name = "addProductPanel";
            this.addProductPanel.Size = new System.Drawing.Size(187, 84);
            this.addProductPanel.TabIndex = 2;
            // 
            // addProductLabel
            // 
            this.addProductLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(45, 39);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(94, 20);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "add product";
            this.addProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manufacturingRequestPanel
            // 
            this.manufacturingRequestPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manufacturingRequestPanel.Controls.Add(this.manufacturingRequestsLabel);
            this.manufacturingRequestPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingRequestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manufacturingRequestPanel.Location = new System.Drawing.Point(3, 273);
            this.manufacturingRequestPanel.Name = "manufacturingRequestPanel";
            this.manufacturingRequestPanel.Size = new System.Drawing.Size(187, 84);
            this.manufacturingRequestPanel.TabIndex = 3;
            this.manufacturingRequestPanel.Click += new System.EventHandler(this.toManufacturingRequests);
            // 
            // manufacturingRequestsLabel
            // 
            this.manufacturingRequestsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manufacturingRequestsLabel.AutoSize = true;
            this.manufacturingRequestsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manufacturingRequestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturingRequestsLabel.Location = new System.Drawing.Point(6, 32);
            this.manufacturingRequestsLabel.Name = "manufacturingRequestsLabel";
            this.manufacturingRequestsLabel.Size = new System.Drawing.Size(177, 20);
            this.manufacturingRequestsLabel.TabIndex = 0;
            this.manufacturingRequestsLabel.Text = "manufacturing requests";
            this.manufacturingRequestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manufacturingRequestsLabel.Click += new System.EventHandler(this.toManufacturingRequests);
            // 
            // settingPanel
            // 
            this.settingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingPanel.Controls.Add(this.settingLabel);
            this.settingPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(3, 363);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(187, 84);
            this.settingPanel.TabIndex = 4;
            this.settingPanel.Click += new System.EventHandler(this.toSetting);
            // 
            // settingLabel
            // 
            this.settingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingLabel.AutoSize = true;
            this.settingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(59, 37);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(57, 20);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "setting";
            this.settingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingLabel.Click += new System.EventHandler(this.toSetting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new product";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(377, 119);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(41, 16);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "name";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCodeLabel.Location = new System.Drawing.Point(380, 186);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(38, 16);
            this.productCodeLabel.TabIndex = 3;
            this.productCodeLabel.Text = "code";
            // 
            // addProductBtn
            // 
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.Location = new System.Drawing.Point(568, 415);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addProductBtn.TabIndex = 5;
            this.addProductBtn.Text = "add";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(512, 116);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(131, 20);
            this.productNameTxt.TabIndex = 0;
            // 
            // productCodeTxt
            // 
            this.productCodeTxt.Location = new System.Drawing.Point(512, 183);
            this.productCodeTxt.Name = "productCodeTxt";
            this.productCodeTxt.Size = new System.Drawing.Size(131, 20);
            this.productCodeTxt.TabIndex = 1;
            // 
            // productDescription
            // 
            this.productDescription.AutoSize = true;
            this.productDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescription.Location = new System.Drawing.Point(380, 245);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(73, 16);
            this.productDescription.TabIndex = 7;
            this.productDescription.Text = "description";
            // 
            // productDescriptionTxt
            // 
            this.productDescriptionTxt.Location = new System.Drawing.Point(512, 242);
            this.productDescriptionTxt.Name = "productDescriptionTxt";
            this.productDescriptionTxt.Size = new System.Drawing.Size(131, 20);
            this.productDescriptionTxt.TabIndex = 2;
            // 
            // prdouctAmountLabel
            // 
            this.prdouctAmountLabel.AutoSize = true;
            this.prdouctAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdouctAmountLabel.Location = new System.Drawing.Point(377, 304);
            this.prdouctAmountLabel.Name = "prdouctAmountLabel";
            this.prdouctAmountLabel.Size = new System.Drawing.Size(51, 16);
            this.prdouctAmountLabel.TabIndex = 9;
            this.prdouctAmountLabel.Text = "amount";
            // 
            // productAmountTxt
            // 
            this.productAmountTxt.Location = new System.Drawing.Point(512, 303);
            this.productAmountTxt.Name = "productAmountTxt";
            this.productAmountTxt.Size = new System.Drawing.Size(131, 20);
            this.productAmountTxt.TabIndex = 3;
            this.productAmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productAmountTxt_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(380, 363);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(37, 16);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "price";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(512, 362);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(131, 20);
            this.priceTxt.TabIndex = 4;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // priceValidateMsg
            // 
            this.priceValidateMsg.AutoSize = true;
            this.priceValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.priceValidateMsg.Location = new System.Drawing.Point(537, 385);
            this.priceValidateMsg.Name = "priceValidateMsg";
            this.priceValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.priceValidateMsg.TabIndex = 11;
            this.priceValidateMsg.Text = "Validate MSG";
            this.priceValidateMsg.Visible = false;
            // 
            // nameValidateMsg
            // 
            this.nameValidateMsg.AutoSize = true;
            this.nameValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.nameValidateMsg.Location = new System.Drawing.Point(537, 139);
            this.nameValidateMsg.Name = "nameValidateMsg";
            this.nameValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.nameValidateMsg.TabIndex = 12;
            this.nameValidateMsg.Text = "Validate MSG";
            this.nameValidateMsg.Visible = false;
            // 
            // codeValidateMsg
            // 
            this.codeValidateMsg.AutoSize = true;
            this.codeValidateMsg.ForeColor = System.Drawing.Color.Red;
            this.codeValidateMsg.Location = new System.Drawing.Point(537, 206);
            this.codeValidateMsg.Name = "codeValidateMsg";
            this.codeValidateMsg.Size = new System.Drawing.Size(72, 13);
            this.codeValidateMsg.TabIndex = 13;
            this.codeValidateMsg.Text = "Validate MSG";
            this.codeValidateMsg.Visible = false;
            // 
            // FactoryAddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codeValidateMsg);
            this.Controls.Add(this.nameValidateMsg);
            this.Controls.Add(this.priceValidateMsg);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productAmountTxt);
            this.Controls.Add(this.prdouctAmountLabel);
            this.Controls.Add(this.productDescriptionTxt);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productCodeTxt);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FactoryAddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.FactoryAddProductForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.addProductPanel.ResumeLayout(false);
            this.addProductPanel.PerformLayout();
            this.manufacturingRequestPanel.ResumeLayout(false);
            this.manufacturingRequestPanel.PerformLayout();
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel addProductPanel;
        private System.Windows.Forms.Panel manufacturingRequestPanel;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Label manufacturingRequestsLabel;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.TextBox productCodeTxt;
        private System.Windows.Forms.Label productDescription;
        private System.Windows.Forms.TextBox productDescriptionTxt;
        private System.Windows.Forms.Label prdouctAmountLabel;
        private System.Windows.Forms.TextBox productAmountTxt;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTxt;
        private Label priceValidateMsg;
        private Label nameValidateMsg;
        private Label codeValidateMsg;
    }
}