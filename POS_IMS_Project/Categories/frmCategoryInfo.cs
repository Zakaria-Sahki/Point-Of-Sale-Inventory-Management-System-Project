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
    public partial class frmCategoryInfo : Form
    {
        private int _CategoryID = -1;
        public frmCategoryInfo(int CategoryID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _CategoryID = CategoryID;
        }
        private void frmCategoryInfo_Load(object sender, EventArgs e)
        {
            uctrlCategoryInfo1.DisplayCategoryInfoByID(_CategoryID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
