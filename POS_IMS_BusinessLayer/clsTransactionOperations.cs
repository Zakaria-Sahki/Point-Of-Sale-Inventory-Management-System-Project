using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsTransactionOperations {

        static public bool LogNewSaleTransaction(int SaleID, int ProductID, int Quantity, decimal UnitPrice, int UserID) {

            int RowAffected = clsTransactionOperations_DataAccess.LogNewSaleTransaction(SaleID, ProductID, Quantity, UnitPrice, UserID);
            return (RowAffected > 0);
        }

        static public bool LogNewPurchaseTransaction(int PurchaseID, int ProductID, int Quantity, decimal UnitPrice, int UserID) {

            int RowAffected = clsTransactionOperations_DataAccess.LogNewPurchaseTransaction(PurchaseID, ProductID, Quantity, UnitPrice, UserID);
            return (RowAffected > 0);
        }

    }
}
