using POS_IMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS.Models;

namespace POS_IMS_Project.Dashboard.View_Models
{
    public class MainViewModel {


        public MonthlyRevenueChart MonthlyRevenue { get; }
        public SalesByCategoryDoughnut SalesByCategory { get; }
        public StockStatisticsPieChart StockStatus { get; }

        public MainViewModel()
        {

            var monthlyData = clsDashboard.GetMonthlyRevenue(2026);
            MonthlyRevenue = new MonthlyRevenueChart(monthlyData);

            var StockStatistics = clsDashboard.GetStockStatisticsAsync();
            StockStatus = new StockStatisticsPieChart(StockStatistics);

            var salesByCategory = clsDashboard.GetSalesByCategory();
            SalesByCategory = new SalesByCategoryDoughnut(salesByCategory);
        }
        
    }
}
