using POS_IMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_IMS_Project
{
    public partial class frmAddEditPerson : Form
    {
        private enum enMode { Add = 1, Update = 2 }
        private enMode Mode = enMode.Add;
        private clsPeople Person;
        private int _PersonID;
        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (PersonID == -1)
                Mode = enMode.Add;
            else
                Mode = enMode.Update;

            _PersonID = PersonID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckingValidations())
            {

                MessageBox.Show("Required Field is missing.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            Person.FirstName = txtFirstName.Text.Trim();
            Person.LastName = txtLastName.Text.Trim();
            Person.Email = txtEmail.Text.Trim();
            Person.Phone = txtPhone.Text.Trim();

            if (Person.Save())
            {


                MessageBox.Show("Person Saved Sucessfully", "Save Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else {

                MessageBox.Show("Person Faild to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingPage() {

            if (Mode == enMode.Add)
            {

                Person = new clsPeople("", "", "", "");
                this.Text = "Add New Person";
                lblTitle.Text = "Add New Person";
            }


            if (Mode == enMode.Update)
            {

                Person = clsPeople.GetPersonByID(_PersonID);

                if (Person == null)
                {

                    MessageBox.Show("Person Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }


                this.Text = "Edit Person";
                lblTitle.Text = "Edit Person";
                lblTitle.TextAlign = ContentAlignment.MiddleCenter;
                txtFirstName.Text = Person.FirstName;
                txtLastName.Text = Person.LastName;
                txtEmail.Text = Person.Email;
                txtPhone.Text = Person.Phone;
            }
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            LoadingPage();
        }
        private bool CheckingValidations() {

            // If there is a missing input it will return true;
            return (string.IsNullOrWhiteSpace(txtFirstName.Text)
                || string.IsNullOrWhiteSpace(txtLastName.Text)
                || string.IsNullOrWhiteSpace(txtPhone.Text));
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {

                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name Required!");

            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {

                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name Required!");

            }
            else
            {
                errorProvider1.SetError(txtLastName, null);
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {

                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone Required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
                
            }

            if (!txtPhone.Text.All(char.IsDigit)) {

                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Only numbers!");
            }
            else {

                errorProvider1.SetError(txtPhone, null);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
