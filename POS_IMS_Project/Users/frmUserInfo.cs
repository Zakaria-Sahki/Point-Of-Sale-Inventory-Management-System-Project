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
    public partial class frmUserInfo : Form
    {
        private int _UserID = -1;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _UserID = UserID;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            uctrlUserInfo1.DisplayingUserInfoByUserID(_UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
