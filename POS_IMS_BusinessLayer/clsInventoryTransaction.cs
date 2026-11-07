using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsInventoryTransaction
    {
        public static DataTable GetAllInventoryTransactionsByProductID(int ProductID)
        {

            return clsInventoryTransactions_DataAccess.GetAllInventoryTransactionsByProductID(ProductID);
        }
        public static DataTable GetAllInventoryTransactions() { 
            
            return clsInventoryTransactions_DataAccess.GetAllInventoryTransactions();
        }
    }
}
