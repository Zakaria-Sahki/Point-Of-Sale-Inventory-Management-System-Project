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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_IMS_Project
{
    public partial class frmAddEditUser : Form
    {

        private enum enMode { Add = 1, Update = 2 }
        enMode _Mode = enMode.Add;
        private int _PersonID = -1;
        private int _UserID = -1;
        private clsUsers _UserInfo;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(775, 560);
            if (UserID == -1)
                _Mode = enMode.Add;
            else {

                _Mode = enMode.Update;
                this._UserID = UserID;
            }
                
        }
        private void _FillComboboxOfRole() {

            DataTable RolesTable = clsRole.GetAllRoles();

            foreach (DataRow Row in RolesTable.Rows)
            {

                cbPermissions.Items.Add(Row["RoleName"]);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uctrlFindingPerson1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
            ValidatingPersonID();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabCtrlUser.SelectedIndex = 1;
        }
        private void LoadForm() {

            _FillComboboxOfRole();
            cbPermissions.SelectedIndex = 0;

            if (_Mode == enMode.Add)
            {

                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                btnNext.Enabled = false;
                tPUserInfo.Enabled = false;
                btnSave.Enabled = false;
                _UserInfo = new clsUsers("", "", -1);
                return;
            }

            if (_Mode == enMode.Update) {

                LoadingDataForUpdateMode();
            }
            
        }
        private void LoadingDataForUpdateMode() {

            lblTitle.Text = "Update User";
            this.Text = "Update User";
            btnNext.Enabled = true;
            tPUserInfo.Enabled = true;
            btnSave.Enabled = true;


            _UserInfo = clsUsers.GetUserByID(_UserID);

            if (_UserInfo == null)
            {

                MessageBox.Show($"No User with ID [{_UserID}]", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _PersonID = _UserInfo.PersonID_FK;
            uctrlFindingPerson1.DisableSearching();
            uctrlFindingPerson1.LoadPersonInfoDirectly(_UserInfo.PersonID_FK);
            txtUsername.Text = _UserInfo.Username;
            txtPassword.Text = _UserInfo.HashedPassword;
            checkBox1.Checked = _UserInfo.IsActive;
            cbPermissions.SelectedIndex = _UserInfo.Permissions - 1;
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

            LoadForm();
        }
        private void ValidatingPersonID() {

            if (clsUsers.IsUserWithPersonIDExist(_PersonID)) {

                MessageBox.Show("This Person Already integrated with a specific user", "Already Integrated", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                LoadForm();
                uctrlFindingPerson1.ResetAllInfoToDefault();
                return;
            }

            btnNext.Enabled = true;
            tPUserInfo.Enabled = true;
            btnSave.Enabled = true;
            uctrlFindingPerson1.DisableSearching();
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {

                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtUsername, null);
            }

            if (clsUsers.IsUserWithUsernameExist(txtUsername.Text.Trim()) && _Mode == enMode.Add)
            {


                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This Username already exist!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtUsername, null);
            }
        }
        private bool IsPasswordContainDigitsAndChars(string Password)
        {

            bool hasDigit = false;
            bool hasCharacter = false;

            foreach (char c in Password)
            {
                if (char.IsDigit(c))
                    hasDigit = true;

                if (char.IsLetter(c))
                    hasCharacter = true;
            }
            return hasDigit && hasCharacter;
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {

                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password Required!");
                return;
            }
            else
            {

                errorProvider1.SetError(txtPassword, null);
            }

            if (txtPassword.Text.Length < 8)
            {

                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must be at least 8 characters long.");
                return;
            }
            else
            {

                errorProvider1.SetError(txtPassword, null);
            }

            if (!IsPasswordContainDigitsAndChars(txtPassword.Text.Trim()))
            {

                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must contain at least one letter and one digit.");
                return;
            }
            else
            {

                errorProvider1.SetError(txtPassword, null);
            }
        }
        private bool CheckingForConditionsForSaving() {

            // string.IsNullOrWhiteSpace(txtUsername.Text.Trim())
            // clsUsers.IsUserWithUsernameExist(txtUsername.Text.Trim()
            // string.IsNullOrWhiteSpace(txtPassword.Text.Trim()
            // txtPassword.Text.Length < 8
            // !IsPasswordContainDigitsAndChars(txtPassword.Text.Trim())
            return (string.IsNullOrWhiteSpace(txtUsername.Text.Trim())
                || (clsUsers.IsUserWithUsernameExist(txtUsername.Text.Trim()) && _Mode == enMode.Add)
                || string.IsNullOrWhiteSpace(txtPassword.Text.Trim())
                || (txtPassword.Text.Length < 8)
                || !IsPasswordContainDigitsAndChars(txtPassword.Text.Trim()));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (CheckingForConditionsForSaving()) {

                MessageBox.Show("You have inccorect Input data, check again.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            _UserInfo.PersonID_FK = _PersonID;
            _UserInfo.Username = txtUsername.Text.Trim();
            _UserInfo.HashedPassword = txtPassword.Text.Trim();
            _UserInfo.IsActive = checkBox1.Checked;
            _UserInfo.Permissions = clsRole.Find(cbPermissions.Text).RoleID;

            if (_UserInfo.Save())
            {

                MessageBox.Show("User Saved Sucessfully", "Save Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else {

                MessageBox.Show("User Faild to Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tPersonInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
