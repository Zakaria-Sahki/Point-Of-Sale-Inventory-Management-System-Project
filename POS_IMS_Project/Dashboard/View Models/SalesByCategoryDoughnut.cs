using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using DTOS.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_Project.Dashboard.View_Models
{
    public class SalesByCategoryDoughnut {

        public IEnumerable<ISeries> Series { get; }

        public SalesByCategoryDoughnut(
            IEnumerable<SalesByCategory> models)
        {
            var colors = new[]
            {
                SKColors.Green,
                SKColors.Blue,
                SKColors.Orange,
                SKColors.Red,
                SKColors.Purple,
                SKColors.Cyan,
                SKColors.Yellow,
                SKColors.Pink
            };

            Series = models.Select((model, index) =>
                new PieSeries<decimal>
                {
                    Name = model.CategoryName,

                    Values = new decimal[]
                    {
                        model.Percentage
                    },

                    Fill = new SolidColorPaint(
                        colors[index % colors.Length]),

                    InnerRadius = 50,
                    ToolTipLabelFormatter = point => $"{point.Coordinate.PrimaryValue:F2}%"
                }).ToArray();
    
        }
    }
}
