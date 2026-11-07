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
    public partial class frmSalesManagement : Form
    {
        private DataTable SalesInvoicesTable;

        public frmSalesManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1110, 620);

            dtpStartDate.ValueChanged += SelectTimeSpane;
            dtpEndDate.ValueChanged += SelectTimeSpane;
        }

        private BindingSource _bindingSource = new BindingSource();
        private void FillSalesInvoices()
        {

            SalesInvoicesTable = clsSaleInvoice.GetAllSaleInvoices();

            _bindingSource.DataSource = SalesInvoicesTable;

            dgvSalesInvoices.DataSource = _bindingSource;
            //lblNumOfCustomers.Text = dgvTransactionsLog.Rows.Count.ToString() + "  Customers registered";
            dgvSalesInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
            cbFitlerType.SelectedIndex = 0;
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvSalesInvoices);
            dgvSalesInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesInvoices.MultiSelect = false;
            dgvSalesInvoices.AllowUserToAddRows = false;
            dgvSalesInvoices.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void frmSalesManagement_Load(object sender, EventArgs e)
        {
            FillSalesInvoices();
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

                case "CustomerName":
                    FilterName = "CustomerName";
                    break;

                case "Username":
                    FilterName = "Username";
                    break;
                default:
                    FilterName = "None";
                    break;
            }

            if (FilterName == "None" || txtSearchByFilter.Text.Trim() == "")
            {

                SalesInvoicesTable.DefaultView.RowFilter = string.Format("([SaleDate] >= '{0}' AND ([SaleDate] <= '{1}'))", dtpStartDate.Value, dtpEndDate.Value.AddDays(1));
                return;
            }

            SalesInvoicesTable.DefaultView.RowFilter = string.Format("([{0}] LIKE '{1}%') AND (([SaleDate] >= '{2}') AND ([SaleDate] <= '{3}'))", FilterName, txtSearchByFilter.Text.Trim(), dtpStartDate.Value, dtpEndDate.Value.AddDays(1));

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

        private void saleInvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleInvoiceDetails frm = new frmSaleInvoiceDetails((int)dgvSalesInvoices.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
