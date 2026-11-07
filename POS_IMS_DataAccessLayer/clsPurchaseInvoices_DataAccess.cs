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
    public class clsPurchaseInvoices_DataAccess {


        static public DataTable GetAllPurchaseInvoices()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllPurchaseInvoices", Connection))
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
        static public bool GetPurchaseInvoiceByID(int PurchaseID, ref DateTime PurchaseDate, ref int SupplierID_FK, ref int UserID_FK, ref decimal TotalAmount)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetPurchaseByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PurchaseID", PurchaseID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                PurchaseDate = Convert.ToDateTime(Reader["PurchaseDate"]);
                                SupplierID_FK = Convert.ToInt32(Reader["SupplierID_FK"]);
                                UserID_FK = Convert.ToInt32(Reader["UserID_FK"]);
                                TotalAmount = Convert.ToDecimal(Reader["TotalAmount"]);
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
        static public int LogNewPurchaseInvoice(int SupplierID, int UserID, Decimal TotalAmount) {


            int NewPurchaseID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_LogPurchaseInvoice", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SupplierID", SupplierID);
                        Command.Parameters.AddWithValue("@UserID", UserID);
                        Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);


                        SqlParameter outputIDparam = new SqlParameter("@PurchaseID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewPurchaseID = (int)Command.Parameters["@PurchaseID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewPurchaseID = -1;
            }


            return NewPurchaseID;
        }
    }
}
