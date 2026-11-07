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
    public partial class uctrlCustomers : UserControl
    {

        private BindingSource _bindingSource = new BindingSource();

        public uctrlCustomers()
        {
            InitializeComponent();
        }

        private void RefreshPage()
        {

            DataTable dt = clsCustomers.GetAllCustomers();

            _bindingSource.DataSource = dt;

            dgvCustomers.DataSource = _bindingSource;
            lblNumOfCustomers.Text = dgvCustomers.Rows.Count.ToString() + "  Customers registered";
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvCustomers);
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void uctrlCustomers_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerInfo frm = new frmCustomerInfo((int)dgvCustomers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer(-1);
            frm.ShowDialog();
            RefreshPage();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Customer [{(int)dgvCustomers.CurrentRow.Cells[0].Value}]", "Confirm Delte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsCustomers.DeleteCustomer((int)dgvCustomers.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Customer delated Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Customer was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            frmFindCustomer frm = new frmFindCustomer();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
