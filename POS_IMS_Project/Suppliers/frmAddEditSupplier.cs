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
    public partial class frmAddEditSupplier : Form
    {

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;
        private int _SupplierID = -1;
        private clsSuppliers Supplier;
        private int _PersonIDSelected = -1;

        public frmAddEditSupplier(int SupplierID)
        {
            InitializeComponent();
            this.Size = new Size(725, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            if (SupplierID != -1)
            {

                _SupplierID = SupplierID;
                _Mode = enMode.Update;
            }
            else {

                _Mode = enMode.Add;
            }

        }

        private void DefaultSettings()
        {

            txtAddress.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtNotes.Text = string.Empty;
            lblSupplierID.Text = "[xxx]";
            cBoxIsActive.Checked = true;
            uctrlFindingPerson1.ResetAllInfoToDefault();
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            tabSupplierInfo.Enabled = false;
        }
        private void LoadForm()
        {

            if (_Mode == enMode.Add)
            {

                lblTitle.Text = "Add New Supplier";
                this.Text = "Add New Supplier";
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                tabSupplierInfo.Enabled = false;
                Supplier = new clsSuppliers(string.Empty, string.Empty, true, string.Empty);
                return;
            }

            lblTitle.Text = "Update Supplier";
            this.Text = "Update Supplier";
            LoadSupplierInfoInUpdateMode();
        }
        private void LoadSupplierInfoInUpdateMode()
        {

            Supplier = clsSuppliers.GetSupplierByID(_SupplierID);

            if (Supplier == null)
            {

                MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            btnSave.Enabled = true;
            btnNext.Enabled = true;
            tabSupplierInfo.Enabled = true;
            uctrlFindingPerson1.LoadPersonInfoDirectly(Supplier.PersonID_FK);
            uctrlFindingPerson1.DisableSearching();
            txtAddress.Text = Supplier.Address;
            txtCompanyName.Text = Supplier.CompanyName;
            txtNotes.Text = Supplier.Notes;
            cBoxIsActive.Checked = Supplier.IsActive;
            lblSupplierID.Text = Supplier.SupplierID.ToString();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tbctrlAddEditSupplier.SelectedIndex = 1;
        }
        private void uctrlFindingPerson1_OnPersonSelected(int obj)
        {
            _PersonIDSelected = obj;
            if (ValidatingSelectedPerson())
            {

                MessageBox.Show("This Person already related to another supplier.\ntry again with another person.", "Person already Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                DefaultSettings();
                return;
            }

            btnNext.Enabled = true;
            btnSave.Enabled = true;
            tabSupplierInfo.Enabled = true;
            uctrlFindingPerson1.DisableSearching();
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {

                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "Address Required!");

            }
            else
            {
                errorProvider1.SetError(txtAddress, null);
            }
        }
        private void frmAddEditSupplier_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private bool ValidatingSelectedPerson()
        {

            return clsSuppliers.IsSupplierWithPersonIDExist(_PersonIDSelected);
        }
        private bool ValidatingBeforeSaving()
        {
            return string.IsNullOrWhiteSpace(txtAddress.Text.Trim());
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidatingBeforeSaving()) {

                MessageBox.Show("You have inccorect Input data, check again.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            Supplier.PersonID_FK = _PersonIDSelected;
            Supplier.Address = txtAddress.Text.Trim();
            Supplier.CompanyName = txtCompanyName.Text.Trim();
            Supplier.Notes = txtNotes.Text.Trim();
            Supplier.IsActive = cBoxIsActive.Checked;

            if (Supplier.Save())
            {

                MessageBox.Show("Supplier Saved Sucessfully", "Save Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Supplier Faild to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
