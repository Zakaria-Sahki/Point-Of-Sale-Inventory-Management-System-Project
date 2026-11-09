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
    public partial class frmPurchaseOperation : Form
    {
        private int _productID;
        private clsProduct _product;

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
            lblUnitPrice.Text = "DZD " + _product.PurchasePrice.ToString("N2",
            System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPurchaseInfo;
        }
    }
}
