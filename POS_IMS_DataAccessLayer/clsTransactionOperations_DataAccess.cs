using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer
{
    public class clsTransactionOperations_DataAccess {

        static public int LogNewSaleTransaction(int SaleID_FK, int ProductID_FK, int Quantity, decimal UnitPrice, int UserID_FK)
        {

            int RowAffected = -1;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_SaleTransaction", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SaleID_FK", SaleID_FK);
                        Command.Parameters.AddWithValue("@ProductID", ProductID_FK);
                        Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                        Command.Parameters.AddWithValue("@Quantity", Quantity);
                        Command.Parameters.AddWithValue("@UserID", UserID_FK);

                        Connection.Open();
                        RowAffected = Command.ExecuteNonQuery();

                    }
                }


            }
            catch (Exception Ex)
            {

                RowAffected = -1;
            }


            return RowAffected;
        }
        static public int LogNewPurchaseTransaction(int PurchaseID_FK, int ProductID_FK, int Quantity, decimal UnitPrice, int UserID_FK)
        {

            int RowAffected = -1;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_PurchaseTransaction", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PurchaseID_FK", PurchaseID_FK);
                        Command.Parameters.AddWithValue("@ProductID", ProductID_FK);
                        Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                        Command.Parameters.AddWithValue("@Quantity", Quantity);
                        Command.Parameters.AddWithValue("@UserID", UserID_FK);

                        Connection.Open();
                        RowAffected = Command.ExecuteNonQuery();

                    }
                }


            }
            catch (Exception Ex)
            {

                RowAffected = -1;
            }


            return RowAffected;
        }
    }
}
