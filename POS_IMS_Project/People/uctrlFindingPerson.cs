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
    public partial class uctrlFindingPerson : UserControl
    {
        private int PersonID = 0;

        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }
        

        public uctrlFindingPerson()
        {
            InitializeComponent();
        }


        public void DisableSearching() { 
            
            txtPersonID.Enabled = false;
            btnSearch.Enabled = false;
        }
        public void Loading() {

            linklblEditPerson.Visible = false;
            txtPersonID.Focus();
        }
        public void LoadPersonInfoDirectly(int PersonID)
        {
            // Load data when it called from add edit user / customer / supplier form
            txtPersonID.Text = PersonID.ToString().Trim();
            uctrolPersonInfo_1.DisplayPersonInfo(PersonID);
        }
        public void ResetAllInfoToDefault() {

            txtPersonID.Text = string.Empty;
            uctrolPersonInfo_1.ResetInfoToDefault();
            txtPersonID.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonID.Text.Trim()) || !txtPersonID.Text.All(char.IsDigit)) {

                MessageBox.Show("Inccorect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                linklblEditPerson.Visible = false;
                ResetAllInfoToDefault();
                return;
            }

            PersonID = Convert.ToInt32(txtPersonID.Text.Trim());

            if (clsPeople.GetPersonByID(PersonID) == null)
            {

                MessageBox.Show("Person with this ID not found.", "Error: Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linklblEditPerson.Visible = false;
                ResetAllInfoToDefault();
                return;

            }

            linklblEditPerson.Visible = true;
            uctrolPersonInfo_1.DisplayPersonInfo(PersonID);

            if (OnPersonSelected != null) { 
                
                OnPersonSelected(PersonID);
            }

        }
        private void txtPersonID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonID.Text.Trim()))
            {

                e.Cancel = true;
                txtPersonID.Focus();
                errorProvider1.SetError(txtPersonID, "PersonID Required!");
                return;
            }
            else {

                errorProvider1.SetError(txtPersonID, null);
            }

            if (!txtPersonID.Text.All(char.IsDigit))
            {

                e.Cancel = true;
                txtPersonID.Focus();
                errorProvider1.SetError(txtPersonID, "PersonID is a number");
            }
            else {

                errorProvider1.SetError(txtPersonID, null);
            }
        }
        private void linklblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            frm.ShowDialog();
            uctrolPersonInfo_1.DisplayPersonInfo(PersonID);
        }
        private void uctrlFindingPerson_Load(object sender, EventArgs e)
        {
            Loading();
        }
        
        
    }
}
