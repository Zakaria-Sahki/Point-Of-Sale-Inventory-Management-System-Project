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
    public partial class frmBrandsManagement : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public frmBrandsManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RefreshPage()
        {

            DataTable dt = clsBrands.GetAllBrands();

            _bindingSource.DataSource = dt;

            dgvBrands.DataSource = _bindingSource;
            lblNumberOfBrands.Text = dgvBrands.Rows.Count.ToString() + "  Brands registered";
            dgvBrands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvBrands);
            dgvBrands.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBrands.MultiSelect = false;
            dgvBrands.AllowUserToAddRows = false;
            dgvBrands.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmBrandsManagement_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        



        private void updateBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBrands frm = new frmAddEditBrands((int)dgvBrands.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deleteBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Brand [{(int)dgvBrands.CurrentRow.Cells[0].Value}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsBrands.DeleteBrand((int)dgvBrands.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Brand deleted Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Brand was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void brandInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrandInfo frm = new frmBrandInfo((int)dgvBrands.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            frmAddEditBrands frm = new frmAddEditBrands(-1);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnFindBrand_Click(object sender, EventArgs e)
        {
            frmFindBrand frm = new frmFindBrand();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
