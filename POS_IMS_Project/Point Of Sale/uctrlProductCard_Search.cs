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
    public partial class uctrlProductCard_Search : UserControl
    {
        public clsProduct _Product;

        static public event Action OnProductSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void ProductSelected()
        {
            Action handler = OnProductSelected;
            if (handler != null)
            {
                handler(); // Raise the event with the parameter
            }
        }


        public uctrlProductCard_Search()
        {
            InitializeComponent();
        }
        public void DisplayProductInfo(int ProductID, string ProductSKU, string ProductUnitPrice, string ImagePath) {

            if (ImagePath == "")
            {

                pbProductImage.Image = POS_IMS_Project.Properties.Resources.no_image_available_icon;
            }
            else {

                pbProductImage.Image = Image.FromFile(ImagePath);
            }

            lblProductSKU.Text = ProductSKU;
            lblUnitPrice.Text = "DZD " + ProductUnitPrice;

            // Center the product name under the PictureBox
            lblProductSKU.Width = pbProductImage.Width;
            lblProductSKU.Left = pbProductImage.Left;
            lblProductSKU.TextAlign = ContentAlignment.MiddleCenter;

            // Center the price under the PictureBox
            lblUnitPrice.Width = pbProductImage.Width;
            lblUnitPrice.Left = pbProductImage.Left;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;

            _Product = clsProduct.GetProductByID(ProductID);
        }
        private void pbProductImage_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo(_Product.ProductID);
            frm.ShowDialog();
        }
        private void uctrlProductCard_Search_Click(object sender, EventArgs e)
        {
            uctrlPointOfSale.clsSelectedProducts Tem_Product =  uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _Product.ProductID);

            

            if (uctrlPointOfSale.CurrentSale.SelectedProducts.Any(p => p.ProductID == _Product.ProductID))
            {
                if (Tem_Product.ProductInfo.QuantityInStock < (Tem_Product.Quantity + 1))
                {
                    MessageBox.Show("This Quantity is not available in the stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                uctrlPointOfSale.CurrentSale.SelectedProducts.Where(p => p.ProductID == _Product.ProductID).FirstOrDefault().Quantity += 1;
            }
            else {

                uctrlPointOfSale.CurrentSale.SelectedProducts.Add(new uctrlPointOfSale.clsSelectedProducts
                (
                     _Product.ProductID,
                     _Product,
                     1
                ));
            }

            if (OnProductSelected != null) { 
                
                ProductSelected();
            }
        }
    }
}
