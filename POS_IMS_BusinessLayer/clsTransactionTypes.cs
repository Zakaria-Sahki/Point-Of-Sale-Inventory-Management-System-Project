using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsTransactionTypes {


        public int TransactionTypeID { get; set; }
        public string TransactionTypeName { get; set; }

        private clsTransactionTypes(int TransactionTypeID, string TransactionTypeName) { 
            
            this.TransactionTypeID = TransactionTypeID;
            this.TransactionTypeName = TransactionTypeName;
        }

        static public DataTable GetAllTransactionTypes() { 
            
            return clsTransactionTypes_DataAccess.GetAllTransactionTypes();
        }
        static public clsTransactionTypes GetTransactionTypeByID(int TransactionTypeID) {

            string TransactionTypeName = "";
            if (clsTransactionTypes_DataAccess.GetTransactionTypeByID(TransactionTypeID, ref TransactionTypeName))
                return new clsTransactionTypes(TransactionTypeID, TransactionTypeName);
            else
            {
                return null;
            }
        }
    }
}
