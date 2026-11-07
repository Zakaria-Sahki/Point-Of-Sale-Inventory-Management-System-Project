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
    public partial class frmAddEditCategory : Form
    {
        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _CategoryID = -1;
        public clsCategory Category;
        public frmAddEditCategory(int CategoryID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (CategoryID != -1)
            {

                _Mode = enMode.Update;
                _CategoryID = CategoryID;
            }
            else
            {

                _Mode = enMode.Add;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text.Trim()))
            {

                e.Cancel = true;
                txtCategoryName.Focus();
                errorProvider1.SetError(txtCategoryName, "Category Name Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtCategoryName, null);
            }
        }
        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Add)
            {

                lblTitle.Text = "Add New Category";
                this.Text = "Add New Category";
                Category = new clsCategory("", "");
                return;
            }

            lblTitle.Text = "Update Category";
            this.Text = "Update Category";

            Category = clsCategory.GetCategoryByID(_CategoryID);
            if (Category == null)
            {

                MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblCategoryID.Text = Category.CategoryID.ToString();
            txtCategoryName.Text = Category.CategoryName;
            txtCategoryDescription.Text = Category.CategoryDescription;
            cboxIsActive.Checked = Category.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text.Trim()))
            {

                MessageBox.Show("Category Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
                return;
            }

            Category.CategoryName = txtCategoryName.Text.Trim();
            Category.CategoryDescription = txtCategoryDescription.Text.Trim();
            Category.IsActive = cboxIsActive.Checked;

            if (Category.Save())
            {
                MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
