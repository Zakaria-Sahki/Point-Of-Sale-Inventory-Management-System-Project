using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsCustomers_DataAcceess {


        static public DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllCustomers", Connection))
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
        static public int AddNewCustomer(int PersonID_FK, int Points, decimal Credits, decimal TotalSpent, bool IsActive, string Notes)
        {

            int NewCustomerID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewCustomer", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID_FK", PersonID_FK);
                        Command.Parameters.AddWithValue("@Points", Points);
                        Command.Parameters.AddWithValue("@Credits", Credits);
                        Command.Parameters.AddWithValue("@TotalSpent", TotalSpent);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);
                        Command.Parameters.AddWithValue("@Notes", Notes);

                        SqlParameter outputIDparam = new SqlParameter("@NewCustomerID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewCustomerID = (int)Command.Parameters["@NewCustomerID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewCustomerID = -1;
            }


            return NewCustomerID;
        }
        static public bool UpdateCustomer(int CustomerID, int Points, decimal Credits, decimal TotalSpent, bool IsActive, string Notes)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@Points", Points);
                        command.Parameters.AddWithValue("@Credits", Credits);
                        command.Parameters.AddWithValue("@TotalSpent", TotalSpent);
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
        static public bool GetCustomerByID(int CustomerID, ref int PersonID_FK, ref int Points, ref decimal Credits, ref decimal TotalSpent, ref bool IsActive, ref string Notes)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetCustomerByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                PersonID_FK = Convert.ToInt32(Reader["PersonID_FK"]);
                                Points = Convert.ToInt32(Reader["Points"]);
                                Credits = Convert.ToDecimal(Reader["Credits"]);
                                TotalSpent = Convert.ToDecimal(Reader["TotalSpent"]);
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
        static public bool DeleteCustomer(int CustomerID)
        {

            int RowAffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_DeleteCustomer", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        static public bool IsCustomerWithPersonIDExist(int PersonID)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT Found = 1 FROM Customers WHERE PersonID_FK = @PersonID;";
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

        static public bool IsCustomerWithCustomerIDExist(int CustomerID)
        {

            bool IsFound = false;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    string Query = @"SELECT IsFound = 1 FROM Customers WHERE CustomerID = @CustomerID;";
                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
