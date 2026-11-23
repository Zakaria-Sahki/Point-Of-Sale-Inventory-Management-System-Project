using LiveChartsCore;
using LiveChartsCore.Defaults;
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
    public class MonthlyRevenueChart {


        public ISeries[] Series { get; set; }
        public Axis[] XAxes { get; set; }
        public Axis[] YAxes { get; set; }

        public MonthlyRevenueChart(List<MonthlyRevenue> data)
        {
            var revenueByMonth = (data ?? new List<MonthlyRevenue>())
                .GroupBy(x => x.Month)
                .ToDictionary(g => g.Key, g => g.Sum(x => x.Revenue));

            var monthDates = Enumerable.Range(1, 12)
                .Select(month => new DateTime(2026, month, 1))
                .ToArray();

            var revenue = monthDates
                .Select(date => new DateTimePoint(
                    date,
                    revenueByMonth.TryGetValue(date.Month, out var total) ? total : 0))
                .ToArray();

            Series = new ISeries[]
            {
        new ColumnSeries<DateTimePoint>
        {
            Name = "Revenue",
            Values = revenue,
            MaxBarWidth = 45
        }
            };

            XAxes = new Axis[]
            {
        new DateTimeAxis(
            TimeSpan.FromDays(30.4375),
            date => date.ToString("MMM"))
        {
            Name = "Month",
            NamePaint = new SolidColorPaint(SKColors.Black),
            CustomSeparators = monthDates.Select(d => (double)d.Ticks).ToArray()
        }
            };

            YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Revenue",
            Labeler = value => value.ToString("N0")
        }
            };
        }
    }
}
