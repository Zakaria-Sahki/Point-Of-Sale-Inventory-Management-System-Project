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
    public partial class uctrlUserInfo : UserControl
    {
        public uctrlUserInfo()
        {
            InitializeComponent();
        }

        private clsUsers UserInfo;

        public void DisplayingUserInfoByUserID(int UserID) {

            UserInfo = clsUsers.GetUserByID(UserID);
            if (UserInfo == null) {

                MessageBox.Show($"No User with ID [{UserID}]", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultValues();
                return;
            }

            lblEditUser.Visible = true;
            lblFirstName.Text = UserInfo.PersonInfo.FirstName;
            lblLastName.Text = UserInfo.PersonInfo.LastName;
            lblEmail.Text = UserInfo.PersonInfo.Email;
            lblPhone.Text = UserInfo.PersonInfo.Phone;
            lblUsername.Text = UserInfo.Username;
            lblActiveOrNot.Text = UserInfo.IsActive ? "True" : "False";
            lblRoleName.Text = clsRole.Find(UserInfo.Permissions).RoleName;
        }
        public void DisplayingUserInfoByPersonID(int PersonID)
        {

            UserInfo = clsUsers.GetUserByPersonID(PersonID);
            if (UserInfo == null)
            {

                MessageBox.Show($"No User with Person ID [{PersonID}]", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultValues();
                return;
            }

            lblEditUser.Visible = true;
            lblFirstName.Text = UserInfo.PersonInfo.FirstName;
            lblLastName.Text = UserInfo.PersonInfo.LastName;
            lblEmail.Text = UserInfo.PersonInfo.Email;
            lblPhone.Text = UserInfo.PersonInfo.Phone;
            lblUsername.Text = UserInfo.Username;
            lblActiveOrNot.Text = UserInfo.IsActive ? "True" : "False";
            lblRoleName.Text = clsRole.Find(UserInfo.Permissions).RoleName;
        }
        public void DisplayingUserInfoByUsername(string Username)
        {

            UserInfo = clsUsers.GetUserByUsername(Username);
            if (UserInfo == null)
            {

                MessageBox.Show($"No User with Username [{Username}]", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultValues();
                return;
            }

            lblEditUser.Visible = true;
            lblFirstName.Text = UserInfo.PersonInfo.FirstName;
            lblLastName.Text = UserInfo.PersonInfo.LastName;
            lblEmail.Text = UserInfo.PersonInfo.Email;
            lblPhone.Text = UserInfo.PersonInfo.Phone;
            lblUsername.Text = UserInfo.Username;
            lblActiveOrNot.Text = UserInfo.IsActive ? "True" : "False";
            lblRoleName.Text = clsRole.Find(UserInfo.Permissions).RoleName;
        }
        public void DefaultValues() {

            lblEditUser.Visible = false;
            lblFirstName.Text = "[xxx]";
            lblLastName.Text = "[xxx]";
            lblEmail.Text = "[xxx]";
            lblPhone.Text = "[xxx]";
            lblUsername.Text = "[xxx]";
            lblActiveOrNot.Text = "[xxx]";
            lblRoleName.Text = "[xxx]";
        }
        private void lblEditUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(UserInfo.UserID);
            frm.ShowDialog();
            DisplayingUserInfoByUserID(UserInfo.UserID);
        }
    }
}
