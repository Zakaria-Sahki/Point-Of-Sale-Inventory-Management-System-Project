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
    public partial class uctrlProductCard_Selected : UserControl
    {

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

        private string _ProductName;
        private decimal _UnitPrice;
        private int _Quantity;
        private clsProduct _ProductInfo;

        public uctrlProductCard_Selected()
        {
            InitializeComponent();
        }

        public void DisplayProductInfo(string ProductName, decimal UnitPrice, int Quantity, clsProduct ProductInfo)
        {

            lblProductName.Text = ProductName;
            lblUnitPrice.Text = "DZD " + UnitPrice.ToString("F2");
            txtQuantity.Text = Quantity.ToString();

            _ProductName = ProductName;
            _UnitPrice = UnitPrice;
            _Quantity = Quantity;
            _ProductInfo = ProductInfo;
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            uctrlPointOfSale.clsSelectedProducts Tem_Product = uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _ProductInfo.ProductID);

            if (Tem_Product.ProductInfo.QuantityInStock < (Tem_Product.Quantity + 1)) {


                MessageBox.Show("This Quantity is not available in the stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtQuantity.Text = (Convert.ToInt32(txtQuantity.Text) + 1).ToString();
            //_Quantity++;
            uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _ProductInfo.ProductID).Quantity++;

            if (OnProductSelected != null)
            {
                ProductSelected();
            }
        }
        private void btnDeacrease_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = (Convert.ToInt32(txtQuantity.Text) - 1).ToString();
            //_Quantity--;
            uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _ProductInfo.ProductID).Quantity--;

            if (OnProductSelected != null)
            {
                ProductSelected();
            }
        }

        private void uctrlProductCard_Selected_Click(object sender, EventArgs e)
        {
            //if (e == MouseButtons.Right)
            //{
            //    MessageBox.Show("Right-clicked at coordinates: " + e.Location);
            //}
        }

        private void uctrlProductCard_Selected_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Are you sure you want to remove this product?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    
                    uctrlPointOfSale.CurrentSale.SelectedProducts.Remove(uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _ProductInfo.ProductID));
                    if (OnProductSelected != null)
                    {
                        ProductSelected();
                    }
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                uctrlPointOfSale.CurrentSale.SelectedProducts.FirstOrDefault(p => p.ProductInfo.ProductID == _ProductInfo.ProductID).Quantity = Convert.ToInt32(txtQuantity.Text);
                if (OnProductSelected != null)
                {
                    ProductSelected();
                }
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-' && txtQuantity.SelectionStart == 0 && !txtQuantity.Text.Contains("-"));
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                e.Cancel = true;
                txtQuantity.Focus();
                errorProvider1.SetError(txtQuantity, "Please enter a quantity.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtQuantity, string.Empty);
            }
        }
    }
}
