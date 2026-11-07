using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsCategories_DataAccess {


        static public DataTable GetAllCategories()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllCategories", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            while (Reader.HasRows)
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
        static public int AddNewCategory(string CategoryName, string CategoryDescription)
        {

            int NewCategoryID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewCategory", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        Command.Parameters.AddWithValue("@CategoryDescription", CategoryDescription);


                        SqlParameter outputIDparam = new SqlParameter("@NewCategoryID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewCategoryID = (int)Command.Parameters["@NewCategoryID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewCategoryID = -1;
            }


            return NewCategoryID;
        }
        static public bool UpdateCategory(int CategoryID, string CategoryName, string CategoryDescription, bool IsActive)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateCategory", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        command.Parameters.AddWithValue("@CategoryDescription", CategoryDescription);
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
        static public bool GetCategoryByID(int CategoryID, ref string CategoryName, ref string CategoryDescription, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetCategoryByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                CategoryName = Reader["CategoryName"].ToString();
                                CategoryDescription = Reader["CategoryDescription"].ToString();
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
        static public bool DeleteCategory(int CategoryID)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteCategory", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
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
        static public bool GetCategoryByCategoryName(string CategoryName, ref int CategoryID, ref string CategoryDescription, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetCategoryByName", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CategoryName", CategoryName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                CategoryID = Convert.ToInt32(Reader["CategoryID"]);
                                CategoryDescription = Reader["CategoryDescription"].ToString();
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
