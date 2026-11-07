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
    public partial class frmProductInfo : Form
    {
        private int _ProductID;
        private clsProduct _Product;
        public frmProductInfo(int ProductID)
        {
            InitializeComponent();
            this.Size = new Size(908, 562);
            this.StartPosition = FormStartPosition.CenterScreen;
            _ProductID = ProductID;
        }
        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            _Product = clsProduct.GetProductByID(_ProductID);
            if (_Product == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            uctrlProductInfo1.DisplayProductInfo(_ProductID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
