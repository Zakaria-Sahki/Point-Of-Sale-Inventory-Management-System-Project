using POS_IMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_IMS_Project
{
    public partial class frmAddEditCustomer : Form
    {

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _CustomerID = -1;
        private clsCustomers Customer;
        private int _PersonIDSelected = -1;

        public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();
            this.Size = new Size(730, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            if (CustomerID == -1)
                _Mode = enMode.Add;
            else { 
                
                _Mode = enMode.Update;
                _CustomerID = CustomerID;
            }
        }

        private void DefaultSettings() {

            txtCredits.Text = string.Empty;
            txtPoints.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtTotalSpent.Text = string.Empty;
            lblCustomerID.Text = "[xxx]";
            cBoxIsActive.Checked = true;
            uctrlFindingPerson1.ResetAllInfoToDefault();
        }
        private void LoadForm() {

            if (_Mode == enMode.Add) {

                lblTitle.Text = "Add New Customer";
                this.Text = "Add New Customer";
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                tabCustomerInfo.Enabled = false;
                Customer = new clsCustomers(0, 0, 0, true, string.Empty);
                return;
            }

            lblTitle.Text = "Update Customer";
            this.Text = "Update Customer";
            LoadCustomerInfoInUpdateMode();
        }
        private void LoadCustomerInfoInUpdateMode() {

            Customer = clsCustomers.GetCustomerByID(_CustomerID);

            if (Customer == null) {

                MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            btnSave.Enabled = true;
            btnNext.Enabled = true;
            tabCustomerInfo.Enabled = true;
            uctrlFindingPerson1.LoadPersonInfoDirectly(Customer.PersonID_FK);
            uctrlFindingPerson1.DisableSearching();
            txtTotalSpent.Text = Customer.TotalSpent.ToString();
            txtCredits.Text = Customer.Credits.ToString();
            txtPoints.Text = Customer.Points.ToString();
            txtNotes.Text = Customer.Notes.ToString();
            cBoxIsActive.Checked = Customer.IsActive;
            lblCustomerID.Text = Customer.CustomerID.ToString();
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalSpent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalSpent.Text))
            {

                e.Cancel = true;
                txtTotalSpent.Focus();
                errorProvider1.SetError(txtTotalSpent, "Total Spent Required!");

            }
            else
            {
                errorProvider1.SetError(txtTotalSpent, null);
            }
        }
        private void txtCredits_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCredits.Text))
            {

                e.Cancel = true;
                txtCredits.Focus();
                errorProvider1.SetError(txtCredits, "Credits Required!");

            }
            else
            {
                errorProvider1.SetError(txtCredits, null);
            }
        }
        private void txtPoints_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPoints.Text))
            {

                e.Cancel = true;
                txtPoints.Focus();
                errorProvider1.SetError(txtPoints, "Points Required!");

            }
            else
            {
                errorProvider1.SetError(txtPoints, null);
            }
        }
        private void txtTotalSpent_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits and thee ',' and '.'
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }
        private void txtCredits_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits and thee ',' and '.'
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',';
        }
        private void txtPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void uctrlFindingPerson1_OnPersonSelected(int obj)
        {
            _PersonIDSelected = obj;
            if (ValidatingSelectedPerson()) {

                MessageBox.Show("This Person already related to another customer.\ntry again with another person.", "Person already Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                DefaultSettings();
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                tabCustomerInfo.Enabled = false;
                return;
            }

            btnNext.Enabled = true;
            btnSave.Enabled = true;
            tabCustomerInfo.Enabled = true;
            uctrlFindingPerson1.DisableSearching();
        }
        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tbctrlAddEditCustomer.SelectedIndex = 1;
        }
        private bool ValidatingSelectedPerson() {

            return clsCustomers.IsCustomerWithPersonIDExist(_PersonIDSelected);
        }
        private bool ValidatinBeforeSaving() {


            return string.IsNullOrWhiteSpace(txtTotalSpent.Text.Trim())
                || string.IsNullOrWhiteSpace(txtCredits.Text.Trim())
                || string.IsNullOrWhiteSpace(txtPoints.Text.Trim());

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidatinBeforeSaving()) {

                MessageBox.Show("You have inccorect Input data, check again.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            Customer.PersonID_FK = _PersonIDSelected;
            Customer.TotalSpent = Convert.ToDecimal(txtTotalSpent.Text.Trim());
            Customer.Points = Convert.ToInt32(txtPoints.Text.Trim());
            Customer.Credits = Convert.ToDecimal(txtCredits.Text.Trim());
            Customer.Notes = txtNotes.Text;
            Customer.IsActive = cBoxIsActive.Checked;


            if (Customer.Save())
            {

                MessageBox.Show("Customer Saved Sucessfully", "Save Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Customer Faild to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
