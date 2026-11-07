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
    public partial class frmFindCategory : Form
    {
        private enum enSearchMethod { ByID, ByName }
        private enSearchMethod _searchMethod = enSearchMethod.ByID;
        private clsCategory Category;
        private int _CategoryID = -1;

        public frmFindCategory()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoadForm()
        {
            uctrlCategoryInfo1.RefereshToDefaultValues();
            cbSearchMethod.SelectedIndex = 0;
            txtSearch.Text = string.Empty;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            if (cbSearchMethod.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void frmFindCategory_Load(object sender, EventArgs e)
        {
            LoadForm();
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
            if (_searchMethod == enSearchMethod.ByID)
            {

                Category = clsCategory.GetCategoryByID(Convert.ToInt32(txtSearch.Text.Trim()));

            }
            else if (_searchMethod == enSearchMethod.ByName)
            {
                Category = clsCategory.GetCategoryByCategoryName(txtSearch.Text.Trim());
            }



            if (Category == null)
            {
                MessageBox.Show("Category not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
                return;
            }
            _CategoryID = Category.CategoryID;  
            uctrlCategoryInfo1.DisplayCategoryInfoByID(_CategoryID);
        }
    }
}
