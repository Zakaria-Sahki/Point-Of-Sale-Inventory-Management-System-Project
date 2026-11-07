using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsPeople {

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        enum enMode { AddNewPerson = 1, UpdatePerson = 2 }
        enMode Mode = enMode.AddNewPerson;

        public clsPeople(string FirstName, string LastName, string Email, string Phone) { 
            
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            Mode = enMode.AddNewPerson;
        }

        private clsPeople(int PersonID, string FirstName, string LastName, string Email, string Phone) { 
            
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Mode = enMode.UpdatePerson;
        }



        static public DataTable GetAllPeople() { 
            
            return clsPeople_DataAccess.GetAllPeople();
        }
        public bool AddNewPerson() {

            this.PersonID = clsPeople_DataAccess.AddNewPerson(this.FirstName, this.LastName, this.Email, this.Phone);
            return (this.PersonID != -1);
        }
        public bool UpdatePerson() {

            return clsPeople_DataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.Email, this.Phone);
        }
        static public clsPeople GetPersonByID(int PersonID) {

            string FirstName = "", LastName = "", Email = "", Phone = "";

            if (clsPeople_DataAccess.GetPersonByID(PersonID, ref FirstName, ref LastName, ref Email, ref Phone))
            {

                return new clsPeople(PersonID, FirstName, LastName, Email, Phone);
            }
            else { 
                
                return null;
            }
        }
        static public bool DeletePerson(int PersonID) { 
        
            return clsPeople_DataAccess.DeletePerson(PersonID);
        }

        public bool Save() {

            switch (this.Mode) {

                case enMode.AddNewPerson:
                    if (AddNewPerson()) {

                        Mode = enMode.UpdatePerson;
                        return true;
                    }
                    break;
                case enMode.UpdatePerson:
                    return UpdatePerson();
                default:
                    return false;
            }
            return false;
        }
    }
}
