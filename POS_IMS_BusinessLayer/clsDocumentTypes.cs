using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsDocumentTypes {

        public int DocumentTypeID { get; set; }
        public string DocumentName { get; set; }

        private clsDocumentTypes(int DocumentTypeID, string DocumentName)
        {

            this.DocumentTypeID = DocumentTypeID;
            this.DocumentName = DocumentName;
        }

        static public DataTable GetAllDocumentTypes()
        {

            return clsDocumentTypes_DataAccess.GetAllDocumentTypes();
        }
        static public clsDocumentTypes GetTransactionTypeByID(int DocumentTypeID)
        {

            string DocumentName = "";
            if (clsDocumentTypes_DataAccess.GetDocumentTypeByID(DocumentTypeID, ref DocumentName))
                return new clsDocumentTypes(DocumentTypeID, DocumentName);
            else
            {
                return null;
            }
        }
    }
}
