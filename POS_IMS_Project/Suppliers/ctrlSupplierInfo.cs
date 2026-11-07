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
    public partial class ctrlSupplierInfo : UserControl
    {

        private clsSuppliers Supplier;

        public ctrlSupplierInfo()
        {
            InitializeComponent();
        }

        public void DefaultTextLoad()
        {

            lblSupplierID.Text = "[xxx]";
            lblFirstName.Text = "[xxx]";
            lblLastName.Text = "[xxx]";
            lblEmail.Text = "[xxx]";
            lblPhone.Text = "[xxx]";
            lblAddress.Text = "[xxx]";
            lblCompanyName.Text = "[xxx]";
            txtNote.Text = string.Empty;
            linklblEditSupplier.Visible = false;
        }
        public void DisplaySupplierInfo(int SupplierID)
        {

            Supplier = clsSuppliers.GetSupplierByID(SupplierID);
            if (Supplier == null)
            {

                MessageBox.Show($"No Supplier with ID [{SupplierID}]", "Supplier Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DefaultTextLoad();
                return;
            }

            lblSupplierID.Text = Supplier.SupplierID.ToString();
            lblFirstName.Text = Supplier.PersonInfo.FirstName;
            lblLastName.Text = Supplier.PersonInfo.LastName;
            lblEmail.Text = Supplier.PersonInfo.Email;
            lblPhone.Text = Supplier.PersonInfo.Phone;
            lblAddress.Text = Supplier.Address;

            lblCompanyName.Text = Supplier.CompanyName != "" ? Supplier.CompanyName : "";

            txtNote.Text = Supplier.Notes;
            cBoxIsActive.Checked = Supplier.IsActive;
            linklblEditSupplier.Visible = true;

        }
        private void linklblEditSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditSupplier frm = new frmAddEditSupplier(Supplier.SupplierID);
            frm.ShowDialog();
            DisplaySupplierInfo(Supplier.SupplierID);
        }
    }
}
