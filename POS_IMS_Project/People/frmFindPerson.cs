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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_IMS_Project
{
    public partial class frmFindPerson : Form
    {

        private int _PersonID = -1;

        public frmFindPerson()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            uctrlFindingPerson1.Loading();
        }
    }
}
