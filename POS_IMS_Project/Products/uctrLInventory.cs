using POS_IMS_BusinessLayer;
using System;
using System.Collections;
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
    public partial class uctrLInventory : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();
        private DataTable ProductTable;
        public uctrLInventory()
        {
            InitializeComponent();
        }

        private void RefreshPage()
        {

            ProductTable = clsProduct.DisplayAllProducts();

            _bindingSource.DataSource = ProductTable;

            dgvProducts.DataSource = _bindingSource;
            lblNumberOfProducts.Text = dgvProducts.Rows.Count.ToString() + "  Products registered";
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();

            lblFilterlabel.Visible = false;
            txtSearchByFilter.Visible = false;
            cbForFiltering.Visible = false;
            cbFitlerType.Text = "";
            cbFitlerType.SelectedText = "None";
            lbl_OutOfStockProducuts.Text = ProductTable.AsEnumerable().Where(row => (row.Field<int>("Stock") == 0)).Count().ToString();
            lbl_LowStockProducts.Text = ProductTable.AsEnumerable().Where(row => (row.Field<int>("Stock") < row.Field<int>("MinimumStock")) && (row.Field<int>("Stock") != 0)).Count().ToString();
        }

        private void FilterRefresh() {

            ProductTable = clsProduct.DisplayAllProducts();

            _bindingSource.DataSource = ProductTable;

            dgvProducts.DataSource = _bindingSource;
            lblNumberOfProducts.Text = dgvProducts.Rows.Count.ToString() + "  Products registered";
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvProducts);
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void uctrLInventory_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrandsManagement frm = new frmBrandsManagement();
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoriesManagement frm = new frmCategoriesManagement();
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct(-1);
            frm.ShowDialog();
            RefreshPage();
        }
        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct((int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Product [{(int)dgvProducts.CurrentRow.Cells[0].Value}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsProduct.DeleteProduct((int)dgvProducts.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Product deleted Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Product was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void productActivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to reverse Product Active-Status [{(int)dgvProducts.CurrentRow.Cells[0].Value}]", "Confirm Reversing status", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsProduct.ReverseActivationStatus((int)dgvProducts.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Product Active Status Reversed Successfully.", "Reverse Status Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Product Active Status was not reversed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo((int)dgvProducts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void cbFitlerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRefresh();

            if (cbFitlerType.Text == "None")
            {
                cbForFiltering.Visible = false;
                txtSearchByFilter.Visible = false;
                lblFilterlabel.Visible = false;
            }
            else if (cbFitlerType.Text != "None" && (cbFitlerType.Text == "Brand Name" || cbFitlerType.Text == "Category Name"))
            {
                cbForFiltering.Visible = false;
                lblFilterlabel.Visible = true;
                txtSearchByFilter.Visible = true;
                txtSearchByFilter.Text = "";
                txtSearchByFilter.Focus();
            }
            else {
                lblFilterlabel.Visible = true;
                cbForFiltering.Visible = true;
                txtSearchByFilter.Visible = false;

                if (cbFitlerType.Text == "Active Products")
                {
                    cbForFiltering.Items.Clear();
                    cbForFiltering.Items.Add("All");
                    cbForFiltering.Items.Add("Active");
                    cbForFiltering.Items.Add("Inactive");
                    cbForFiltering.SelectedIndex = 0;
                }
                else {

                    cbForFiltering.Items.Clear();
                    cbForFiltering.Items.Add("All");
                    cbForFiltering.Items.Add("Low");
                    cbForFiltering.Items.Add("Out of Stock");
                    cbForFiltering.SelectedIndex = 0;
                }
            }
        }
        private void txtSearchByFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterName = "";

            switch (cbFitlerType.Text)
            {

                case "None":
                    FilterName = "";
                    break;

                case "Stock":
                    FilterName = "Stock";
                    break;

                case "Brand Name":
                    FilterName = "BrandName";
                    break;

                case "Category Name":
                    FilterName = "CategoryName";
                    break;

                case "Active Product":
                    FilterName = "IsActive";
                    break;

                default:
                    FilterName = "None";
                    break;
            }

            if (FilterName == "None" || txtSearchByFilter.Text.Trim() == "")
            {

                ProductTable.DefaultView.RowFilter = "";
                return;
            }

            if (FilterName == "BrandName" || FilterName == "CategoryName")
                ProductTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterName, txtSearchByFilter.Text.Trim());
            
        }
        private void cbForFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterName = "";

            switch (cbForFiltering.Text)
            {

                case "Active":
                    FilterName = "IsActive";
                    break;

                case "Inactive":
                    FilterName = "IsActive";
                    break;

                case "All":
                    FilterName = "";
                    break;
                    
                case "Low":
                    FilterName = "IsActive";
                    break;

                case "Out of Stock":
                    FilterName = "Stock";
                    break;

                default:
                    FilterName = "";
                    break;
            }

            if (FilterName == "")
            {

                ProductTable.DefaultView.RowFilter = "";
                lblNumberOfProducts.Text = dgvProducts.Rows.Count.ToString();
                return;
            }

            if (FilterName == "IsActive")
                ProductTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterName, (cbForFiltering.Text == "Active" ? 1 : 0));

            if (FilterName == "Stock" && cbForFiltering.Text == "Out of Stock")
                ProductTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterName, 0);

            else if (FilterName == "Stock" && cbForFiltering.Text == "Low")
                ProductTable.DefaultView.RowFilter = string.Format("[{0}] > {1} AND [{0}] <= {2}", FilterName, 0, 5);

        }
        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            frmFindProduct frm = new frmFindProduct();
            frm.ShowDialog();
            RefreshPage();
        }

        private void purchaseFromSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
