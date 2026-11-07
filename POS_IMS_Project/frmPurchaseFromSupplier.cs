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
    public partial class frmPurchaseFromSupplier : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        private int _productID;
        private clsProduct _product;
        private DataTable TransactionsTable;

        public frmPurchaseFromSupplier(int ProductID)
        {
            InitializeComponent();
            this.Size = new Size(1000, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            _productID = ProductID;
        }

        private void RefreshPage()
        {

            TransactionsTable = clsInventoryTransaction.GetAllInventoryTransactionsByProductID(_productID);

            _bindingSource.DataSource = TransactionsTable;

            dgvTransactions.DataSource = _bindingSource;
            lblNumberOfTransaction.Text = dgvTransactions.Rows.Count.ToString() + "  Transactions registered";
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvTransactions);
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void frmPurchaseFromSupplier_Load(object sender, EventArgs e)
        {
            _product = clsProduct.GetProductByID(_productID);
            if (_product == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblProductName.Text = _product.ProductName;
            lblCurrentStockProduct.Text = _product.QuantityInStock.ToString() + " Current Stock";

            if (_product.ImagePath != "")
            {

                try
                {
                    pbProductImage.Image = Image.FromFile(_product.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbProductImage.Image = null;
                }
            }
            else
            {
                pbProductImage.Image = POS_IMS_Project.Properties.Resources.no_image_available_icon;
            }
            RefreshPage();
        }

        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo(_productID);
            frm.ShowDialog();
        }
    }
}
