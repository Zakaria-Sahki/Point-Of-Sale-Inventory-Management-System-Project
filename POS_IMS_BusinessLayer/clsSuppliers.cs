using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsSuppliers {


        public int SupplierID { get; set; }
        public int PersonID_FK { get; set; }
        public clsPeople PersonInfo { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }

        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;



        public clsSuppliers(string Address, string CompanyName, bool IsActive, string Notes) { 
            
            this.Address = Address;
            this.CompanyName = CompanyName;
            this.IsActive = IsActive;
            this.Notes = Notes;
            _Mode = enMode.Add;
        }

        private clsSuppliers(int SupplierID, int PersonID_FK, string Address, string CompanyName, bool IsActive, string Notes) { 
            
            this.SupplierID = SupplierID;
            this.PersonID_FK = PersonID_FK;
            this.Address = Address;
            this.CompanyName = CompanyName;
            this.IsActive = IsActive;
            this.Notes = Notes;
            this.PersonInfo = clsPeople.GetPersonByID(PersonID_FK);
            _Mode = enMode.Update;
        }


        static public DataTable GetAllSuppliers() {

            return clsSuppliers_DataAccess.GetAllSuppliers();
        }
        public bool AddNewSupplier() {

            this.SupplierID = clsSuppliers_DataAccess.AddNewSupplier(this.PersonID_FK, this.Address, this.CompanyName, this.IsActive, this.Notes);
            return (this.SupplierID != -1);
        }
        public bool UpdateSupplier() {

            return clsSuppliers_DataAccess.UpdateSupplier(this.SupplierID, this.Address, this.CompanyName, this.IsActive, this.Notes);
        }
        static public bool DeleteSupplier(int SupplierID) {

            return clsSuppliers_DataAccess.DeleteSupplier(SupplierID);
        }
        static public clsSuppliers GetSupplierByID(int SupplierID) {

            int PersonID_FK = 0;
            string Address = "", CompanyName = "", Notes = "";
            bool IsActive = false;
            if (clsSuppliers_DataAccess.GetSupplierID(SupplierID, ref PersonID_FK, ref Address, ref CompanyName, ref IsActive, ref Notes))
            {
                return new clsSuppliers(SupplierID, PersonID_FK, Address, CompanyName, IsActive, Notes);
            }
            else
                return null;
        }



        public bool Save()
        {

            switch (_Mode)
            {

                case enMode.Add:
                    if (AddNewSupplier())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return UpdateSupplier();
            }
            return false;
        }
        static public bool IsSupplierWithPersonIDExist(int PersonID)
        {

            return clsSuppliers_DataAccess.IsSupplierWithPersonIDExist(PersonID);
        }
        static public bool IsSupplierWithSupplierIDExist(int SupplierID)
        {

            return clsSuppliers_DataAccess.IsSupplierWithSupplierIDExist(SupplierID);
        }
    }
}
