using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsCustomers {


        public int CustomerID { get; set; }
        public int PersonID_FK { get; set; }
        public int Points { get; set; }
        public decimal Credits { get; set; }
        public decimal TotalSpent { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public clsPeople PersonInfo { get; set; }


        private enum enMode { Add = 1, Update = 2 }
        private enMode _Mode = enMode.Add;


        public clsCustomers(int Points, decimal Credits, decimal TotalSpent, bool IsActive, string Notes) { 
            
            this.Points = Points;
            this.Credits = Credits;
            this.TotalSpent = TotalSpent;
            this.IsActive = IsActive;
            this.Notes = Notes;
            _Mode = enMode.Add;
        }
        private clsCustomers(int CustomerID, int PersonID_FK, int Points, decimal Credits, decimal TotalSpent, bool IsActive, string Notes) {

            this.CustomerID = CustomerID;
            this.PersonID_FK = PersonID_FK;
            this.Points = Points;
            this.Credits = Credits;
            this.TotalSpent = TotalSpent;
            this.IsActive = IsActive;
            this.Notes = Notes;
            this.PersonInfo = clsPeople.GetPersonByID(PersonID_FK);
            _Mode = enMode.Update;
        }


        static public DataTable GetAllCustomers() {

            return clsCustomers_DataAcceess.GetAllCustomers();
        }
        static public clsCustomers GetCustomerByID(int CustomerID) {

            int PersonID_FK = 0, Points = 0;
            decimal Credits = 0, TotalSpent = 0;
            bool IsActive = false;
            string Notes = "";

            if (clsCustomers_DataAcceess.GetCustomerByID(CustomerID, ref PersonID_FK, ref Points, ref Credits, ref TotalSpent, ref IsActive, ref Notes)) {

                return new clsCustomers(CustomerID, PersonID_FK, Points, Credits, TotalSpent, IsActive, Notes);
            }
            else
                return null;
        }
        static public bool DeleteCustomer(int CustomerID) { 
            
            return clsCustomers_DataAcceess.DeleteCustomer(CustomerID);
        }
        private bool AddNewCustomer() {

            this.CustomerID = clsCustomers_DataAcceess.AddNewCustomer(this.PersonID_FK, this.Points, this.Credits, this.TotalSpent, this.IsActive, this.Notes);
            return (this.CustomerID != -1);
        }
        private bool UpdateCustomer() {

            return clsCustomers_DataAcceess.UpdateCustomer(this.CustomerID, this.Points, this.Credits, this.TotalSpent, this.IsActive, this.Notes);
        }

        public bool Save() {

            switch (_Mode) {

                case enMode.Add:
                    if (AddNewCustomer()) {

                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return UpdateCustomer();
            }
            return false;
        }


        static public bool IsCustomerWithPersonIDExist(int PersonID) {

            return clsCustomers_DataAcceess.IsCustomerWithPersonIDExist(PersonID);
        }

        static public bool IsCustomerWithCustomerIDExist(int CustomerID)
        {

            return clsCustomers_DataAcceess.IsCustomerWithCustomerIDExist(CustomerID);
        }
    }
}
