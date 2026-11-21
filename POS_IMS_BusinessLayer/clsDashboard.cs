using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_IMS_DataAccessLayer;
using POS_IMS_DataAccessLayer.Models;

namespace POS_IMS_BusinessLayer
{
    public class clsDashboard {


        static public List<MonthlyRevenue> GetMonthlyRevenue(int year)
        {
            return clsDashboard_DataAccess.GetMonthlyRevenue(year);
        }
        static public StockStatistics GetStockStatisticsAsync()
        {
            return clsDashboard_DataAccess.GetStockStatisticsAsync();
        }
        static public List<SalesByCategory> GetSalesByCategory()
        {
            return clsDashboard_DataAccess.GetSalesByCategory();
        }
    }
}
