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
    public partial class uctrlFindSupplier : UserControl
    {
        private clsSuppliers _supplier;

        public event Action<int> OnSupplierSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void SupplierSelected(int SupplierID)
        {
            Action<int> handler = OnSupplierSelected;
            if (handler != null)
            {
                handler(SupplierID); // Raise the event with the parameter
            }
        }

        public uctrlFindSupplier()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
            {

                MessageBox.Show("invalid input, try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (!IsSupplierExist(Convert.ToInt32(txtSearch.Text.Trim())))
            {

                MessageBox.Show($"No Supplier with ID [{txtSearch.Text}]", "Supplier Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlSupplierInfo1.DefaultTextLoad();
                txtSearch.Text = string.Empty;
                txtSearch.Focus();
                return;
            }

            ctrlSupplierInfo1.DisplaySupplierInfo(Convert.ToInt32(txtSearch.Text.Trim()));
            _supplier = clsSuppliers.GetSupplierByID(Convert.ToInt32(txtSearch.Text.Trim()));
            if (OnSupplierSelected != null)
            {

                OnSupplierSelected(_supplier.SupplierID);
            }
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
        private bool IsSupplierExist(int SupplierID) { 
            
            return clsSuppliers.IsSupplierWithSupplierIDExist(SupplierID);
        }   
        public void DisableControls()
        {
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
        }
    }
}
