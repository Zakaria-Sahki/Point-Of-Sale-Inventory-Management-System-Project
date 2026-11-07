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
    public partial class frmBrandInfo : Form
    {

        private int _brandID = -1;
        private clsBrands _Brand;

        public frmBrandInfo(int BrandID)
        {
            InitializeComponent();
            _brandID = BrandID;
            this.StartPosition = FormStartPosition.CenterScreen;
            linklblEditBrand.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadForm() {

            _Brand = clsBrands.GetBrandByID(_brandID);

            if (_Brand == null)
            {

                MessageBox.Show("Brand not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linklblEditBrand.Enabled = false;
                this.Close();
            }

            linklblEditBrand.Enabled = true;
            lblBrandName.Text = _Brand.BrandName;
            txtBrandDescription.Text = _Brand.BrandDescription;
            lblBrandID.Text = _Brand.BrandID.ToString();
            cboxIsActive.Checked = _Brand.IsActive;
        }
        private void frmBrandInfo_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void linklblEditBrand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditBrands frm = new frmAddEditBrands(_brandID);
            frm.ShowDialog();
            LoadForm();
        }
    }
}
