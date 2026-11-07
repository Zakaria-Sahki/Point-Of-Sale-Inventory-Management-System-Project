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
    public partial class MainForm : Form
    {
        private enum enSideBarMenue { Dashboard = 1, POS = 2, Inventory = 3, Transaction = 4, Users = 5, Suppliers = 6, Customers = 7, People = 8 }
        private enSideBarMenue CurrentMenue = enSideBarMenue.Dashboard;

        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(1100, 600);
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string Time = DateTime.Now.ToString("HH:mm");
        }
        private void ResetSideBarColors() {

            btnDashboard.BackColor = Color.FromArgb(13, 17, 23);
            btnDashboard.ForeColor = Color.FromArgb(226, 232, 240);

            btnPointOfSale.BackColor = Color.FromArgb(13, 17, 23);
            btnPointOfSale.ForeColor = Color.FromArgb(226, 232, 240);

            btnInventory.BackColor = Color.FromArgb(13, 17, 23);
            btnInventory.ForeColor = Color.FromArgb(226, 232, 240);

            btnTransactions.BackColor = Color.FromArgb(13, 17, 23);
            btnTransactions.ForeColor = Color.FromArgb(226, 232, 240);

            btnUsers.BackColor = Color.FromArgb(13, 17, 23);
            btnUsers.ForeColor = Color.FromArgb(226, 232, 240);

            btnCustomers.BackColor = Color.FromArgb(13, 17, 23);
            btnCustomers.ForeColor = Color.FromArgb(226, 232, 240);

            btnSuppliers.BackColor = Color.FromArgb(13, 17, 23);
            btnSuppliers.ForeColor = Color.FromArgb(226, 232, 240);

            btnPeople.BackColor = Color.FromArgb(13, 17, 23);
            btnPeople.ForeColor = Color.FromArgb(226, 232, 240);
        }
        private void SideBarActivation(enSideBarMenue ActiveSideBar) {

            Color ActiveBackColor = Color.FromArgb(30, 41, 59);
            Color ActiveForeColor = Color.FromArgb(14, 165, 233);

            ResetSideBarColors();

            switch (ActiveSideBar) { 
                
                case enSideBarMenue.Dashboard:
                    btnDashboard.BackColor = ActiveBackColor;
                    btnDashboard.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Dashboard;
                    break;
                case enSideBarMenue.POS:
                    btnPointOfSale.BackColor = ActiveBackColor;
                    btnPointOfSale.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.POS;

                    break;
                case enSideBarMenue.Inventory:
                    btnInventory.BackColor = ActiveBackColor;
                    btnInventory.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Inventory;

                    break;
                case enSideBarMenue.Transaction:
                    btnTransactions.BackColor = ActiveBackColor;
                    btnTransactions.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Transaction;

                    break;
                case enSideBarMenue.Users:
                    btnUsers.BackColor = ActiveBackColor;
                    btnUsers.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Users;

                    break;
                case enSideBarMenue.Suppliers:
                    btnSuppliers.BackColor = ActiveBackColor;
                    btnSuppliers.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Suppliers;

                    break;
                case enSideBarMenue.Customers:
                    btnCustomers.BackColor = ActiveBackColor;
                    btnCustomers.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.Customers;

                    break;
                case enSideBarMenue.People:
                    btnPeople.BackColor = ActiveBackColor;
                    btnPeople.ForeColor = ActiveForeColor;
                    CurrentMenue = enSideBarMenue.People;

                    break;
                default:
                    break;
            }
        
        }
        private void btnDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            SideBarActivation(enSideBarMenue.Dashboard);
            lblCurrentDashboard.Text = "Dashboard";
        }
        private void btnPointOfSale_MouseUp(object sender, MouseEventArgs e)
        {
            SideBarActivation(enSideBarMenue.POS);
            lblCurrentDashboard.Text = "POS";

        }
        private void btnInventory_MouseUp(object sender, MouseEventArgs e)
        {
            SideBarActivation(enSideBarMenue.Inventory);
            lblCurrentDashboard.Text = "Inventory";

        }
        private void btnTransactions_MouseUp(object sender, MouseEventArgs e)
        {
            SideBarActivation(enSideBarMenue.Transaction);
            lblCurrentDashboard.Text = "Transaction";

        }
        private void btnSuppliers_MouseUp(object sender, MouseEventArgs e)
        {
            SideBarActivation(enSideBarMenue.Suppliers);
            lblCurrentDashboard.Text = "Suppliers";
        }

        
        
        private void LoadUserControl(UserControl Usercontrol) {

            ContentPanel.Controls.Clear();
            Usercontrol.Dock = DockStyle.Fill;
            
            ContentPanel.Controls.Add(Usercontrol);
        }



        private void btnPeople_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.People)
            {

                LoadUserControl(new uctrlPeople());
            }
            SideBarActivation(enSideBarMenue.People);
            lblCurrentDashboard.Text = "People";
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            

            if (CurrentMenue != enSideBarMenue.Users)
            {

                LoadUserControl(new uctrlUsers());
            }

            SideBarActivation(enSideBarMenue.Users);
            lblCurrentDashboard.Text = "Users";
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.Customers)
            {

                LoadUserControl(new uctrlCustomers());
            }
            SideBarActivation(enSideBarMenue.Customers);
            lblCurrentDashboard.Text = "Customers";
        }
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.Suppliers)
            {

                LoadUserControl(new uctrlSuppliers());
            }
            SideBarActivation(enSideBarMenue.Suppliers);
            lblCurrentDashboard.Text = "Suppliers";
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.Inventory)
            {

                LoadUserControl(new uctrLInventory());
            }
            SideBarActivation(enSideBarMenue.Inventory);
            lblCurrentDashboard.Text = "Inventory";
        }

        private void btnPointOfSale_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.POS)
            {

                LoadUserControl(new uctrlPointOfSale());
            }
            SideBarActivation(enSideBarMenue.POS);
            lblCurrentDashboard.Text = "Point Of Sale";
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (CurrentMenue != enSideBarMenue.Transaction)
            {

                LoadUserControl(new uctrlTransactionsScreen());
            }
            SideBarActivation(enSideBarMenue.Transaction);
            lblCurrentDashboard.Text = "Transactions";
        }
    }
}
