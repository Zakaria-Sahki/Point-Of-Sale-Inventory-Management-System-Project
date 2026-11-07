using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsRole {


        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public clsRole()
        {

            RoleID = 0;
            RoleName = "";
        }
        private clsRole(int RoleID, string RoleName)
        {

            this.RoleID = RoleID;
            this.RoleName = RoleName;
        }
        static public DataTable GetAllRoles()
        {

            return clsRole_DataAccess.GetAllRoles();
        }
        static public clsRole Find(int RoleID)
        {

            string RoleName = "";
            if (clsRole_DataAccess.GetRoleInfoByID(RoleID, ref RoleName))
            {

                return new clsRole(RoleID, RoleName);
            }
            else
                return null;
        }
        static public clsRole Find(string RoleName)
        {

            int RoleID = -1;
            if (clsRole_DataAccess.GetRoleInfoByName(RoleName, ref RoleID))
            {

                return new clsRole(RoleID, RoleName);
            }
            else
                return null;
        }
    }
}
