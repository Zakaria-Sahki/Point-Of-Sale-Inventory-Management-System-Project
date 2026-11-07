using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsSaleInvoices_DataAccess {



        static public DataTable GetAllSaleInvoices() {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllSaleInvoices", Connection))
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
        static public bool GetSaleInvoiceByID(int SaleID, ref DateTime SaleDate, ref int CustomerID_FK, ref int UserID_FK, ref decimal TotalAmount) {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetSaleInvoiceByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SaleID", SaleID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                SaleDate = Convert.ToDateTime(Reader["SaleDate"]);

                                if (Reader["CustomerID_FK"] == DBNull.Value)
                                {

                                    CustomerID_FK = -1;
                                }
                                else {

                                    CustomerID_FK = Convert.ToInt32(Reader["CustomerID_FK"]);
                                }
      
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
        static public int LogNewSaleInvoice(int CustomerID, int UserID, Decimal TotalAmount)
        {


            int NewSaleID = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_LogSaleInvoice", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        if (CustomerID == -1)
                            Command.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        
                            
                        Command.Parameters.AddWithValue("@UserID", UserID);
                        Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);


                        SqlParameter outputIDparam = new SqlParameter("@SaleID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewSaleID = (int)Command.Parameters["@SaleID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewSaleID = -1;
            }


            return NewSaleID;
        }

    }
}
