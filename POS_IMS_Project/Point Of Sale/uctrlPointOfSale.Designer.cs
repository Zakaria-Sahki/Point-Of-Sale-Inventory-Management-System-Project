namespace POS_IMS_Project
{
    partial class uctrlPointOfSale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpBasketItems = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderOfSelectedProducts = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linklblClearSelectedProduct = new System.Windows.Forms.LinkLabel();
            this.lblCountItems = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTotalDuePrice = new System.Windows.Forms.Label();
            this.lblTotalduePriceTitle = new System.Windows.Forms.Label();
            this.mainSearchProductPanel = new System.Windows.Forms.Panel();
            this.pnlSimpleFilterSearching = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pnlSearchForProduct = new System.Windows.Forms.Panel();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.pbSearchPicture = new System.Windows.Forms.PictureBox();
            this.txtSearchForProduct = new System.Windows.Forms.TextBox();
            this.flpProductCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.HeaderOfSelectedProducts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainSearchProductPanel.SuspendLayout();
            this.pnlSimpleFilterSearching.SuspendLayout();
            this.pnlSearchForProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flpBasketItems);
            this.panel1.Controls.Add(this.HeaderOfSelectedProducts);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1149, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 836);
            this.panel1.TabIndex = 0;
            // 
            // flpBasketItems
            // 
            this.flpBasketItems.AutoScroll = true;
            this.flpBasketItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBasketItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBasketItems.Location = new System.Drawing.Point(0, 100);
            this.flpBasketItems.Name = "flpBasketItems";
            this.flpBasketItems.Size = new System.Drawing.Size(459, 434);
            this.flpBasketItems.TabIndex = 5;
            // 
            // HeaderOfSelectedProducts
            // 
            this.HeaderOfSelectedProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderOfSelectedProducts.Controls.Add(this.label1);
            this.HeaderOfSelectedProducts.Controls.Add(this.linklblClearSelectedProduct);
            this.HeaderOfSelectedProducts.Controls.Add(this.lblCountItems);
            this.HeaderOfSelectedProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderOfSelectedProducts.Location = new System.Drawing.Point(0, 0);
            this.HeaderOfSelectedProducts.Name = "HeaderOfSelectedProducts";
            this.HeaderOfSelectedProducts.Size = new System.Drawing.Size(459, 100);
            this.HeaderOfSelectedProducts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Basket:";
            // 
            // linklblClearSelectedProduct
            // 
            this.linklblClearSelectedProduct.AutoSize = true;
            this.linklblClearSelectedProduct.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblClearSelectedProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblClearSelectedProduct.LinkColor = System.Drawing.Color.Red;
            this.linklblClearSelectedProduct.Location = new System.Drawing.Point(379, 57);
            this.linklblClearSelectedProduct.Name = "linklblClearSelectedProduct";
            this.linklblClearSelectedProduct.Size = new System.Drawing.Size(53, 24);
            this.linklblClearSelectedProduct.TabIndex = 2;
            this.linklblClearSelectedProduct.TabStop = true;
            this.linklblClearSelectedProduct.Text = "Clear";
            this.linklblClearSelectedProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblClearSelectedProduct_LinkClicked);
            // 
            // lblCountItems
            // 
            this.lblCountItems.AutoSize = true;
            this.lblCountItems.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountItems.Location = new System.Drawing.Point(28, 57);
            this.lblCountItems.Name = "lblCountItems";
            this.lblCountItems.Size = new System.Drawing.Size(83, 24);
            this.lblCountItems.TabIndex = 1;
            this.lblCountItems.Text = "0 Item(s)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnHold);
            this.panel2.Controls.Add(this.btnDraft);
            this.panel2.Controls.Add(this.btnCompleteSale);
            this.panel2.Controls.Add(this.lblTotalDuePrice);
            this.panel2.Controls.Add(this.lblTotalduePriceTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 300);
            this.panel2.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(304, 205);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 51);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Location = new System.Drawing.Point(162, 205);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(128, 51);
            this.btnHold.TabIndex = 3;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.Color.White;
            this.btnDraft.Location = new System.Drawing.Point(20, 205);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(128, 51);
            this.btnDraft.TabIndex = 2;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = false;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.Location = new System.Drawing.Point(20, 134);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(412, 51);
            this.btnCompleteSale.TabIndex = 1;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // lblTotalDuePrice
            // 
            this.lblTotalDuePrice.AutoSize = true;
            this.lblTotalDuePrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDuePrice.Location = new System.Drawing.Point(289, 75);
            this.lblTotalDuePrice.Name = "lblTotalDuePrice";
            this.lblTotalDuePrice.Size = new System.Drawing.Size(133, 35);
            this.lblTotalDuePrice.TabIndex = 1;
            this.lblTotalDuePrice.Text = "DZD 00.00";
            // 
            // lblTotalduePriceTitle
            // 
            this.lblTotalduePriceTitle.AutoSize = true;
            this.lblTotalduePriceTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalduePriceTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTotalduePriceTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTotalduePriceTitle.Name = "lblTotalduePriceTitle";
            this.lblTotalduePriceTitle.Size = new System.Drawing.Size(148, 39);
            this.lblTotalduePriceTitle.TabIndex = 0;
            this.lblTotalduePriceTitle.Text = "Total due:";
            // 
            // mainSearchProductPanel
            // 
            this.mainSearchProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSearchProductPanel.Controls.Add(this.pnlSimpleFilterSearching);
            this.mainSearchProductPanel.Controls.Add(this.pnlSearchForProduct);
            this.mainSearchProductPanel.Controls.Add(this.flpProductCards);
            this.mainSearchProductPanel.Location = new System.Drawing.Point(18, 17);
            this.mainSearchProductPanel.Name = "mainSearchProductPanel";
            this.mainSearchProductPanel.Size = new System.Drawing.Size(1110, 834);
            this.mainSearchProductPanel.TabIndex = 1;
            // 
            // pnlSimpleFilterSearching
            // 
            this.pnlSimpleFilterSearching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSimpleFilterSearching.Controls.Add(this.label3);
            this.pnlSimpleFilterSearching.Controls.Add(this.cbBrand);
            this.pnlSimpleFilterSearching.Controls.Add(this.cbCategory);
            this.pnlSimpleFilterSearching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSimpleFilterSearching.Location = new System.Drawing.Point(0, 100);
            this.pnlSimpleFilterSearching.Name = "pnlSimpleFilterSearching";
            this.pnlSimpleFilterSearching.Size = new System.Drawing.Size(1108, 92);
            this.pnlSimpleFilterSearching.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter:";
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(612, 26);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(418, 37);
            this.cbBrand.TabIndex = 4;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(137, 26);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(418, 37);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // pnlSearchForProduct
            // 
            this.pnlSearchForProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchForProduct.Controls.Add(this.cbFilterType);
            this.pnlSearchForProduct.Controls.Add(this.pbSearchPicture);
            this.pnlSearchForProduct.Controls.Add(this.txtSearchForProduct);
            this.pnlSearchForProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchForProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchForProduct.Name = "pnlSearchForProduct";
            this.pnlSearchForProduct.Size = new System.Drawing.Size(1108, 100);
            this.pnlSearchForProduct.TabIndex = 1;
            // 
            // cbFilterType
            // 
            this.cbFilterType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "All",
            "By Brand",
            "By Category"});
            this.cbFilterType.Location = new System.Drawing.Point(798, 32);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(232, 37);
            this.cbFilterType.TabIndex = 2;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // pbSearchPicture
            // 
            this.pbSearchPicture.Image = global::POS_IMS_Project.Properties.Resources.icons8_search_40;
            this.pbSearchPicture.Location = new System.Drawing.Point(17, 32);
            this.pbSearchPicture.Name = "pbSearchPicture";
            this.pbSearchPicture.Size = new System.Drawing.Size(37, 37);
            this.pbSearchPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchPicture.TabIndex = 1;
            this.pbSearchPicture.TabStop = false;
            // 
            // txtSearchForProduct
            // 
            this.txtSearchForProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchForProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchForProduct.Location = new System.Drawing.Point(79, 32);
            this.txtSearchForProduct.Name = "txtSearchForProduct";
            this.txtSearchForProduct.Size = new System.Drawing.Size(690, 37);
            this.txtSearchForProduct.TabIndex = 0;
            this.txtSearchForProduct.TextChanged += new System.EventHandler(this.txtSearchForProduct_TextChanged);
            // 
            // flpProductCards
            // 
            this.flpProductCards.AutoScroll = true;
            this.flpProductCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpProductCards.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpProductCards.Location = new System.Drawing.Point(0, 192);
            this.flpProductCards.Name = "flpProductCards";
            this.flpProductCards.Size = new System.Drawing.Size(1108, 640);
            this.flpProductCards.TabIndex = 0;
            // 
            // uctrlPointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.mainSearchProductPanel);
            this.Controls.Add(this.panel1);
            this.Name = "uctrlPointOfSale";
            this.Size = new System.Drawing.Size(1625, 865);
            this.Load += new System.EventHandler(this.uctrlPointOfSale_Load);
            this.panel1.ResumeLayout(false);
            this.HeaderOfSelectedProducts.ResumeLayout(false);
            this.HeaderOfSelectedProducts.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainSearchProductPanel.ResumeLayout(false);
            this.pnlSimpleFilterSearching.ResumeLayout(false);
            this.pnlSimpleFilterSearching.PerformLayout();
            this.pnlSearchForProduct.ResumeLayout(false);
            this.pnlSearchForProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklblClearSelectedProduct;
        private System.Windows.Forms.Label lblCountItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel HeaderOfSelectedProducts;
        private System.Windows.Forms.Label lblTotalduePriceTitle;
        private System.Windows.Forms.Label lblTotalDuePrice;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Panel mainSearchProductPanel;
        private System.Windows.Forms.FlowLayoutPanel flpProductCards;
        private System.Windows.Forms.Panel pnlSearchForProduct;
        private System.Windows.Forms.Panel pnlSimpleFilterSearching;
        private System.Windows.Forms.TextBox txtSearchForProduct;
        private System.Windows.Forms.PictureBox pbSearchPicture;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpBasketItems;
        private System.Windows.Forms.Button btnPrint;
    }
}
