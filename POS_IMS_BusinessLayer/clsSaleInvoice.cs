using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsSaleInvoice {


        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerID_FK { get; set; }
        public int UserID_FK { get; set; }
        public decimal TotalAmount { get; set; }
        public clsUsers UserInfo { get; set; }
        public clsCustomers CustomerInfo { get; set; }


        private clsSaleInvoice(int CustomerID_FK, int UserID_FK, Decimal TotalAmount)
        {

            this.CustomerID_FK = CustomerID_FK;
            this.UserID_FK = UserID_FK;
            this.TotalAmount = TotalAmount;
        }
        private clsSaleInvoice(int SaleID, DateTime SaleDate, int CustomerID_FK, int UserID_FK, decimal TotalAmount) {
            
            this.SaleID = SaleID;
            this.SaleDate = SaleDate;
            this.CustomerID_FK = CustomerID_FK;
            this.UserID_FK = UserID_FK;
            this.TotalAmount = TotalAmount;
            this.UserInfo = clsUsers.GetUserByID(this.UserID_FK);
            this.CustomerInfo = clsCustomers.GetCustomerByID(this.CustomerID_FK);
        }

        static public int LogSaleInvoice(int CustomerID_FK, int UserID_FK, Decimal TotalAmount)
        {

            int SaleID = -1;
            SaleID = clsSaleInvoices_DataAccess.LogNewSaleInvoice(CustomerID_FK, UserID_FK, TotalAmount);
            return SaleID;
        }
        static public DataTable GetAllSaleInvoices() {

            return clsSaleInvoices_DataAccess.GetAllSaleInvoices();
        }    
        static public clsSaleInvoice GetSaleInvoiceByID(int SaleID) {

            int CustomerID_FK = 0, UserID_FK = 0;
            decimal TotalAmount = 0;
            DateTime SaleDate = DateTime.MinValue;

            if (clsSaleInvoices_DataAccess.GetSaleInvoiceByID(SaleID, ref SaleDate, ref CustomerID_FK, ref UserID_FK, ref TotalAmount))
            {

                return new clsSaleInvoice(SaleID, SaleDate, CustomerID_FK, UserID_FK, TotalAmount);
            }
            else
                return null;
        }
    }
}
