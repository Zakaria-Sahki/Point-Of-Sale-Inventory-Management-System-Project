using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsBrands_DataAccess {


        static public DataTable GetAllBrands() {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllBrands", Connection))
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
        static public int AddNewBrand(string BrandName, string BrandDescription, bool IsActive)
        {

            int NewBrandID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewBrand", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BrandName", BrandName);
                        Command.Parameters.AddWithValue("@BrandDescription", BrandDescription);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);


                        SqlParameter outputIDparam = new SqlParameter("@NewBrandID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewBrandID = (int)Command.Parameters["@NewBrandID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewBrandID = -1;
            }


            return NewBrandID;
        }
        static public bool UpdateBrand(int BrandID, string BrandName, string BrandDescription, bool IsActive)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateBrand", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BrandID", BrandID);
                        command.Parameters.AddWithValue("@BrandName", BrandName);
                        command.Parameters.AddWithValue("@BrandDescription", BrandDescription);
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
        static public bool GetBrandByID(int BrandID, ref string BrandName, ref string BrandDescription, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetBrandByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BrandID", BrandID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                BrandName = Reader["BrandName"].ToString();
                                BrandDescription = Reader["BrandDescription"].ToString();
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
        static public bool DeleteBrand(int BrandID)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteBrand", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@BrandID", BrandID);
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
        static public bool GetBrandByName(string BrandName, ref int BrandID, ref string BrandDescription, ref bool IsActive)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetBrandByName", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BrandName", BrandName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                BrandID = Convert.ToInt32(Reader["BrandID"]);
                                BrandDescription = Reader["BrandDescription"].ToString();
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
