using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsPurchaseDetails {


        public int PurchaseDetailID { get; set; }
        public int PurchaseID_FK { get; set; }
        public int ProductID_FK { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public clsProduct ProductInfo { get; set; }


        private clsPurchaseDetails(int PurchaseDetailID, int PurchaseID_FK, int ProductID_FK, int Quantity, Decimal UnitPrice)
        {

            this.PurchaseDetailID = PurchaseDetailID;
            this.PurchaseID_FK = PurchaseID_FK;
            this.ProductID_FK = ProductID_FK;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.ProductInfo = clsProduct.GetProductByID(this.ProductID_FK);
        }


        static public DataTable GetAllPurchaseDetails()
        {

            return clsPurchaseDetails_DataAccess.GetAllPurchaseDetails();
        }
        static public DataTable GetPurchaseDetailsByPurchaseID(int PurchaseID)
        {

            return clsPurchaseDetails_DataAccess.GetPurchaseDetailsByPurchaseID(PurchaseID);
        }
        static public clsPurchaseDetails GetPurchaseDetailByPurchaseDetailID(int PurchaseDetailID)
        {

            int PurchaseID_FK = 0, ProductID_FK = 0, Quantity = 0;
            Decimal UnitPrice = 0;

            if (clsPurchaseDetails_DataAccess.GetPurchaseDetailByPurchaseDetailID(PurchaseDetailID, ref PurchaseID_FK, ref ProductID_FK, ref Quantity, ref UnitPrice))
                return new clsPurchaseDetails(PurchaseDetailID, PurchaseID_FK, ProductID_FK, Quantity, UnitPrice);
            else
                return null;
        }

    }
}
