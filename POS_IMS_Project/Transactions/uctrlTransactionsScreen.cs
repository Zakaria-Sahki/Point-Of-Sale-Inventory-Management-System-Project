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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace POS_IMS_Project
{
    public partial class uctrlTransactionsScreen : UserControl
    {
        public uctrlTransactionsScreen()
        {
            InitializeComponent();

            // Click

            pnlTransactions.Click += TransactionsButton_Click;
            lbltransactions.Click += TransactionsButton_Click;
            pbtransactions.Click += TransactionsButton_Click;

            pnlSales.Click += SalesButton_Click;
            lblSales.Click += SalesButton_Click;
            pbSales.Click += SalesButton_Click;

            // Mouse Move
            pnlTransactions.MouseMove += TransactionsButton_MouseMove;
            lbltransactions.MouseMove += TransactionsButton_MouseMove;
            pbtransactions.MouseMove += TransactionsButton_MouseMove;

            pnlPurchases.MouseMove += PurchasesButton_MouseMove;
            lblPurchases.MouseMove += PurchasesButton_MouseMove;
            pbPurchases.MouseMove += PurchasesButton_MouseMove;

            pnlSales.MouseMove += SalesButton_MouseMove;
            lblSales.MouseMove += SalesButton_MouseMove;
            pbSales.MouseMove += SalesButton_MouseMove;

            // Mouse Leave

            pnlTransactions.MouseLeave += TransactionsButton_MouseLeave;
            lbltransactions.MouseLeave += TransactionsButton_MouseLeave;
            pbtransactions.MouseLeave += TransactionsButton_MouseLeave;

            pnlPurchases.MouseLeave += PurchasesButton_MouseLeave;
            lblPurchases.MouseLeave += PurchasesButton_MouseLeave;
            pbPurchases.MouseLeave += PurchasesButton_MouseLeave;

            pnlSales.MouseLeave += SalesButton_MouseLeave;
            lblSales.MouseLeave += SalesButton_MouseLeave;
            pbSales.MouseLeave += SalesButton_MouseLeave;
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            frmTransactionsLogManagement frm = new frmTransactionsLogManagement();
            frm.ShowDialog();
        }
        private void SalesButton_Click(object sender, EventArgs e)
        {
            frmSalesManagement frm = new frmSalesManagement();
            frm.ShowDialog();
        }
        private void TransactionsButton_MouseMove(object sender, MouseEventArgs e) {

            pnlTransactions.BackColor = Color.FromArgb(71, 86, 106);
        }
        private void PurchasesButton_MouseMove(object sender, MouseEventArgs e) { 
        
            pnlPurchases.BackColor = Color.FromArgb(71, 86, 106);
        }
        private void SalesButton_MouseMove(object sender, MouseEventArgs e)
        {

            pnlSales.BackColor = Color.FromArgb(71, 86, 106);
        }
        private void TransactionsButton_MouseLeave(object sender, EventArgs e) {

            pnlTransactions.BackColor = Color.FromArgb(51, 65, 85);
        }
        private void PurchasesButton_MouseLeave(object sender, EventArgs e)
        {

            pnlPurchases.BackColor = Color.FromArgb(51, 65, 85);
        }
        private void SalesButton_MouseLeave(object sender, EventArgs e)
        {

            pnlSales.BackColor = Color.FromArgb(51, 65, 85);
        }

        private void RefreshCards() {

            DateTime today = DateTime.Today;
            DataTable TransactionTable = clsInventoryTransaction.GetAllInventoryTransactions();

            decimal TotalTodayRevenue = TransactionTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("Time") >= today &&
                row.Field<DateTime>("Time") < today.AddDays(1))
                .Sum(row => row.Field<decimal?>("TotalPrice") ?? 0m);

            decimal TotalWeekRevenue = TransactionTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("Time") > today.AddDays(-7) &&
                row.Field<DateTime>("Time") <= today.AddDays(1))
                .Sum(row => row.Field<decimal?>("TotalPrice") ?? 0m);

            int TotalTransactionsToday = TransactionTable.AsEnumerable()
                .Where(row => row.Field<DateTime>("Time") >= today &&
                row.Field<DateTime>("Time") < today.AddDays(1)).Count();

            lblTodayRevenue.Text = "DZD " + TotalTodayRevenue.ToString("N2",
            System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            lblTodayRevenue.Left = pnlTodayRevenue.Width - lblTodayRevenue.Width - 60;

            lblWeekRevenue.Text = "DZD " + TotalWeekRevenue.ToString("N2",
            System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            lblWeekRevenue.Left = pnlWeekRevenue.Width - lblWeekRevenue.Width - 50;

            lblTodayTransactionCount.Text = TotalTransactionsToday.ToString();
            lblTodayTransactionCount.Left = 120;
        }
        private void uctrlTransactionsScreen_Load(object sender, EventArgs e)
        {
            RefreshCards();
        }
    }
}
