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
using System.IO;


namespace POS_IMS_Project
{
    public partial class frmAddEditProduct : Form
    {

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _ProductID = -1;
        private clsProduct _Product;

        public frmAddEditProduct(int ProductID)
        {
            InitializeComponent();
            if (ProductID != -1) {

                _Mode = enMode.Update;
                _ProductID = ProductID;
            }
            else
            {
                _Mode = enMode.Add;
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(930, 500);
        }

        private void _FillComboBoxUsedHere() {

            DataTable Categories = clsCategory.GetAllCategories();

            foreach (DataRow Category in Categories.Rows) {

                cbCategory.Items.Add(Category["CategoryName"]);
            }

            cbCategory.SelectedIndex = 0;

            DataTable Brands = clsBrands.GetAllBrands();

            foreach (DataRow Brand in Brands.Rows)
            {
                cbBrand.Items.Add(Brand["BrandName"]);
            }

            cbBrand.SelectedIndex = 0;
        }
        private void DefaultForm() {

            lblProductID.Text = "[xxx]";
            lblQuantityInStock.Text = "[xxx]";
            cboxIsActive.Checked = true;
            pbProductPicture.Image = POS_IMS_Project.Properties.Resources.no_image_available_icon;
            linklblRemovePicture.Visible = false;
            txtProductName.Text = string.Empty;
            txtBarCode.Text = string.Empty;
            txtSKU.Text = string.Empty;
            txtSellPrice.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            txtMinimumStock.Text = string.Empty;
            _FillComboBoxUsedHere();
        }
        private void LoadForm() {

            DefaultForm();

            if (_Mode == enMode.Add) {

                lblTitle.Text = "Add New Product";
                this.Text = "Add New Product";
                _Product = new clsProduct("", "", "", 0, 0, 0, "", 0, 0, true);
                return;
            }

            _Product = clsProduct.GetProductByID(_ProductID);

            if (_Product == null)
            {

                MessageBox.Show("Product with this ID not Found", "Not Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            lblTitle.Text = "Edit Product";
            this.Text = "Edit Product";
            lblProductID.Text = _Product.ProductID.ToString();
            lblQuantityInStock.Text = _Product.QuantityInStock.ToString();
            txtProductName.Text = _Product.ProductName;
            txtBarCode.Text = _Product.BarCode;
            txtSKU.Text = _Product.SKU;
            txtSellPrice.Text = _Product.SellPrice.ToString();
            txtPurchasePrice.Text = _Product.PurchasePrice.ToString();
            txtMinimumStock.Text = _Product.MinimumStock.ToString();
            cboxIsActive.Checked = _Product.IsActive;
            cbCategory.SelectedIndex = cbCategory.FindString(_Product.CategoryInfo.CategoryName);
            cbBrand.SelectedIndex = cbBrand.FindString(_Product.BrandInfo.BrandName);
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linklblSetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Open";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string SelectedFilePath = openFileDialog1.FileName;
                pbProductPicture.ImageLocation = SelectedFilePath;
                linklblRemovePicture.Visible = true;
            }
        }
        private void linklblRemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbProductPicture.ImageLocation = null;
            pbProductPicture.Image = POS_IMS_Project.Properties.Resources.no_image_available_icon;
            linklblRemovePicture.Visible = false;
        }
        private void txtProductName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {

                e.Cancel = true;
                txtProductName.Focus();
                errorProvider1.SetError(txtProductName, "Product Name Required!");
                return;
            }
            else {

                errorProvider1.SetError(txtProductName, null);
            }
        }
        private void txtBarCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarCode.Text))
            {

                e.Cancel = true;
                txtBarCode.Focus();
                errorProvider1.SetError(txtBarCode, "BarCode Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtBarCode, null);
            }
        }
        private void txtSellPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSellPrice.Text))
            {

                e.Cancel = true;
                txtSellPrice.Focus();
                errorProvider1.SetError(txtSellPrice, "Sell Price Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtSellPrice, null);
            }


            if (Convert.ToDecimal(txtSellPrice.Text.Trim()) < Convert.ToDecimal(txtPurchasePrice.Text.Trim())) { 
                
                e.Cancel = true;
                txtSellPrice.Focus();
                errorProvider1.SetError(txtSellPrice, "Sell Price cannot be less than Purchase Price!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSellPrice, null);

            }
        }
        private void txtPurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurchasePrice.Text))
            {

                e.Cancel = true;
                txtPurchasePrice.Focus();
                errorProvider1.SetError(txtPurchasePrice, "Purchase Price Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtPurchasePrice, null);
            }
        }
        private void txtMinimumStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMinimumStock.Text))
            {

                e.Cancel = true;
                txtMinimumStock.Focus();
                errorProvider1.SetError(txtMinimumStock, "Minimum Stock Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtMinimumStock, null);
            }
        }







        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits and thee ',' and '.'
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }
        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits and thee ',' and '.'
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }
        private void txtMinimumStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private bool ValideInputs() { 
            
            return (string.IsNullOrWhiteSpace(txtProductName.Text.Trim())) 
                    || (string.IsNullOrWhiteSpace(txtBarCode.Text.Trim())) 
                    || (string.IsNullOrWhiteSpace(txtSellPrice.Text.Trim())) 
                    || (string.IsNullOrWhiteSpace(txtPurchasePrice.Text.Trim())) 
                    || (string.IsNullOrWhiteSpace(txtMinimumStock.Text.Trim()));
        }

        private bool _HandleProductImage()
        {

            if (_Product.ImagePath != pbProductPicture.ImageLocation)
            {

                if (_Product.ImagePath != "")
                {
                    try
                    {

                        File.Delete(_Product.ImagePath);
                    }
                    catch (IOException IOEx)
                    {

                        MessageBox.Show($"Error: {IOEx.Message}.");
                    }
                }

                if (pbProductPicture.ImageLocation != null)
                {

                    string SourceFileName = pbProductPicture.ImageLocation.ToString();
                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceFileName))
                    {

                        pbProductPicture.ImageLocation = SourceFileName;
                        return true;
                    }
                    else
                    {

                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValideInputs())
            {

                MessageBox.Show("Required field missed.", "Missing an Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!_HandleProductImage())
                return;

            _Product.ProductName = txtProductName.Text.Trim();
            _Product.BarCode = txtBarCode.Text.Trim();
            _Product.SKU = txtSKU.Text.Trim();
            _Product.SellPrice = Convert.ToDecimal(txtSellPrice.Text.Trim());
            _Product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text.Trim());
            _Product.MinimumStock = Convert.ToInt32(txtMinimumStock.Text.Trim());
            _Product.IsActive = cboxIsActive.Checked;
            _Product.CategoryID_FK = clsCategory.GetCategoryByCategoryName(cbCategory.SelectedItem.ToString()).CategoryID;
            _Product.BrandID_FK = clsBrands.GetBrandByName(cbBrand.SelectedItem.ToString()).BrandID;

            if (pbProductPicture.ImageLocation != null)
                _Product.ImagePath = pbProductPicture.ImageLocation;
            else
                _Product.ImagePath = "";


            if (_Product.Save())
            {
                MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
