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
    public partial class uctrlCategoryInfo : UserControl
    {
        private clsCategory _Category;
        private int _CategoryID = -1;

        public uctrlCategoryInfo()
        {
            InitializeComponent();
        }
        public void RefereshToDefaultValues() {


            _CategoryID = -1;
            linklblEditCategory.Visible = false;
            lblCategoryID.Text = "[xxx]";
            lblCategoryName.Text = "[xxx]";
            txtCategoryDescription.Text = string.Empty;
            cboxIsActive.Checked = true;
        }
        public void DisplayCategoryInfoByID(int CategoryID) { 
            
            _Category = clsCategory.GetCategoryByID(CategoryID);
            if (_Category == null) {

                MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _CategoryID = _Category.CategoryID;
            linklblEditCategory.Visible = true;
            lblCategoryID.Text = _Category.CategoryID.ToString();
            lblCategoryName.Text = _Category.CategoryName;
            txtCategoryDescription.Text = _Category.CategoryDescription;
            cboxIsActive.Checked = _Category.IsActive;
        }
        private void linklblEditCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditCategory frm = new frmAddEditCategory(_CategoryID);
            frm.ShowDialog();
            DisplayCategoryInfoByID(_CategoryID);
        }
    }
}
