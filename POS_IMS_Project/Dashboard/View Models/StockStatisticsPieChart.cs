using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOS.Models;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;

namespace POS_IMS_Project.Dashboard.View_Models
{
    public class StockStatisticsPieChart {


        public IEnumerable<ISeries> Series { get; }

        //public class PieData(string name, double value)
        //{
        //    public string Name { get; set; } = name;
        //    public double[] Values { get; set; } = [value];
        //}

        public StockStatisticsPieChart(StockStatistics data)
        {
            Series = new ISeries[]
        {
            new PieSeries<int>
            {
                Name = "Healthy Stock",
                Values = new[] { data.HealthyStock },
                Fill = new SolidColorPaint(SKColors.Green)
                //Fill = new SolidColorPaint(SKColor.Parse("#16A34A")
            },

            new PieSeries<int>
            {
                Name = "Low Stock",
                Values = new[] { data.LowStock },
                Fill = new SolidColorPaint(SKColors.Orange)
            },

            new PieSeries<int>
            {
                Name = "Out Of Stock",
                Values = new[] { data.OutOfStock },
                Fill = new SolidColorPaint(SKColors.Red)
            }
        };
        }
    }
}
