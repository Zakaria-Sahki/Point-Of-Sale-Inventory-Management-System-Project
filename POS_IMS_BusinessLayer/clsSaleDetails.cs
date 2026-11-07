using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace POS_IMS_BusinessLayer
{
    public class clsSaleDetails {


        public int SaleDetailID { get; set; }
        public int SaleID_FK { get; set; }
        public int ProductID_FK { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public clsProduct ProductInfo { get; set; }


        private clsSaleDetails(int SaleDetailID, int SaleID_FK, int ProductID_FK, int Quantity, Decimal UnitPrice) { 
            
            this.SaleDetailID = SaleDetailID;
            this.SaleID_FK = SaleID_FK;
            this.ProductID_FK = ProductID_FK;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.ProductInfo = clsProduct.GetProductByID(this.ProductID_FK);
        }

        static public DataTable GetAllSaleDetails() {

            return clsSaleDetails_DataAccess.GetAllSaleDetails();
        }
        static public DataTable GetSaleDetailsBySaleID(int SaleID) {

            return clsSaleDetails_DataAccess.GetSaleDetailsBySaleID(SaleID);
        }
        static public clsSaleDetails GetSaleDetailBySaleDetailID(int SaleDetailID) {

            int SaleID_FK = 0, ProductID_FK = 0, Quantity = 0;
            Decimal UnitPrice = 0;

            if (clsSaleDetails_DataAccess.GetSaleDetailBySaleDetailID(SaleDetailID, ref SaleID_FK, ref ProductID_FK, ref Quantity, ref UnitPrice))
                return new clsSaleDetails(SaleDetailID, SaleID_FK, ProductID_FK, Quantity, UnitPrice);
            else
                return null;
        }
    }
}
