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
    public partial class uctrolPersonInfo_ : UserControl
    {
        public uctrolPersonInfo_()
        {
            InitializeComponent();
        }

        public void ResetInfoToDefault() {

            lblFirstName.Text = "[xxx]";
            lblLastName.Text = "[xxx]";
            lblEmail.Text = "[xxx]";
            lblPhone.Text = "[xxx]";
        }
        public bool DisplayPersonInfo(int PersonID)
        {

            bool IsFound = false;
            clsPeople Person = clsPeople.GetPersonByID(PersonID);
            if (Person != null)
            {
                IsFound = true;
                lblFirstName.Text = Person.FirstName;
                lblLastName.Text = Person.LastName;
                lblEmail.Text = Person.Email;
                lblPhone.Text = Person.Phone;
            }
            else
            {

                IsFound = false;
            }
            return IsFound;
        }
    }
}
