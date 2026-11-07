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
    public partial class frmCategoriesManagement : Form
    {

        private BindingSource _bindingSource = new BindingSource();

        public frmCategoriesManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RefreshPage()
        {

            DataTable dt = clsCategory.GetAllCategories();

            _bindingSource.DataSource = dt;

            dgvCategories.DataSource = _bindingSource;
            lblNumberOfCategories.Text = dgvCategories.Rows.Count.ToString() + "  Categories registered";
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvCategories);
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.ReadOnly = true; // Set to false if inline editing is required
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
        private void frmCategoriesManagement_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCategory frm = new frmAddEditCategory((int)dgvCategories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Category [{(int)dgvCategories.CurrentRow.Cells[0].Value}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsCategory.DeleteCategory((int)dgvCategories.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Category deleted Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Category was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void categoryInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryInfo frm = new frmCategoryInfo((int)dgvCategories.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddEditCategory frm = new frmAddEditCategory(-1);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnFindCategory_Click(object sender, EventArgs e)
        {
            frmFindCategory frm = new frmFindCategory();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
