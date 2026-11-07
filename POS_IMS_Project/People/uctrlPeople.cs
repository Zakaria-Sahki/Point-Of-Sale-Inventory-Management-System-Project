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
    public partial class uctrlPeople : UserControl
    {

        private BindingSource _bindingSource = new BindingSource();

        public uctrlPeople()
        {
            InitializeComponent();
        }

        private void RefreshPage() {

            DataTable dt = clsPeople.GetAllPeople();

            _bindingSource.DataSource = dt;

            dgvPeople.DataSource = _bindingSource;
            lblNumOfPeople.Text = dgvPeople.Rows.Count.ToString() + "  People registered";
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();
        }

        private void uctrlPeople_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvPeople);
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.MultiSelect = false;
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.ReadOnly = true; // Set to false if inline editing is required
        }

        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete Person [{(int)dgvPeople.CurrentRow.Cells[0].Value}]", "Confirm Delte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsPeople.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Person delated Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
