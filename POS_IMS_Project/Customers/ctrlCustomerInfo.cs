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
    public partial class ctrlCustomerInfo : UserControl
    {
        private clsCustomers Customer;
        public ctrlCustomerInfo()
        {
            InitializeComponent();
        }

        public void DefaultTextLoad() { 
            
            lblCustomerID.Text = "[xxx]";
            lblFirstName.Text = "[xxx]";
            lblLastName.Text = "[xxx]";
            lblEmail.Text = "[xxx]";
            lblPhone.Text = "[xxx]";
            lblCredits.Text = "[xxx]";
            lblTotalSpent.Text = "[xxx]";
            lblPoints.Text = "[xxx]";
            txtNote.Text = string.Empty;
            linklblEditCustomer.Visible = false;
        }
        public void DisplayCustomerInfo(int CustomerID) { 
            
            Customer = clsCustomers.GetCustomerByID(CustomerID);
            if (Customer == null) {

                MessageBox.Show($"No Customer with ID [{CustomerID}]", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultTextLoad();
                return;
            }

            lblCustomerID.Text = Customer.CustomerID.ToString();
            lblFirstName.Text = Customer.PersonInfo.FirstName;
            lblLastName.Text = Customer.PersonInfo.LastName;
            lblEmail.Text = Customer.PersonInfo.Email;
            lblPhone.Text = Customer.PersonInfo.Phone;
            lblCredits.Text = Customer.Credits.ToString();
            lblTotalSpent.Text = Customer.TotalSpent.ToString();
            lblPoints.Text = Customer.Points.ToString();
            txtNote.Text = Customer.Notes;
            cBoxIsActive.Checked = Customer.IsActive;
            linklblEditCustomer.Visible = true;
            
        }

        private void linklblEditCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer(Customer.CustomerID);
            frm.ShowDialog();
            DisplayCustomerInfo(Customer.CustomerID);
        }
    }
}
