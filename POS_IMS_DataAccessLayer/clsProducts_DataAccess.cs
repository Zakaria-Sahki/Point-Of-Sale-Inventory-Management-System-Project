using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POS_IMS_DataAccessLayer
{
    public class clsProducts_DataAccess {

        static public DataTable DisplayAllProducts()
        {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_DisplayAllProducts", Connection))
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
        static public DataTable GetAllProducts() {

            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetAllProducts", Connection))
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
        static public int AddNewProduct(string ProductName, string SKU, string BarCode, decimal SellPrice, decimal PurchasePrice, int CategoryID_FK, int MinimumStock, string ImagePath, int BrandID_FK) {

            int NewProductID = -1;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {


                    using (SqlCommand Command = new SqlCommand("SP_AddNewProduct", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        Command.Parameters.AddWithValue("@SKU", SKU);
                        Command.Parameters.AddWithValue("@BarCode", BarCode);
                        Command.Parameters.AddWithValue("@SellPrice", SellPrice);
                        Command.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
                        Command.Parameters.AddWithValue("@CategoryID_FK", CategoryID_FK);
                        Command.Parameters.AddWithValue("@MinStock", MinimumStock);
                        Command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        Command.Parameters.AddWithValue("@BrandID_FK", BrandID_FK);


                        SqlParameter outputIDparam = new SqlParameter("@NewProductID", SqlDbType.Int)
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIDparam);

                        Connection.Open();
                        Command.ExecuteNonQuery();
                        NewProductID = (int)Command.Parameters["@NewProductID"].Value;
                    }
                }


            }
            catch (Exception Ex)
            {

                NewProductID = -1;
            }


            return NewProductID;
        }
        static public bool DeleteProduct(int ProductID)
        {

            int RowAffected = 0;

            try {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString)) {

                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_DeleteProduct", Connection)) { 
                        
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        RowAffected = (int)Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {

                RowAffected = 0;
            }
            return (RowAffected > 0);
        }
        static public bool UpdateProduct(int ProductID, string ProductName, string SKU, string BarCode, decimal SellPrice, decimal PurchasePrice, int QuantityInStock, int MinimumStock, string ImagePath, int BrandID_FK, int CategoryID_FK, bool IsActive) {
        
            int RowAffected = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateProduct", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                        command.Parameters.AddWithValue("@ProductName", ProductName);
                        command.Parameters.AddWithValue("@SKU", SKU);
                        command.Parameters.AddWithValue("@BarCode", BarCode);
                        command.Parameters.AddWithValue("@SellPrice", SellPrice);
                        command.Parameters.AddWithValue("@PurchasePrice", PurchasePrice);
                        command.Parameters.AddWithValue("@QuantityInStock", QuantityInStock);
                        command.Parameters.AddWithValue("@CategoryID_FK", CategoryID_FK);
                        command.Parameters.AddWithValue("@MinStock", MinimumStock);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        command.Parameters.AddWithValue("@BrandID_FK", BrandID_FK);
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
        static public bool GetProductByID(int ProductID, ref string ProductName, ref string SKU, ref string BarCode, ref decimal SellPrice, ref decimal PurchasePrice, ref int QuantityInStock, ref int MinimumStock, ref string ImagePath, ref int BrandID_FK, ref int CategoryID_FK, ref bool IsActive) {


            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetProductByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                ProductName = Reader["ProductName"].ToString();
                                SKU = Reader["SKU"].ToString();
                                BarCode = Reader["BarCode"].ToString();
                                SellPrice = Convert.ToDecimal(Reader["SellPrice"]);
                                PurchasePrice = Convert.ToDecimal(Reader["PurchasePrice"]);
                                QuantityInStock = Convert.ToInt32(Reader["QuantityInStock"]);
                                MinimumStock = Convert.ToInt32(Reader["MinStock"]);
                                ImagePath = Reader["ImagePath"].ToString();
                                BrandID_FK = Convert.ToInt32(Reader["BrandID_FK"]);
                                CategoryID_FK = Convert.ToInt32(Reader["CategoryID_FK"]);
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



        static public bool GetProductByBarCode(string BarCode, ref int ProductID, ref string ProductName, ref string SKU, ref decimal SellPrice, ref decimal PurchasePrice, ref int QuantityInStock, ref int MinimumStock, ref string ImagePath, ref int BrandID_FK, ref int CategoryID_FK, ref bool IsActive)
        {


            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetProductByBarCode", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BarCode", BarCode);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                ProductID = Convert.ToInt32(Reader["ProductID"]);
                                ProductName = Reader["ProductName"].ToString();
                                SKU = Reader["SKU"].ToString();
                                SellPrice = Convert.ToDecimal(Reader["SellPrice"]);
                                PurchasePrice = Convert.ToDecimal(Reader["PurchasePrice"]);
                                QuantityInStock = Convert.ToInt32(Reader["QuantityInStock"]);
                                MinimumStock = Convert.ToInt32(Reader["MinStock"]);
                                ImagePath = Reader["ImagePath"].ToString();
                                BrandID_FK = Convert.ToInt32(Reader["BrandID_FK"]);
                                CategoryID_FK = Convert.ToInt32(Reader["CategoryID_FK"]);
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
        static public bool GetProductBySKU(string SKU, ref int ProductID, ref string ProductName, ref string BarCode, ref decimal SellPrice, ref decimal PurchasePrice, ref int QuantityInStock, ref int MinimumStock, ref string ImagePath, ref int BrandID_FK, ref int CategoryID_FK, ref bool IsActive)
        {


            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetProductBySKU", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@SKU", ProductID);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                ProductID = Convert.ToInt32(Reader["ProductID"]);
                                ProductName = Reader["ProductName"].ToString();
                                BarCode = Reader["BarCode"].ToString();
                                SellPrice = Convert.ToDecimal(Reader["SellPrice"]);
                                PurchasePrice = Convert.ToDecimal(Reader["PurchasePrice"]);
                                QuantityInStock = Convert.ToInt32(Reader["QuantityInStock"]);
                                MinimumStock = Convert.ToInt32(Reader["MinStock"]);
                                ImagePath = Reader["ImagePath"].ToString();
                                BrandID_FK = Convert.ToInt32(Reader["BrandID_FK"]);
                                CategoryID_FK = Convert.ToInt32(Reader["CategoryID_FK"]);
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
        static public bool GetProductByName(string ProductName, ref int ProductID, ref string SKU, ref string BarCode, ref decimal SellPrice, ref decimal PurchasePrice, ref int QuantityInStock, ref int MinimumStock, ref string ImagePath, ref int BrandID_FK, ref int CategoryID_FK, ref bool IsActive)
        {


            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {

                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand("SP_GetProductByName", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@ProductName", ProductName);
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                ProductID = Convert.ToInt32(Reader["ProductID"]);
                                SKU = Reader["SKU"].ToString();
                                BarCode = Reader["BarCode"].ToString();
                                SellPrice = Convert.ToDecimal(Reader["SellPrice"]);
                                PurchasePrice = Convert.ToDecimal(Reader["PurchasePrice"]);
                                QuantityInStock = Convert.ToInt32(Reader["QuantityInStock"]);
                                MinimumStock = Convert.ToInt32(Reader["MinStock"]);
                                ImagePath = Reader["ImagePath"].ToString();
                                BrandID_FK = Convert.ToInt32(Reader["BrandID_FK"]);
                                CategoryID_FK = Convert.ToInt32(Reader["CategoryID_FK"]);
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
