using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsPurchaseInvoice {


        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int SupplierID_FK { get; set; }
        public int UserID_FK { get; set; }
        public decimal TotalAmount { get; set; }
        public clsUsers UserInfo { get; set; }
        public clsSuppliers SupplierInfo { get; set; }

        private clsPurchaseInvoice(int SupplierID_FK, int UserID_FK, Decimal TotalAmount)
        {

            this.SupplierID_FK = SupplierID_FK;
            this.UserID_FK = UserID_FK;
            this.TotalAmount = TotalAmount;
        }
        private clsPurchaseInvoice(int PurchaseID, DateTime PurchaseDate, int SupplierID_FK, int UserID_FK, decimal TotalAmount)
        {

            this.PurchaseID = PurchaseID;
            this.PurchaseDate = PurchaseDate;
            this.SupplierID_FK = SupplierID_FK;
            this.UserID_FK = UserID_FK;
            this.TotalAmount = TotalAmount;
            this.UserInfo = clsUsers.GetUserByID(this.UserID_FK);
            this.SupplierInfo = clsSuppliers.GetSupplierByID(this.SupplierID_FK);
        }
        
        static public int LogPurchaseInvoice(int SupplierID_FK, int UserID_FK, Decimal TotalAmount) {

            int PurchaseID = -1;
            PurchaseID = clsPurchaseInvoices_DataAccess.LogNewPurchaseInvoice(SupplierID_FK, UserID_FK, TotalAmount);
            return PurchaseID;
        }
        static public DataTable GetAllPurchaseInvoices()
        {

            return clsPurchaseInvoices_DataAccess.GetAllPurchaseInvoices();
        }
        static public clsPurchaseInvoice GetPurchaseInvoiceByID(int PurchaseID)
        {

            int SupplierID_FK = 0, UserID_FK = 0;
            decimal TotalAmount = 0;
            DateTime PurchaseDate = DateTime.MinValue;

            if (clsPurchaseInvoices_DataAccess.GetPurchaseInvoiceByID(PurchaseID, ref PurchaseDate, ref SupplierID_FK, ref UserID_FK, ref TotalAmount))
            {

                return new clsPurchaseInvoice(PurchaseID, PurchaseDate, SupplierID_FK, UserID_FK, TotalAmount);
            }
            else
                return null;
        }
    }
}
// I made the constructor used in log a purchase invoice also as a private constructor.