using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsUsers_DataAccess {

        static public DataTable DisplayAllUsers()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DisplayAllUsers", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
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


            }
            return dt;
        }
        static public DataTable GetAllUsers() { 
            
            DataTable dt = new DataTable();
            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllUsers", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
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
            catch (Exception Ex) { 
                

            }
            return dt;   
        }
        static public int AddNewUser(int PersonID_FK, string Username, string HashedPassword, int Permissions) {

            int UserID = -1;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID_FK", PersonID_FK);
                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@HashedPassword", HashedPassword);
                        Command.Parameters.AddWithValue("@Permissions", Permissions);

                        SqlParameter outputIDparam = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        UserID = (int)Command.Parameters["@NewUserID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                UserID = -1;
            }


            return UserID;
        }
        static public bool UpdateUser(int UserID, string Username, string HashedPassword, int Permissions, bool IsActive) {


            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@HashedPassword", HashedPassword);
                        command.Parameters.AddWithValue("@Permissions", Permissions);
                        command.Parameters.AddWithValue("@IsActive", IsActive);


                        RowAffected = (int)command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception Ex)
            {

                RowAffected = 0;
            }
            return (RowAffected > 0);
        }
        static public bool DeleteUser(int UserID) {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        RowAffected = (int)command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {

                RowAffected = 0;
            }
            return (RowAffected > 0);
        }
        static public bool GetUserByID(int UserID, ref int PersonID_FK, ref string Username, ref string HashedPassword, ref int Permissions, ref bool IsActive) {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetUserByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@UserID", UserID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PersonID_FK = Convert.ToInt32(Reader["PersonID_FK"]);
                                Username = Reader["Username"].ToString();
                                HashedPassword = Reader["HashedPassword"].ToString();
                                Permissions = Convert.ToInt32(Reader["Permissions"]);
                                IsActive = Convert.ToBoolean(Reader["IsActive"]);
                            }
                            else
                            {

                                IsFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception Ex)
            {

                IsFound = false;
            }
            return IsFound;
        }
        static public void GetUsersInfo(ref int NumOfAdmins, ref int NumOfManagers, ref int NumOfCashiers, ref int NumOfActiveUsers) {

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_InformationAboutUsers", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        SqlParameter outputAdminsparam = new SqlParameter("@NumOfAdmins", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputAdminsparam);

                        SqlParameter outputManagersparam = new SqlParameter("@NumOfManagers", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputManagersparam);

                        SqlParameter outputCashiersparam = new SqlParameter("@NumOfCashiers", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputCashiersparam);

                        SqlParameter outputActiveparam = new SqlParameter("@NumOfActiveUsers", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputActiveparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();

                        NumOfAdmins = (int)Command.Parameters["@NumOfAdmins"].Value;
                        NumOfManagers = (int)Command.Parameters["@NumOfManagers"].Value;
                        NumOfCashiers = (int)Command.Parameters["@NumOfCashiers"].Value;
                        NumOfActiveUsers = (int)Command.Parameters["@NumOfActiveUsers"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                
            }


            
        }
        static public bool IsUserWithPersonIDExist(int PersonID) {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT IsFound = 1 FROM Users WHERE PersonID_FK = @PersonID_FK;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID_FK", PersonID);

                        object result = Command.ExecuteScalar();

                        if (result == null)
                        {

                            IsFound = false;
                        }
                        else
                        {

                            IsFound = true;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                IsFound = false;
            }
            return IsFound;
        }
        static public bool IsUserWithUsernameExist(string Username) {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT IsFound = 1 FROM Users WHERE Username = @Username;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Username", Username);

                        object result = Command.ExecuteScalar();

                        if (result == null)
                        {

                            IsFound = false;
                        }
                        else
                        {

                            IsFound = true;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

                IsFound = false;
            }
            return IsFound;
        }


        static public bool GetUserByPersonID(int PersonID_FK, ref int UserID, ref string Username, ref string HashedPassword, ref int Permissions, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetUserByPersonID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", PersonID_FK);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                UserID = Convert.ToInt32(Reader["UserID"]);
                                Username = Reader["Username"].ToString();
                                HashedPassword = Reader["HashedPassword"].ToString();
                                Permissions = Convert.ToInt32(Reader["Permissions"]);
                                IsActive = Convert.ToBoolean(Reader["IsActive"]);
                            }
                            else
                            {

                                IsFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception Ex)
            {

                IsFound = false;
            }
            return IsFound;
        }
        static public bool GetUserByUsername(string Username, ref int UserID, ref int PersonID_FK, ref string HashedPassword, ref int Permissions, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetUserByUsername", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Username", Username);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                UserID = Convert.ToInt32(Reader["UserID"]);
                                PersonID_FK = Convert.ToInt32(Reader["PersonID_FK"]);
                                HashedPassword = Reader["HashedPassword"].ToString();
                                Permissions = Convert.ToInt32(Reader["Permissions"]);
                                IsActive = Convert.ToBoolean(Reader["IsActive"]);
                            }
                            else
                            {

                                IsFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception Ex)
            {

                IsFound = false;
            }
            return IsFound;
        }
    }
}
