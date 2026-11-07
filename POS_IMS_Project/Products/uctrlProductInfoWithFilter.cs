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
    public partial class uctrlProductInfoWithFilter : UserControl
    {
        private enum enSearchMethod { ByID, ByName, byBarCode, bySKU }
        private enSearchMethod _searchMethod = enSearchMethod.ByID;
        private clsProduct _product;

        public uctrlProductInfoWithFilter()
        {
            InitializeComponent();
        }

        private void DefaultValues() {

            uctrlProductInfo1.DefaultValue();
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    _searchMethod = enSearchMethod.ByID;
                    break;
                case 1:
                    _searchMethod = enSearchMethod.ByName;
                    break;
                case 2:
                    _searchMethod = enSearchMethod.byBarCode;
                    break;
                case 3:
                    _searchMethod = enSearchMethod.bySKU;
                    break;
                default:
                    _searchMethod = enSearchMethod.ByID;
                    break;
            }
            txtSearch.Focus();
        }
        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch, "Please enter a search term.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSearch, string.Empty);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            if (cbFilterBy.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void FindTheProduct() {

            switch (_searchMethod) {

                case enSearchMethod.ByID:
                    _product = clsProduct.GetProductByID(Convert.ToInt32(txtSearch.Text.Trim()));
                    break;
                case enSearchMethod.ByName:
                    _product = clsProduct.GetProductByName(txtSearch.Text.Trim());
                    break;
                case enSearchMethod.byBarCode:
                    _product = clsProduct.GetProductByBarCode(txtSearch.Text.Trim());
                    break;
                case enSearchMethod.bySKU:
                    _product = clsProduct.GetProductBySKU(txtSearch.Text.Trim());
                    break;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {

                MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DefaultValues();
                return;
            }

            FindTheProduct();

            if (_product == null)
            {
                MessageBox.Show("Product not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefaultValues();
                return;
            }

            uctrlProductInfo1.DisplayProductInfo(_product.ProductID);
        }
        private void uctrlProductInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            _searchMethod = enSearchMethod.ByID;
            DefaultValues();
        }
    }
}
