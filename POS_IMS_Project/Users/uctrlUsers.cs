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
    public partial class uctrlUsers : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();
        private int NumOfAdmins = 0;
        private int NumOfManagers = 0;
        private int NumOfCashiers = 0;
        private int NumOfActiveUsers = 0;
        public uctrlUsers()
        {
            InitializeComponent();
        }
        private void RefreshPage() {

            DataTable dt = clsUsers.DisplayAllUsers();

            _bindingSource.DataSource = dt;

            dgvUsers.DataSource = _bindingSource;
            lblNumberOfUsers.Text = dgvUsers.Rows.Count.ToString() + "  Users registered";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigureGridAppearance();

            clsUsers.GetUsersInformation(ref NumOfAdmins, ref NumOfManagers, ref NumOfCashiers, ref NumOfActiveUsers);
            lblNumberOfAdmins.Text = NumOfAdmins.ToString();
            lblNumberOfManagers.Text = NumOfManagers.ToString();
            lblNumberOfCashiers.Text = NumOfCashiers.ToString();
            lblActiveUserCount.Text = NumOfActiveUsers.ToString();
        }
        private void uctrlUsers_Load(object sender, EventArgs e)
        {

            RefreshPage();
        }
        private void ConfigureGridAppearance()
        {
            EnableDoubleBuffering(dgvUsers);
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ReadOnly = true; // Set to false if inline editing is required
        }
        private static void EnableDoubleBuffering(DataGridView dgv)
        {
            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgv, true, null);
        }






        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            RefreshPage();
        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete User [{(int)dgvUsers.CurrentRow.Cells[0].Value}]", "Confirm Delte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                // Perform Delete and Refresh.
                if (clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("User delated Successfully.", "Delete Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPage();
                }
                else
                {

                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshPage();
        }
        private void btnFindUser_Click(object sender, EventArgs e)
        {
            frmFindUser frm = new frmFindUser();
            frm.ShowDialog();
            RefreshPage();
        }
    }
}
