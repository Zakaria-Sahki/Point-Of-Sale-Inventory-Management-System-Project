using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_DataAccessLayer.Models
{
    public class StockStatistics
    {

        public int HealthyStock { get; set; }
        public int LowStock { get; set; }
        public int OutOfStock { get; set; }
    }
}
