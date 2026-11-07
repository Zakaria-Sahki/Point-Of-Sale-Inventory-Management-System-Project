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
    public partial class frmSaleInvoiceDetails : Form
    {
        private DataTable SalesInvoicesDetailsTable;
        private clsSaleInvoice _SaleInvoice;
        private int _SaleID;
        public frmSaleInvoiceDetails(int SaleID)
        {
            InitializeComponent();
            this.Size = new Size(915, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this._SaleID = SaleID;
        }
        private BindingSource _bindingSource = new BindingSource();
        private void FillSaleDetails()
        {

            SalesInvoicesDetailsTable = clsSaleDetails.GetSaleDetailsBySaleID(_SaleID);

            _bindingSource.DataSource = SalesInvoicesDetailsTable;

            dgvSaleDetailsPerInvoice.DataSource = _bindingSource;
            //lblNumOfCustomers.Text = dgvTransactionsLog.Rows.Count.ToString() + "  Customers registered";
            dgvSaleDetailsPerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvSaleDetailsPerInvoice);
            dgvSaleDetailsPerInvoice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetailsPerInvoice.MultiSelect = false;
            dgvSaleDetailsPerInvoice.AllowUserToAddRows = false;
            dgvSaleDetailsPerInvoice.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void frmSaleInvoiceDetails_Load(object sender, EventArgs e)
        {
            _SaleInvoice = clsSaleInvoice.GetSaleInvoiceByID(_SaleID);
            if (_SaleInvoice == null) {

                MessageBox.Show($"Sale Invoice with this ID {_SaleID} Not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbltotalprice.Text = "DZD " + _SaleInvoice.TotalAmount.ToString("F2");
            lbltotalprice.Left = dgvSaleDetailsPerInvoice.Width - lbltotalprice.Width + 10;
            txtCustomerID.Text = _SaleInvoice.CustomerID_FK.ToString();

            if (_SaleInvoice.CustomerInfo == null)
            {

                txtCustomerName.Text = "Walk-in-Customer";
            }
            else {

                txtCustomerName.Text = _SaleInvoice.CustomerInfo.PersonInfo.FirstName + " " + _SaleInvoice.CustomerInfo.PersonInfo.LastName;
            }
            FillSaleDetails();
        }
    }
}
