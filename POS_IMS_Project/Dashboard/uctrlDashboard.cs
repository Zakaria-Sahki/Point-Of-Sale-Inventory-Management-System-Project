using LiveChartsCore.SkiaSharpView.WinForms;
using POS_IMS_Project.Dashboard.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_IMS_Project.Dashboard
{
    public partial class uctrlDashboard : UserControl
    {
        private readonly MainViewModel _viewModel;
        public uctrlDashboard()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            CreateDashboard();
        }

        private void CreateDashboard()
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 4,
                Padding = new Padding(10)
            };

            layout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50));

            layout.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50));

            layout.RowStyles.Add(
        new RowStyle(SizeType.Absolute, 45));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Absolute, 45));

            layout.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50));

            // Monthly Revenue / Cost
            var monthlyTitle = CreateChartTitle("Monthly Revenue");
            var monthlyChart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                Series = _viewModel.MonthlyRevenue.Series,
                XAxes = _viewModel.MonthlyRevenue.XAxes,
                YAxes = _viewModel.MonthlyRevenue.YAxes,
                BackColor = Color.White
            };

            // Stock Status
            var stockTitle = CreateChartTitle("Product Stock Status");
            var stockChart = new PieChart
            {
                Dock = DockStyle.Fill,
                Series = _viewModel.StockStatus.Series,
                Margin = new Padding(30)
            };

            var salesCategoryTitle = CreateChartTitle("Sales By Category");
            var salesCategoryChart = new PieChart
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(20),
                TooltipTextSize = 10,
                Series = _viewModel.SalesByCategory.Series
            };

            // Stock Layout
            var stockLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.White
            };

            stockLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            stockLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            stockLayout.Controls.Add(stockChart, 0, 0);
            stockLayout.Controls.Add(CreateStockLegend(), 1, 0);

            // Sales Category Layout
            var salesCategoryLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 1,
                BackColor = Color.White
            };

            salesCategoryLayout.Controls.Add(salesCategoryChart, 0, 0);

            // Add controls

            // Monthly Revenue (full width)
            layout.Controls.Add(monthlyTitle, 0, 2);
            layout.SetColumnSpan(monthlyTitle, 2);

            layout.Controls.Add(monthlyChart, 0, 3);
            layout.SetColumnSpan(monthlyChart, 2);

            // Titles
            layout.Controls.Add(stockTitle, 0, 0);
            layout.Controls.Add(salesCategoryTitle, 1, 0);

            // Charts side by side
            layout.Controls.Add(stockLayout, 0, 1);
            layout.Controls.Add(salesCategoryLayout, 1, 1);

            Controls.Add(layout);
        }
        private Label CreateChartTitle(string title)
        {
            return new Label
            {
                Text = title,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 45, 45),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
        }
        private Control CreateLegendItem(string text, Color color)
        {
            var item = new FlowLayoutPanel
            {
                AutoSize = true,
                //Size = new Size(400, 35),
                WrapContents = false,
                FlowDirection = FlowDirection.LeftToRight,
                Margin = new Padding(5, 8, 5, 8),
                Anchor = AnchorStyles.Left
            };

            var colorPoint = new Panel
            {
                Size = new Size(14, 14),
                BackColor = color,
                Margin = new Padding(3, 4, 8, 0)
            };

            var label = new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.FromArgb(60, 60, 60)
            };

            item.Controls.Add(colorPoint);
            item.Controls.Add(label);

            return item;
        }
        private FlowLayoutPanel CreateStockLegend()
        {
            var legend = new FlowLayoutPanel
            {
                Size = new Size(150, 150),
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(5, 25, 5, 5),
                BackColor = Color.White,
                Anchor = AnchorStyles.None
            };

            legend.Controls.Add(
                CreateLegendItem("Healthy Stock", Color.FromArgb(22, 163, 74)));

            legend.Controls.Add(
                CreateLegendItem("Low Stock", Color.FromArgb(245, 158, 11)));

            legend.Controls.Add(
                CreateLegendItem("Out Of Stock", Color.FromArgb(220, 38, 38)));

            return legend;
        }
    }
}
