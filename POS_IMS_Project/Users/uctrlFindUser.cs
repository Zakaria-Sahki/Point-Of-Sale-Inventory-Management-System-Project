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
    public partial class uctrlFindUser : UserControl
    {

        private enum enFilterMode { UserID = 0, PersonID = 1, Username = 2 }
        private enFilterMode _FilterMode = enFilterMode.UserID;

        public uctrlFindUser()
        {
            InitializeComponent();
        }

        public void RefreshControl() {

            cbFilteringType.SelectedIndex = 0;
            _FilterMode = enFilterMode.UserID;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
        private void cbFilteringType_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch ((enFilterMode)cbFilteringType.SelectedIndex) { 
                
                case enFilterMode.UserID:
                    _FilterMode = enFilterMode.UserID;
                    break;
                case enFilterMode.PersonID:
                    _FilterMode = enFilterMode.PersonID;
                    break;
                case enFilterMode.Username:
                    _FilterMode = enFilterMode.Username;
                    break;
                default:
                    _FilterMode = enFilterMode.UserID;
                    break;
            }
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
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
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
            }

            //this will allow only digits if person id or User id is selected
            if (cbFilteringType.SelectedIndex == 0 || cbFilteringType.SelectedIndex == 1)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            switch (_FilterMode) {

                case enFilterMode.UserID:
                    uctrlUserInfo1.DisplayingUserInfoByUserID(Convert.ToInt32(txtSearch.Text.Trim()));
                    break;
                case enFilterMode.PersonID:
                    uctrlUserInfo1.DisplayingUserInfoByPersonID(Convert.ToInt32(txtSearch.Text.Trim()));
                    break;
                case enFilterMode.Username:
                    uctrlUserInfo1.DisplayingUserInfoByUsername(txtSearch.Text.Trim());
                    break;
            }
        }
        private void uctrlFindUser_Load(object sender, EventArgs e)
        {
            cbFilteringType.SelectedIndex = 0;
            txtSearch.Text = string.Empty;
            txtSearch.Focus();
        }
    }
}
