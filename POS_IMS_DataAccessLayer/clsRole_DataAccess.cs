using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsRole_DataAccess {

        static public bool GetRoleInfoByID(int RoleID, ref string RoleName)
        {

            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT * FROM Permissions WHERE RoleID = @RoleID;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@RoleID", RoleID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                isFound = true;
                                RoleName = (string)Reader["RoleName"];
                            }
                            else
                            {

                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                isFound = false;
            }

            return isFound;
        }
        static public bool GetRoleInfoByName(string RoleName, ref int RoleID)
        {

            bool isFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT * FROM Permissions WHERE RoleName = @RoleName;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@RoleName", RoleName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                isFound = true;
                                RoleID = (int)Reader["RoleID"];
                            }
                            else
                            {

                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                isFound = false;
            }

            return isFound;
        }
        static public DataTable GetAllRoles()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT * FROM Permissions;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.HasRows)
                            {

                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                Console.WriteLine("Database connection error: " + Ex.Message);
            }
            return dt;
        }

    }
}
