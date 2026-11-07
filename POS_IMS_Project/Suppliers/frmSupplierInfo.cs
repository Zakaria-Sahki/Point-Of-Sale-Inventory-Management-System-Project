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
    public partial class frmSupplierInfo : Form
    {

        private int _SupplierID = -1;

        public frmSupplierInfo(int SupplierID)
        {
            InitializeComponent();
            _SupplierID = SupplierID;
            this.Size = new Size(735, 510);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplierInfo_Load(object sender, EventArgs e)
        {
            ctrlSupplierInfo1.DisplaySupplierInfo(_SupplierID);
        }
    }
}
