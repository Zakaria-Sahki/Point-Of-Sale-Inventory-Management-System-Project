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
    public partial class frmTransactionsLogManagement : Form
    {
        private DataTable TransactionsLogTable;
        public frmTransactionsLogManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1100, 620);

            dtpStartDate.ValueChanged += SelectTimeSpane;
            dtpEndDate.ValueChanged += SelectTimeSpane;
        }

        private BindingSource _bindingSource = new BindingSource();

        private void FillTransactions() {

            TransactionsLogTable = clsInventoryTransaction.GetAllInventoryTransactions();

            _bindingSource.DataSource = TransactionsLogTable;

            dgvTransactionsLog.DataSource = _bindingSource;
            //lblNumOfCustomers.Text = dgvTransactionsLog.Rows.Count.ToString() + "  Customers registered";
            dgvTransactionsLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
            cbFitlerType.SelectedIndex = 0;
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvTransactionsLog);
            dgvTransactionsLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionsLog.MultiSelect = false;
            dgvTransactionsLog.AllowUserToAddRows = false;
            dgvTransactionsLog.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }


        private void frmTransactionsLogManagement_Load(object sender, EventArgs e)
        {
            FillTransactions();
            dtpStartDate.MaxDate = DateTime.Today;
            dtpEndDate.MaxDate = DateTime.Today;
        }
        private void ApplyingFilter() {

            string FilterName = "";

            switch (cbFitlerType.Text)
            {

                case "None":
                    FilterName = "None";
                    break;

                case "ProductName":
                    FilterName = "ProductName";
                    break;

                case "Username":
                    FilterName = "Username";
                    break;

                case "TransactionType":
                    FilterName = "TransactionTypeName";
                    break;

                default:
                    FilterName = "None";
                    break;
            }

            if (FilterName == "None" || txtSearchByFilter.Text.Trim() == "")
            {

                TransactionsLogTable.DefaultView.RowFilter = string.Format("([Time] >= '{0}' AND ([Time] <= '{1}'))", dtpStartDate.Value, dtpEndDate.Value.AddDays(1));
                return;
            }

            TransactionsLogTable.DefaultView.RowFilter = string.Format("([{0}] LIKE '{1}%') AND (([Time] >= '{2}') AND ([Time] <= '{3}'))", FilterName, txtSearchByFilter.Text.Trim(), dtpStartDate.Value, dtpEndDate.Value.AddDays(1));

        }
        private void txtSearchByFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyingFilter();
        }
        private void SelectTimeSpane(object sender, EventArgs e) {

            if (dtpStartDate.Value > dtpEndDate.Value) {

                MessageBox.Show("Starting Date must be before the ending date.", "Invalid Timespan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Value = DateTime.Today;
                dtpStartDate.Value = DateTime.Today.AddDays(-7);
                return;
            }

            ApplyingFilter();
        }
    }
}
