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
    public class clsSuppliers_DataAccess {


        static public DataTable GetAllSuppliers()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllSuppliers", Connection))
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
        static public int AddNewSupplier(int PersonID_FK, string Address, string CompanyName, bool IsActive, string Notes)
        {

            int NewSupplierID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewSupplier", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID_FK", PersonID_FK);
                        Command.Parameters.AddWithValue("@Address", Address);
                        Command.Parameters.AddWithValue("@CompanyName", CompanyName);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);
                        Command.Parameters.AddWithValue("@Notes", Notes);

                        SqlParameter outputIDparam = new SqlParameter("@NewSupplierID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewSupplierID = (int)Command.Parameters["@NewSupplierID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewSupplierID = -1;
            }


            return NewSupplierID;
        }
        static public bool UpdateSupplier(int SupplierID, string Address, string CompanyName, bool IsActive, string Notes)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateSupplier", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@CompanyName", CompanyName);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@Notes", Notes);

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
        static public bool GetSupplierID(int SupplierID, ref int PersonID_FK, ref string Address, ref string CompanyName, ref bool IsActive, ref string Notes)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetSupplierByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                PersonID_FK = Convert.ToInt32(Reader["PersonID_FK"]);
                                Address = Reader["Address"].ToString();
                                CompanyName = Reader["CompanyName"].ToString();
                                IsActive = Convert.ToBoolean(Reader["IsActive"]);
                                Notes = Reader["Notes"].ToString();

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
        static public bool DeleteSupplier(int SupplierID)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteSupplier", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SupplierID", SupplierID);
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
        static public bool IsSupplierWithPersonIDExist(int PersonID)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT IsFound = 1 FROM Suppliers WHERE PersonID_FK = @PersonID;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@PersonID", PersonID);

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
        static public bool IsSupplierWithSupplierIDExist(int SupplierID)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT IsFound = 1 FROM Suppliers WHERE SupplierID = @SupplierID;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@SupplierID", SupplierID);

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
    }
}
