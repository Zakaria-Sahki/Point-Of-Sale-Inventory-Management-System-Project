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

namespace POS_IMS_Project.Transactions
{
    public partial class frmPurchasesManagement : Form
    {
        private DataTable PurchaseInvoicesTable;

        public frmPurchasesManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1110, 620);

            dtpStartDate.ValueChanged += SelectTimeSpane;
            dtpEndDate.ValueChanged += SelectTimeSpane;
        }

        private BindingSource _bindingSource = new BindingSource();
        private void FillPurchaseInvoices()
        {

            PurchaseInvoicesTable = clsPurchaseInvoice.GetAllPurchaseInvoices();

            _bindingSource.DataSource = PurchaseInvoicesTable;

            dgvPurchaseInvoices.DataSource = _bindingSource;
            //lblNumOfCustomers.Text = dgvTransactionsLog.Rows.Count.ToString() + "  Customers registered";
            dgvPurchaseInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
            cbFitlerType.SelectedIndex = 0;
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvPurchaseInvoices);
            dgvPurchaseInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPurchaseInvoices.MultiSelect = false;
            dgvPurchaseInvoices.AllowUserToAddRows = false;
            dgvPurchaseInvoices.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void frmPurchasesManagement_Load(object sender, EventArgs e)
        {
            FillPurchaseInvoices();
            dtpStartDate.MaxDate = DateTime.Today;
            dtpEndDate.MaxDate = DateTime.Today;
        }



        private void ApplyingFilter()
        {

            string FilterName = "";

            switch (cbFitlerType.Text)
            {

                case "None":
                    FilterName = "None";
                    break;

                case "CompanyName":
                    FilterName = "CompanyName";
                    break;

                case "Username":
                    FilterName = "Username";
                    break;
                case "SupplierID":
                    FilterName = "SupplierID";
                    break;
                default:
                    FilterName = "None";
                    break;
            }

            if (FilterName == "None" || txtSearchByFilter.Text.Trim() == "")
            {

                PurchaseInvoicesTable.DefaultView.RowFilter = string.Format("([PurchaseDate] >= '{0}' AND ([PurchaseDate] <= '{1}'))", dtpStartDate.Value, dtpEndDate.Value.AddDays(1));
                return;
            }

            if (FilterName == "SupplierID") {

                PurchaseInvoicesTable.DefaultView.RowFilter = string.Format("([{0}] = '{1}') AND (([PurchaseDate] >= '{2}') AND ([PurchaseDate] <= '{3}'))", FilterName, txtSearchByFilter.Text.Trim(), dtpStartDate.Value, dtpEndDate.Value.AddDays(1));
                return;
            }

            PurchaseInvoicesTable.DefaultView.RowFilter = string.Format("([{0}] LIKE '{1}%') AND (([PurchaseDate] >= '{2}') AND ([PurchaseDate] <= '{3}'))", FilterName, txtSearchByFilter.Text.Trim(), dtpStartDate.Value, dtpEndDate.Value.AddDays(1));

        }
        private void SelectTimeSpane(object sender, EventArgs e)
        {

            if (dtpStartDate.Value > dtpEndDate.Value)
            {

                MessageBox.Show("Starting Date must be before the ending date.", "Invalid Timespan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = DateTime.Today;
                dtpStartDate.Value = DateTime.Today.AddDays(-7);
                return;
            }

            ApplyingFilter();
        }
        private void txtSearchByFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyingFilter();
        }
        private void purchaseInvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPurchaseInvoiceDetails frm = new frmPurchaseInvoiceDetails((int)dgvPurchaseInvoices.CurrentRow.Cells[0].Value);
            //frm.ShowDialog();
        }
    }
}
