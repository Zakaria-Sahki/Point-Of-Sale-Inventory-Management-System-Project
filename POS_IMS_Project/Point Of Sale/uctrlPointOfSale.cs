using POS_IMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_IMS_Project
{
    public partial class uctrlPointOfSale : UserControl
    {
        //static public event Action OnBasketItemsChanged;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void BasketItemsChanged()
        //{
        //    Action handler = OnBasketItemsChanged;
        //    if (handler != null)
        //    {
        //        handler(); // Raise the event with the parameter
        //    }
        //}

        public class clsSelectedProducts { 
        
            public int ProductID { get; set; }
            public clsProduct ProductInfo { get; set; }
            public int Quantity { get; set; } = 0;

            public clsSelectedProducts(int productId, clsProduct productInfo, int quantity)
            {
                ProductID = productId;
                ProductInfo = productInfo;
                Quantity = quantity;
            }
        }
        
        //static public BindingList<clsSelectedProducts> SelectedProductsList = new BindingList<clsSelectedProducts>();  
        public class clsSaleBasket
        {
            public int SaleID { get; set; }
            public List<clsSelectedProducts> SelectedProducts { get; set; }
            public decimal TotalAmount { get; set; }
            public DateTime DateOfDraft { get; set; }
            public clsSaleBasket(int saleId, List<clsSelectedProducts> selectedProducts, decimal totalAmount)
            {
                SaleID = saleId;
                SelectedProducts = selectedProducts;
                TotalAmount = totalAmount;
                DateOfDraft = DateTime.Now;
            }
        }
        
        static public List<clsSaleBasket> drafts = new List<clsSaleBasket>();

        static public clsSaleBasket CurrentSale = new clsSaleBasket(1, new List<clsSelectedProducts>(), 0);






        public uctrlPointOfSale()
        {
            InitializeComponent();
        }
        private void _FillComboBoxUsedHere()
        {

            DataTable Categories = clsCategory.GetAllCategories();

            foreach (DataRow Category in Categories.Rows)
            {

                cbCategory.Items.Add(Category["CategoryName"]);
            }

            cbCategory.SelectedIndex = 0;

            DataTable Brands = clsBrands.GetAllBrands();

            foreach (DataRow Brand in Brands.Rows)
            {
                cbBrand.Items.Add(Brand["BrandName"]);
            }

            cbBrand.SelectedIndex = 0;
        }
        private void _FillFlowLayoutPanelWithProducts()
        {
            flpProductCards.Controls.Clear();
            DataTable Products = clsProduct.GetAllProducts();
            foreach (DataRow Product in Products.Rows)
            {
                uctrlProductCard_Search productControl = new uctrlProductCard_Search();
                productControl.DisplayProductInfo(Convert.ToInt32(Product["ProductID"]), Product["SKU"].ToString(), Convert.ToDecimal(Product["SellPrice"]).ToString("F2"), Product["ImagePath"].ToString());
                if (productControl._Product.QuantityInStock == 0) {

                    productControl.BackColor = Color.FromArgb(233, 126, 116);
                    productControl.Enabled = false;
                }
                flpProductCards.Controls.Add(productControl);
            }
        }
        private void uctrlPointOfSale_Load(object sender, EventArgs e)
        {
            
            cbFilterType.SelectedIndex = 0;
            _FillComboBoxUsedHere();
            _FillFlowLayoutPanelWithProducts();
            uctrlProductCard_Search.OnProductSelected += BasketLengthChanged_Check;
            uctrlProductCard_Selected.OnProductSelected += BasketLengthChanged_Check;
        }
        public void BasketLengthChanged_Check() {

            DisplayBasketItems();
        }
        public void DisplayBasketItems() {

            flpBasketItems.Controls.Clear();
            foreach (clsSelectedProducts Product in CurrentSale.SelectedProducts)
            {
                uctrlProductCard_Selected productControl = new uctrlProductCard_Selected();
                productControl.DisplayProductInfo(Product.ProductInfo.ProductName, Product.ProductInfo.SellPrice, Product.Quantity, Product.ProductInfo);
                flpBasketItems.Controls.Add(productControl);
            }

            CurrentSale.TotalAmount = CurrentSale.SelectedProducts.Sum(p => p.ProductInfo.SellPrice * p.Quantity);
            lblCountItems.Text = CurrentSale.SelectedProducts.Count.ToString() + " Item(s)";
            lblTotalDuePrice.Text =  "DZD " + CurrentSale.SelectedProducts.Sum(p => p.ProductInfo.SellPrice * p.Quantity).ToString("F2");
            lblTotalDuePrice.Left = flpBasketItems.Width - lblTotalDuePrice.Width - 30;
        }
        
        
        
        
        
        private void txtSearchForProduct_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = txtSearchForProduct.Text.Trim().ToLower();

            // Suspend layout to prevent flickering while changing visibility
            flpProductCards.SuspendLayout();

            int visibleCount = 0;

            foreach (Control control in flpProductCards.Controls)
            {
                // Ensure we are checking a product control
                if (control is uctrlProductCard_Search productCard)
                {
                    // Check if the barcode or SKU matches the search query (case-insensitive)
                    bool isMatch = string.IsNullOrEmpty(searchQuery) ||
                                   productCard._Product.BarCode.ToLower().Contains(searchQuery) ||
                                   productCard._Product.SKU.ToLower().Contains(searchQuery);

                    // Show or hide the product card based on the match
                    productCard.Visible = isMatch;

                    if (isMatch)
                    {
                        visibleCount++;
                    }
                }
            }

            flpProductCards.ResumeLayout();
        }
        private void linklblClearSelectedProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentSale.SelectedProducts.Clear();
            DisplayBasketItems();
        }
        
        
        
        
        
        
        
        
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbCategory.SelectedIndex == 0) { 
                
                _FillFlowLayoutPanelWithProducts();
                return; 
            }

            flpProductCards.Controls.Clear();
            DataTable Products = clsProduct.GetAllProducts();
            foreach (DataRow Product in Products.Rows)
            {

                if (Convert.ToInt32(Product["CategoryID_FK"]) == clsCategory.GetCategoryByCategoryName(cbCategory.Text).CategoryID) {


                    uctrlProductCard_Search productControl = new uctrlProductCard_Search();
                    productControl.DisplayProductInfo(Convert.ToInt32(Product["ProductID"]), Product["SKU"].ToString(), Convert.ToDecimal(Product["SellPrice"]).ToString("F2"), Product["ImagePath"].ToString());
                    flpProductCards.Controls.Add(productControl);
                }
            }
        }
        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex == 0)
            {

                _FillFlowLayoutPanelWithProducts();
                return;
            }

            flpProductCards.Controls.Clear();
            DataTable Products = clsProduct.GetAllProducts();
            foreach (DataRow Product in Products.Rows)
            {

                if (Convert.ToInt32(Product["BrandID_FK"]) == clsBrands.GetBrandByName(cbBrand.Text).BrandID)
                {


                    uctrlProductCard_Search productControl = new uctrlProductCard_Search();
                    productControl.DisplayProductInfo(Convert.ToInt32(Product["ProductID"]), Product["SKU"].ToString(), Convert.ToDecimal(Product["SellPrice"]).ToString("F2"), Product["ImagePath"].ToString());
                    flpProductCards.Controls.Add(productControl);
                }
            }
        }
        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbFilterType.Text == "All") { 
                
                _FillFlowLayoutPanelWithProducts();
                cbCategory.Enabled = false;
                cbBrand.Enabled = false;
                
            }

            else if (cbFilterType.Text == "By Category") { 
                
                cbCategory.Enabled = true;
                cbBrand.Enabled = false;
            }
            else if (cbFilterType.Text == "By Brand") { 
                
                cbCategory.Enabled = false;
                cbBrand.Enabled = true;
            }
            else
            {
                _FillFlowLayoutPanelWithProducts();
                cbCategory.Enabled = false;
                cbBrand.Enabled = false;
            }

            cbBrand.Text = string.Empty;
            cbCategory.Text = string.Empty;
            cbBrand.SelectedText = "None";
            cbCategory.SelectedText = "None";
        }
        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

            if (CurrentSale.SelectedProducts.Count == 0) {
                return;
            }

            
            // For demo perops I put a user id hardcoded
            int SaleID = clsSaleInvoice.LogSaleInvoice(-1, 2, CurrentSale.TotalAmount);
            if (SaleID > 0) {

                foreach (clsSelectedProducts Product in CurrentSale.SelectedProducts) {

                    if (!clsTransactionOperations.LogNewSaleTransaction(SaleID, Product.ProductInfo.ProductID, Product.Quantity, Product.ProductInfo.SellPrice, 2)) {

                        MessageBox.Show("Data failed to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            CurrentSale.SaleID = 1;
            CurrentSale.TotalAmount = 0;
            CurrentSale.SelectedProducts.Clear();
            DisplayBasketItems();
            _FillFlowLayoutPanelWithProducts();
        }
        private void btnHold_Click(object sender, EventArgs e)
        {

            if (CurrentSale.SelectedProducts.Count == 0) {

                MessageBox.Show("The basket is empty so you can not Save a draft.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            drafts.Add(new clsSaleBasket(CurrentSale.SaleID, new List<clsSelectedProducts>(CurrentSale.SelectedProducts), CurrentSale.SelectedProducts.Sum(p => p.ProductInfo.SellPrice * p.Quantity)));
            CurrentSale = new clsSaleBasket(drafts.Count + 1, new List<clsSelectedProducts>(), 0);
            DisplayBasketItems();
        }
        private void btnDraft_Click(object sender, EventArgs e)
        {
            frmDraftScreen frmDraft = new frmDraftScreen();
            frmDraft.ShowDialog();
            DisplayBasketItems();
        }
    }
}
