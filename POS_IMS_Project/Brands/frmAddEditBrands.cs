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
    public partial class frmAddEditBrands : Form
    {

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _BrandID = -1;
        public clsBrands Brand;

        public frmAddEditBrands(int BrandID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (BrandID != -1) {

                _Mode = enMode.Update;
                _BrandID = BrandID;
            }
            else { 
                
                _Mode = enMode.Add;
            }

        }
        private void frmAddEditBrands_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.Add) {
                
                lblTitle.Text = "Add New Brand";
                this.Text = "Add New Brand";
                Brand = new clsBrands("", "", true);
                return;
            }

            lblTitle.Text = "Update Brand";
            this.Text = "Update Brand";

            Brand = clsBrands.GetBrandByID(_BrandID);
            if (Brand == null) { 
                
                MessageBox.Show("Brand not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblBrandID.Text = Brand.BrandID.ToString();
            txtBrandName.Text = Brand.BrandName;
            txtBrandDescription.Text = Brand.BrandDescription;
            cboxIsActive.Checked = Brand.IsActive;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBrandName.Text.Trim()))
            {

                MessageBox.Show("Brand Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBrandName.Focus();
                return;
            }

            Brand.BrandName = txtBrandName.Text.Trim();
            Brand.BrandDescription = txtBrandDescription.Text.Trim();
            Brand.IsActive = cboxIsActive.Checked;

            if (Brand.Save())
            {
                MessageBox.Show("Brand saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBrandName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrandName.Text.Trim()))
            {

                e.Cancel = true;
                txtBrandName.Focus();
                errorProvider1.SetError(txtBrandName, "Brand Name Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtBrandName, null);
            }
        }
    }
}
