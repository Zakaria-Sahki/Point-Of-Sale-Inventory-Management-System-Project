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
    public partial class uctrlSuppliers : UserControl
    {

        private BindingSource _bindingSource = new BindingSource();


        public uctrlSuppliers()
        {
            InitializeComponent();
        }

        private void RefreshPage()
        {

            DataTable dt = clsSuppliers.GetAllSuppliers();

            _bindingSource.DataSource = dt;

            dgvSuppliers.DataSource = _bindingSource;
            lblNumOfCustomers.Text = dgvSuppliers.Rows.Count.ToString() + "  Suppliers registered";
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvSuppliers);
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.MultiSelect = false;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void uctrlSuppliers_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void supplierInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierInfo frm = new frmSupplierInfo((int)dgvSuppliers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Supplier [{(int)dgvSuppliers.CurrentRow.Cells[0].Value}]", "Confirm Delte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsSuppliers.DeleteSupplier((int)dgvSuppliers.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Supplier delated Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Supplier was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void updateSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frm = new frmAddEditSupplier((int)dgvSuppliers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            frmAddEditSupplier frm = new frmAddEditSupplier(-1);
            frm.ShowDialog();
            RefreshPage();
        }

        private void btnFindSupplier_Click(object sender, EventArgs e)
        {
            frmFindSupplier frm = new frmFindSupplier();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
