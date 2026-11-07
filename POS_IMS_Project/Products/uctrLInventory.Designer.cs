namespace POS_IMS_Project
{
    partial class uctrLInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.lblNumberOfProducts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cmsInventory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productActivationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_OutOfStockProducuts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlActiveUsers = new System.Windows.Forms.Panel();
            this.lbl_LowStockProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFitlerType = new System.Windows.Forms.ComboBox();
            this.cbForFiltering = new System.Windows.Forms.ComboBox();
            this.txtSearchByFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.lblFilterlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchaseFromSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsInventory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlActiveUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.BackColor = System.Drawing.Color.White;
            this.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.Location = new System.Drawing.Point(1345, 222);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(227, 57);
            this.btnFindProduct.TabIndex = 17;
            this.btnFindProduct.Text = "Find Product";
            this.btnFindProduct.UseVisualStyleBackColor = false;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // lblNumberOfProducts
            // 
            this.lblNumberOfProducts.AutoSize = true;
            this.lblNumberOfProducts.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfProducts.Location = new System.Drawing.Point(178, 87);
            this.lblNumberOfProducts.Name = "lblNumberOfProducts";
            this.lblNumberOfProducts.Size = new System.Drawing.Size(172, 24);
            this.lblNumberOfProducts.TabIndex = 16;
            this.lblNumberOfProducts.Text = "Products registered";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Inventory Management";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProduct.Location = new System.Drawing.Point(1345, 143);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(227, 57);
            this.btnAddNewProduct.TabIndex = 14;
            this.btnAddNewProduct.Text = "+ Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cmsInventory;
            this.dgvProducts.Location = new System.Drawing.Point(35, 322);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1555, 506);
            this.dgvProducts.TabIndex = 13;
            // 
            // cmsInventory
            // 
            this.cmsInventory.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProductToolStripMenuItem,
            this.productInfoToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.productActivationToolStripMenuItem,
            this.purchaseFromSupplierToolStripMenuItem});
            this.cmsInventory.Name = "cmsInventory";
            this.cmsInventory.Size = new System.Drawing.Size(272, 197);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            this.updateProductToolStripMenuItem.Click += new System.EventHandler(this.updateProductToolStripMenuItem_Click);
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.productInfoToolStripMenuItem.Text = "Product Info";
            this.productInfoToolStripMenuItem.Click += new System.EventHandler(this.productInfoToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // productActivationToolStripMenuItem
            // 
            this.productActivationToolStripMenuItem.Name = "productActivationToolStripMenuItem";
            this.productActivationToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.productActivationToolStripMenuItem.Text = "Reverse Active Status";
            this.productActivationToolStripMenuItem.Click += new System.EventHandler(this.productActivationToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_OutOfStockProducuts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(381, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 136);
            this.panel1.TabIndex = 11;
            // 
            // lbl_OutOfStockProducuts
            // 
            this.lbl_OutOfStockProducuts.AutoSize = true;
            this.lbl_OutOfStockProducuts.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutOfStockProducuts.ForeColor = System.Drawing.Color.Red;
            this.lbl_OutOfStockProducuts.Location = new System.Drawing.Point(107, 59);
            this.lbl_OutOfStockProducuts.Name = "lbl_OutOfStockProducuts";
            this.lbl_OutOfStockProducuts.Size = new System.Drawing.Size(33, 39);
            this.lbl_OutOfStockProducuts.TabIndex = 1;
            this.lbl_OutOfStockProducuts.Text = "1";
            this.lbl_OutOfStockProducuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(50, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Out of Stock";
            // 
            // pnlActiveUsers
            // 
            this.pnlActiveUsers.BackColor = System.Drawing.Color.White;
            this.pnlActiveUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveUsers.Controls.Add(this.lbl_LowStockProducts);
            this.pnlActiveUsers.Controls.Add(this.label1);
            this.pnlActiveUsers.Location = new System.Drawing.Point(56, 143);
            this.pnlActiveUsers.Name = "pnlActiveUsers";
            this.pnlActiveUsers.Size = new System.Drawing.Size(245, 136);
            this.pnlActiveUsers.TabIndex = 9;
            // 
            // lbl_LowStockProducts
            // 
            this.lbl_LowStockProducts.AutoSize = true;
            this.lbl_LowStockProducts.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LowStockProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lbl_LowStockProducts.Location = new System.Drawing.Point(104, 59);
            this.lbl_LowStockProducts.Name = "lbl_LowStockProducts";
            this.lbl_LowStockProducts.Size = new System.Drawing.Size(33, 39);
            this.lbl_LowStockProducts.TabIndex = 1;
            this.lbl_LowStockProducts.Text = "1";
            this.lbl_LowStockProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Stock";
            // 
            // cbFitlerType
            // 
            this.cbFitlerType.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFitlerType.FormattingEnabled = true;
            this.cbFitlerType.Items.AddRange(new object[] {
            "None",
            "Stock",
            "Brand Name",
            "Category Name",
            "Active Products"});
            this.cbFitlerType.Location = new System.Drawing.Point(828, 160);
            this.cbFitlerType.Name = "cbFitlerType";
            this.cbFitlerType.Size = new System.Drawing.Size(196, 35);
            this.cbFitlerType.TabIndex = 18;
            this.cbFitlerType.SelectedIndexChanged += new System.EventHandler(this.cbFitlerType_SelectedIndexChanged);
            // 
            // cbForFiltering
            // 
            this.cbForFiltering.Font = new System.Drawing.Font("Calibri", 11F);
            this.cbForFiltering.FormattingEnabled = true;
            this.cbForFiltering.Location = new System.Drawing.Point(828, 232);
            this.cbForFiltering.Name = "cbForFiltering";
            this.cbForFiltering.Size = new System.Drawing.Size(196, 35);
            this.cbForFiltering.TabIndex = 19;
            this.cbForFiltering.SelectedIndexChanged += new System.EventHandler(this.cbForFiltering_SelectedIndexChanged);
            // 
            // txtSearchByFilter
            // 
            this.txtSearchByFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchByFilter.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByFilter.Location = new System.Drawing.Point(828, 232);
            this.txtSearchByFilter.Name = "txtSearchByFilter";
            this.txtSearchByFilter.Size = new System.Drawing.Size(196, 34);
            this.txtSearchByFilter.TabIndex = 20;
            this.txtSearchByFilter.TextChanged += new System.EventHandler(this.txtSearchByFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(697, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter Type:";
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.White;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.Location = new System.Drawing.Point(1084, 143);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(227, 57);
            this.btnBrand.TabIndex = 24;
            this.btnBrand.Text = "Brands";
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Location = new System.Drawing.Point(1084, 222);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(227, 57);
            this.btnCategory.TabIndex = 25;
            this.btnCategory.Text = "Categories";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // lblFilterlabel
            // 
            this.lblFilterlabel.AutoSize = true;
            this.lblFilterlabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterlabel.Location = new System.Drawing.Point(745, 236);
            this.lblFilterlabel.Name = "lblFilterlabel";
            this.lblFilterlabel.Size = new System.Drawing.Size(65, 27);
            this.lblFilterlabel.TabIndex = 26;
            this.lblFilterlabel.Text = "Filter:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_IMS_Project.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(56, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // purchaseFromSupplierToolStripMenuItem
            // 
            this.purchaseFromSupplierToolStripMenuItem.Name = "purchaseFromSupplierToolStripMenuItem";
            this.purchaseFromSupplierToolStripMenuItem.Size = new System.Drawing.Size(271, 32);
            this.purchaseFromSupplierToolStripMenuItem.Text = "Purchase From Supplier";
            this.purchaseFromSupplierToolStripMenuItem.Click += new System.EventHandler(this.purchaseFromSupplierToolStripMenuItem_Click);
            // 
            // uctrLInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFilterlabel);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchByFilter);
            this.Controls.Add(this.cbForFiltering);
            this.Controls.Add(this.cbFitlerType);
            this.Controls.Add(this.btnFindProduct);
            this.Controls.Add(this.lblNumberOfProducts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlActiveUsers);
            this.Name = "uctrLInventory";
            this.Size = new System.Drawing.Size(1625, 865);
            this.Load += new System.EventHandler(this.uctrLInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsInventory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlActiveUsers.ResumeLayout(false);
            this.pnlActiveUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Label lblNumberOfProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_OutOfStockProducuts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlActiveUsers;
        private System.Windows.Forms.Label lbl_LowStockProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFitlerType;
        private System.Windows.Forms.ComboBox cbForFiltering;
        private System.Windows.Forms.TextBox txtSearchByFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsInventory;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productActivationToolStripMenuItem;
        private System.Windows.Forms.Label lblFilterlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem purchaseFromSupplierToolStripMenuItem;
    }
}
