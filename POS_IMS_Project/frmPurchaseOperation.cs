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
using static POS_IMS_Project.uctrlPointOfSale;

namespace POS_IMS_Project
{
    public partial class frmPurchaseOperation : Form
    {
        private int _productID;
        private clsProduct _product;
        private int _SupplierID = -1;
        private clsSuppliers _supplier;
        private decimal TotalAmount = 0;
        private int _quantityToRecive;
        private decimal _unitPrice;

        public frmPurchaseOperation(int ProductID)
        {
            InitializeComponent();
            this.Size = new Size(750, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            _productID = ProductID;
        }

        private void frmPurchaseOperation_Load(object sender, EventArgs e)
        {
            _product = clsProduct.GetProductByID(_productID);
            if (_product == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            
            lblProductName.Text = _product.ProductName;
            txtQuantityReceive.Enabled = false;
            txtUnitPrice.Enabled = false;
            tbPurchaseInfo.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPurchaseInfo;
        }

        private void txtQuantityReceive_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtQuantityReceive.Text))
            {
                TotalAmount = 0;
                lblTotalPrice.Text = "DZD 0.00";
                return;
            }
            else {

                _quantityToRecive = int.Parse(txtQuantityReceive.Text);
                TotalAmount = _unitPrice * _quantityToRecive;
                lblTotalPrice.Text = "DZD " + TotalAmount.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
        }
        private void txtQuantityReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQuantityReceive_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtQuantityReceive.Text))
            //{

            //    e.Cancel = true;
            //    txtQuantityReceive.Focus();
            //    errorProvider1.SetError(txtQuantityReceive, "Quantity to Receive Required!");
            //    return;
            //}
            //else
            //{

            //    errorProvider1.SetError(txtQuantityReceive, null);
            //}
        }
        private void uctrlFindSupplier1_OnSupplierSelected(int obj)
        {
            _SupplierID = obj;
            
            _supplier = clsSuppliers.GetSupplierByID(_SupplierID);
            if (_supplier == null) { 
            
                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _SupplierID = -1;
                txtQuantityReceive.Enabled = false;
                tbPurchaseInfo.Enabled = false;
                txtUnitPrice.Enabled = false;
                return;
            }

            uctrlFindSupplier1.DisableControls();
            txtQuantityReceive.Enabled = true;
            tbPurchaseInfo.Enabled = true;
            txtUnitPrice.Enabled = true;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text.Trim()))
            {

                MessageBox.Show("Please enter the unit price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuantityReceive.Text.Trim())) { 
                
                MessageBox.Show("Please enter the quantity to receive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int PurchaseID = clsPurchaseInvoice.LogPurchaseInvoice(_SupplierID, 2, TotalAmount);
            if (PurchaseID > 0)
            {
                if (!clsTransactionOperations.LogNewPurchaseTransaction(PurchaseID, _product.ProductID, 2, _product.PurchasePrice, 2))
                {

                    MessageBox.Show("Data failed to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }  
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                _unitPrice = 0;
                lblTotalPrice.Text = "DZD 0.00";
                return;
            }
            else
            {

                _unitPrice = decimal.TryParse(txtUnitPrice.Text, out decimal price) ? price : 0;
                TotalAmount = _unitPrice * _quantityToRecive;
                lblTotalPrice.Text = "DZD " + TotalAmount.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
        }
    }
}
