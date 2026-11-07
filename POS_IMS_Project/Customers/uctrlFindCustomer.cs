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
    public partial class uctrlFindCustomer : UserControl
    {
        public uctrlFindCustomer()
        {
            InitializeComponent();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch, "This Field is required!");
            }
            else
            {
                errorProvider1.SetError(txtSearch, null);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            //this will allow only digits if person id or User id is selected
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool IsCustomerExist(int CustomerID) { 
            
            return clsCustomers.IsCustomerWithCustomerIDExist(CustomerID);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim())) {

                MessageBox.Show("invalid input, try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (!IsCustomerExist(Convert.ToInt32(txtSearch.Text.Trim()))) {

                MessageBox.Show($"No Customer with ID [{txtSearch.Text}]", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlCustomerInfo1.DefaultTextLoad();
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                return;
            }

            ctrlCustomerInfo1.DisplayCustomerInfo(Convert.ToInt32(txtSearch.Text.Trim()));
        }
    }
}
