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
    public partial class uctrlDraftedBaskets : UserControl
    {
        private int _DraftID = -1;
        public uctrlDraftedBaskets()
        {
            InitializeComponent();
        }


        //public delegate void OnDrarftRemoved();
        // Create a protected method to raise the event with a parameter
        

       public event EventHandler DrarftRemoved;




        public void DisplayDraftInfo(int DraftID, DateTime Date, decimal TotalAmount, int NumOfProducts) {

            _DraftID = DraftID;
            lblDraftTitle.Text = "Draft " + DraftID.ToString();
            lblDate.Text = Date.ToString();
            lblTotalPrice.Text = TotalAmount.ToString() + " DZD";
            lblCountProducts.Text = NumOfProducts.ToString() + " Product(s)";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to resotre this suspended invoice ?", "Confirm Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                uctrlPointOfSale.CurrentSale = uctrlPointOfSale.drafts.FirstOrDefault(n => n.SaleID == _DraftID);
                uctrlPointOfSale.drafts.Remove(uctrlPointOfSale.drafts.FirstOrDefault(n => n.SaleID == _DraftID));
                DrarftRemoved?.Invoke(this, e);
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to permanently delete this suspended invoice ?", "Confirm Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {

                uctrlPointOfSale.drafts.Remove(uctrlPointOfSale.drafts.FirstOrDefault(n => n.SaleID == _DraftID));
                DrarftRemoved?.Invoke(this, e);
            }
        }
    }
}
