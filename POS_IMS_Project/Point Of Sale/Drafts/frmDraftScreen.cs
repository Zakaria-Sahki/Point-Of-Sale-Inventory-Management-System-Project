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
    public partial class frmDraftScreen : Form
    {
        public frmDraftScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FillDraftScreen() {

            foreach (uctrlPointOfSale.clsSaleBasket Draft in uctrlPointOfSale.drafts) {

                uctrlDraftedBaskets uDraft = new uctrlDraftedBaskets();
                uDraft.DrarftRemoved += OnDraftRemoved;
                uDraft.DisplayDraftInfo(Draft.SaleID, Draft.DateOfDraft, Draft.TotalAmount, Draft.SelectedProducts.Count());
                flpDrafts.Controls.Add(uDraft);
            }
        }

        private void OnDraftRemoved(object sender, EventArgs e) {

            flpDrafts.Controls.Clear();
            FillDraftScreen();
            this.Close();
        }
        private void frmDraftScreen_Load(object sender, EventArgs e)
        {
            FillDraftScreen();

        }
    }
}
