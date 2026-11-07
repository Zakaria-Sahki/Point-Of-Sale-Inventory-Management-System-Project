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
    public partial class uctrlProductInfo : UserControl
    {
        private clsProduct _Product;

        public uctrlProductInfo()
        {
            InitializeComponent();
        }

        public void DefaultValue() {

            lblProductID.Text = "[xxx]";
            lblProductName.Text = "[xxx]";
            lblSKU.Text = "[xxx]";
            lblBarCode.Text = "[xxx]";
            lblSellPrice.Text = "[xxx]";
            lblPurchasePrice.Text = "[xxx]";
            lblQuantityInStock.Text = "[xxx]";
            lblMinimumStock.Text = "[xxx]";
            lblBrand.Text = "[xxx]";
            lblCategory.Text = "[xxx]";
            cboxIsActive.Checked = true;
            linklblEditProduct.Visible = false;
        }

        public void DisplayProductInfo(int ProductID) { 
            
            _Product = clsProduct.GetProductByID(ProductID);

            if (_Product == null) { 
                
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultValue();
                return;
            }

            linklblEditProduct.Visible = true;
            lblProductID.Text = _Product.ProductID.ToString();
            lblProductName.Text = _Product.ProductName;
            lblSKU.Text = _Product.SKU;
            lblBarCode.Text = _Product.BarCode;
            lblSellPrice.Text = _Product.SellPrice.ToString("C2");
            lblPurchasePrice.Text = _Product.PurchasePrice.ToString("C2");
            lblQuantityInStock.Text = _Product.QuantityInStock.ToString();
            lblMinimumStock.Text = _Product.MinimumStock.ToString();
            lblCategory.Text = _Product.CategoryInfo.CategoryName;
            lblBrand.Text = _Product.BrandInfo.BrandName;
            cboxIsActive.Checked = _Product.IsActive;

            if (_Product.ImagePath != "") { 
                
                try
                {
                    pbProductPicture.Image = Image.FromFile(_Product.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbProductPicture.Image = null;
                }
            }
            else
            {
                pbProductPicture.Image = POS_IMS_Project.Properties.Resources.no_image_available_icon;
            }
        }

        private void linklblEditProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(_Product.ProductID);
            frm.ShowDialog();
            DisplayProductInfo(_Product.ProductID);
        }

    }
}
