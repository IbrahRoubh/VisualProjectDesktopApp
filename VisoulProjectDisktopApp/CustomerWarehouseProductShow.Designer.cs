namespace VisoulProjectDisktopApp
{
    partial class CustomerWarehouseProductShow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toHomeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameWarehouseLabel = new System.Windows.Forms.Label();
            this.warehousePhoneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.warehousePhoneLabel);
            this.panel1.Controls.Add(this.nameWarehouseLabel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.toHomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // toHomeBtn
            // 
            this.toHomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toHomeBtn.Location = new System.Drawing.Point(684, 383);
            this.toHomeBtn.Name = "toHomeBtn";
            this.toHomeBtn.Size = new System.Drawing.Size(94, 34);
            this.toHomeBtn.TabIndex = 0;
            this.toHomeBtn.Text = "back to home";
            this.toHomeBtn.UseVisualStyleBackColor = true;
            this.toHomeBtn.Click += new System.EventHandler(this.toHomeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameWarehouseLabel
            // 
            this.nameWarehouseLabel.AutoSize = true;
            this.nameWarehouseLabel.Location = new System.Drawing.Point(65, 90);
            this.nameWarehouseLabel.Name = "nameWarehouseLabel";
            this.nameWarehouseLabel.Size = new System.Drawing.Size(33, 13);
            this.nameWarehouseLabel.TabIndex = 2;
            this.nameWarehouseLabel.Text = "name";
            // 
            // warehousePhoneLabel
            // 
            this.warehousePhoneLabel.AutoSize = true;
            this.warehousePhoneLabel.Location = new System.Drawing.Point(65, 137);
            this.warehousePhoneLabel.Name = "warehousePhoneLabel";
            this.warehousePhoneLabel.Size = new System.Drawing.Size(37, 13);
            this.warehousePhoneLabel.TabIndex = 3;
            this.warehousePhoneLabel.Text = "phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warehouse products";
            // 
            // CustomerWarehouseProductShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerWarehouseProductShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Products";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button toHomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warehousePhoneLabel;
        private System.Windows.Forms.Label nameWarehouseLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}