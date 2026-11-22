using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS.Models;

namespace POS_IMS_DataAccessLayer
{
    public class clsDashboard_DataAccess {


        static public List<MonthlyRevenue> GetMonthlyRevenue(int year)
        {
            var result = new List<MonthlyRevenue>();
            try {

                using(SqlConnection connection = new SqlConnection(clsSettingsDataAccess.ConnectionString)) {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_MonthlyRevenueStatistics", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Year", year);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new MonthlyRevenue
                                {
                                    //SalesFromYear = Convert.ToInt32(reader["SalesFromYear"]),
                                    Month = Convert.ToInt32(reader["SalesOfMonth"]),
                                    Revenue = Convert.ToDouble(reader["TotalRevenue"])
                                });
                            }
                        }
                    }
                }
            } catch (Exception ex) {

                result = null;
            }
            
            return result;
        }
        static public StockStatistics GetStockStatisticsAsync()
        {
            var statistics = new StockStatistics();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {
                    connection.Open();
                using (SqlCommand command = new SqlCommand("GetStockStatistics", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.OpenAsync();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            statistics.HealthyStock =
                                Convert.ToInt32(reader["HealthyStock"]);

                            statistics.LowStock =
                                Convert.ToInt32(reader["LowStock"]);

                            statistics.OutOfStock =
                                Convert.ToInt32(reader["OutOfStock"]);
                        }
                    }
                }
            }
            }
            catch (Exception Ex) {

                statistics = null;
            }
            return statistics;
        }
        static public List<SalesByCategory> GetSalesByCategory()
        {
            var result = new List<SalesByCategory>();
            try {

                using (SqlConnection connection = new SqlConnection(clsSettingsDataAccess.ConnectionString))
                {
                    connection.Open();
            using (SqlCommand command = new SqlCommand("SP_GetSalesByCategoryReports", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new SalesByCategory
                        {
                            CategoryName = Convert.ToString(reader["CategoryName"]),
                            Percentage = Convert.ToSingle(reader["Percentage"])
                        });
                    }
                }
                    }
                }

            } catch (Exception Ex) {

                result = null;
            }

            return result;
        }
    }
}
