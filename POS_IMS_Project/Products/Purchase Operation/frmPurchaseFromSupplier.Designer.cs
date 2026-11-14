namespace POS_IMS_Project
{
    partial class frmPurchaseFromSupplier
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
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCurrentStockProduct = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnProductInformation = new System.Windows.Forms.Button();
            this.btnPurchaseProduct = new System.Windows.Forms.Button();
            this.lblNumberOfTransaction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.White;
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductImage.Location = new System.Drawing.Point(35, 35);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(198, 195);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(253, 69);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(206, 39);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblCurrentStockProduct
            // 
            this.lblCurrentStockProduct.AutoSize = true;
            this.lblCurrentStockProduct.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStockProduct.Location = new System.Drawing.Point(254, 112);
            this.lblCurrentStockProduct.Name = "lblCurrentStockProduct";
            this.lblCurrentStockProduct.Size = new System.Drawing.Size(171, 35);
            this.lblCurrentStockProduct.TabIndex = 2;
            this.lblCurrentStockProduct.Text = "Current Stock";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(35, 274);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersWidth = 62;
            this.dgvTransactions.RowTemplate.Height = 28;
            this.dgvTransactions.Size = new System.Drawing.Size(1409, 396);
            this.dgvTransactions.TabIndex = 3;
            // 
            // btnProductInformation
            // 
            this.btnProductInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnProductInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInformation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInformation.Location = new System.Drawing.Point(1182, 69);
            this.btnProductInformation.Name = "btnProductInformation";
            this.btnProductInformation.Size = new System.Drawing.Size(242, 50);
            this.btnProductInformation.TabIndex = 4;
            this.btnProductInformation.Text = "Product Info";
            this.btnProductInformation.UseVisualStyleBackColor = false;
            this.btnProductInformation.Click += new System.EventHandler(this.btnProductInformation_Click);
            // 
            // btnPurchaseProduct
            // 
            this.btnPurchaseProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnPurchaseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseProduct.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseProduct.Location = new System.Drawing.Point(1182, 136);
            this.btnPurchaseProduct.Name = "btnPurchaseProduct";
            this.btnPurchaseProduct.Size = new System.Drawing.Size(242, 50);
            this.btnPurchaseProduct.TabIndex = 5;
            this.btnPurchaseProduct.Text = "Purchase ";
            this.btnPurchaseProduct.UseVisualStyleBackColor = false;
            this.btnPurchaseProduct.Click += new System.EventHandler(this.btnPurchaseProduct_Click);
            // 
            // lblNumberOfTransaction
            // 
            this.lblNumberOfTransaction.AutoSize = true;
            this.lblNumberOfTransaction.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfTransaction.Location = new System.Drawing.Point(254, 151);
            this.lblNumberOfTransaction.Name = "lblNumberOfTransaction";
            this.lblNumberOfTransaction.Size = new System.Drawing.Size(242, 35);
            this.lblNumberOfTransaction.TabIndex = 6;
            this.lblNumberOfTransaction.Text = "num of transactions";
            // 
            // frmPurchaseFromSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1489, 708);
            this.Controls.Add(this.lblNumberOfTransaction);
            this.Controls.Add(this.btnPurchaseProduct);
            this.Controls.Add(this.btnProductInformation);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.lblCurrentStockProduct);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pbProductImage);
            this.Name = "frmPurchaseFromSupplier";
            this.Text = "Purchase Operation";
            this.Load += new System.EventHandler(this.frmPurchaseFromSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCurrentStockProduct;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnProductInformation;
        private System.Windows.Forms.Button btnPurchaseProduct;
        private System.Windows.Forms.Label lblNumberOfTransaction;
    }
}