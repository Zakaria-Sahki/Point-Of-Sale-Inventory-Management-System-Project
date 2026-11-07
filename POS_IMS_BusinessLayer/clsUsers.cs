using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_IMS_BusinessLayer
{
    public class clsUsers {

        public int UserID { get; set; }
        public int PersonID_FK { get; set; }
        public clsPeople PersonInfo { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }

        private enum enMode { Add = 1, Update = 2}
        enMode Mode = enMode.Add;



        public clsUsers(string Username, string HashedPassword, int Permissions) { 
            


            this.Username = Username;
            this.HashedPassword = HashedPassword;
            this.Permissions = Permissions;
            this.IsActive = true;
            Mode = enMode.Add;
        }

        private clsUsers(int UserID, int PersonID_FK, string Username, string HashedPassword, int Permissions, bool IsActive)
        {

            this.UserID = UserID;
            this.PersonID_FK = PersonID_FK;
            this.PersonInfo = clsPeople.GetPersonByID(this.PersonID_FK);
            this.Username = Username;
            this.HashedPassword = HashedPassword;
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            Mode = enMode.Update;

        }

        static public DataTable DisplayAllUsers()
        {

            return clsUsers_DataAccess.DisplayAllUsers();
        }
        static public DataTable GetAllUsers() { 
            
            return clsUsers_DataAccess.GetAllUsers();
        }
        public bool AddNewUser() {

            this.UserID = clsUsers_DataAccess.AddNewUser(this.PersonID_FK, this.Username, this.HashedPassword, this.Permissions);
            return (this.UserID != -1);
        }
        static public bool DeleteUser(int UserID) {

            return clsUsers_DataAccess.DeleteUser(UserID);
        }
        public bool UpdateUser() {

            return clsUsers_DataAccess.UpdateUser(this.UserID, this.Username, this.HashedPassword, this.Permissions, this.IsActive);
        }
        static public clsUsers GetUserByID(int UserID) {

            string Username = "", HashedPassword = "";
            int PersonID_FK = 0, Permissions = 0;
            bool IsActive = true;

            if (clsUsers_DataAccess.GetUserByID(UserID, ref PersonID_FK, ref Username, ref HashedPassword, ref Permissions, ref IsActive))
            {

                return new clsUsers(UserID, PersonID_FK, Username, HashedPassword, Permissions, IsActive);
            }
            else
                return null;
        }
        static public clsUsers GetUserByPersonID(int PersonID)
        {

            string Username = "", HashedPassword = "";
            int UserID = 0, Permissions = 0;
            bool IsActive = true;

            if (clsUsers_DataAccess.GetUserByPersonID(PersonID, ref UserID, ref Username, ref HashedPassword, ref Permissions, ref IsActive))
            {

                return new clsUsers(UserID, PersonID, Username, HashedPassword, Permissions, IsActive);
            }
            else
                return null;
        }
        static public clsUsers GetUserByUsername(string Username)
        {

            string HashedPassword = "";
            int UserID = 0, Permissions = 0, PersonID_FK = 0;
            bool IsActive = true;

            if (clsUsers_DataAccess.GetUserByUsername(Username, ref UserID, ref PersonID_FK, ref HashedPassword, ref Permissions, ref IsActive))
            {

                return new clsUsers(UserID, PersonID_FK, Username, HashedPassword, Permissions, IsActive);
            }
            else
                return null;
        }
        static public bool IsUserWithPersonIDExist(int PersonID) {

            return clsUsers_DataAccess.IsUserWithPersonIDExist(PersonID);
        }
        static public void GetUsersInformation(ref int NumOfAdmins, ref int NumOfManagers, ref int NumOfCashiers, ref int NumOfActiveUsers) {
            
            clsUsers_DataAccess.GetUsersInfo(ref NumOfAdmins, ref NumOfManagers, ref NumOfCashiers, ref NumOfActiveUsers);
        }
        public bool Save() {

            switch (Mode) {

                case enMode.Add:
                    if (AddNewUser()) {

                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return UpdateUser();
            }
            return false;
        }
        static public bool IsUserWithUsernameExist(string Username) {

            return clsUsers_DataAccess.IsUserWithUsernameExist(Username);
        }
    }
}
