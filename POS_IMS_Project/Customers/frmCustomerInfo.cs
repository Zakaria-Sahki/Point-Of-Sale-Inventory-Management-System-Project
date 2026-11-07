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
    public partial class frmCustomerInfo : Form
    {

        private int _CustomerID = -1;

        public frmCustomerInfo(int customerID)
        {
            InitializeComponent();
            _CustomerID = customerID;
            this.Size = new Size(730, 530);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            ctrlCustomerInfo1.DisplayCustomerInfo(_CustomerID);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Close button
            this.Close();
        }
    }
}
