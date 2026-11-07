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
    public partial class frmFindBrand : Form
    {

        private enum enSearchMethod { ByID, ByName }
        private enSearchMethod _searchMethod = enSearchMethod.ByID;
        private clsBrands Brand;
        private int _BrandID = -1;

        public frmFindBrand()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadForm() {

            linklblEditBrand.Visible = false;
            cbSearchMethod.SelectedIndex = 0;
            txtSearch.Text = string.Empty;
            lblBrandID.Text = "[xxx]";
            lblBrandName.Text = "[xxx]";
            txtBrandDescription.Text = string.Empty;
            cboxIsActive.Checked = true;
            txtSearch.Focus();
        }
        private void frmFindBrand_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            if (cbSearchMethod.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

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


            if (txtSearch.Text.All(char.IsDigit) && _searchMethod == enSearchMethod.ByName)
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch, "Please enter a valid string Name not numbers.\"");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSearch, string.Empty);
            }

        }
        private void cbSearchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            switch (cbSearchMethod.SelectedIndex)
            {
                case 0:
                    _searchMethod = enSearchMethod.ByID;
                    break;
                case 1:
                    _searchMethod = enSearchMethod.ByName;
                    break;
                default:
                    _searchMethod = enSearchMethod.ByID;
                    break;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim())) {

                MessageBox.Show("Search Data required", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (_searchMethod == enSearchMethod.ByID) {

                Brand = clsBrands.GetBrandByID(Convert.ToInt32(txtSearch.Text.Trim()));
                
            }
            else if (_searchMethod == enSearchMethod.ByName)
            {
                Brand = clsBrands.GetBrandByName(txtSearch.Text.Trim());
            }



            if (Brand == null)
            {
                MessageBox.Show("Brand not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
                return;
            }
            _BrandID = Brand.BrandID;

            linklblEditBrand.Visible = true;
            lblBrandID.Text = Brand.BrandID.ToString();
            lblBrandName.Text = Brand.BrandName;
            txtBrandDescription.Text = Brand.BrandDescription;
            cboxIsActive.Checked = Brand.IsActive;
        }

        private void LoadDataAfterEditingBrand() {

            Brand = clsBrands.GetBrandByID(_BrandID);

            linklblEditBrand.Visible = true;
            lblBrandID.Text = Brand.BrandID.ToString();
            lblBrandName.Text = Brand.BrandName;
            txtBrandDescription.Text = Brand.BrandDescription;
            cboxIsActive.Checked = Brand.IsActive;
        }

        private void linklblEditBrand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditBrands frm = new frmAddEditBrands(_BrandID);
            frm.ShowDialog();
            LoadDataAfterEditingBrand();
        }
    }
}
