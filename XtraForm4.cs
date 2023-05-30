using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Presets.Styles;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Gauges.Circular;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPruebas
{
    public partial class XtraForm4 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm4()
        {
            InitializeComponent();
        }

        private void XtraForm4_Load(object sender, EventArgs e)
        {
            loadtacometro();

            //// Create a chart.
            //ChartControl chart = new ChartControl();

            //// Generate a data table and bind the chart to it.
            //chart.DataSource = CreateChartData();

            //// Specify data members to bind the chart's series template.
            //chart.SeriesDataMember = "Month";
            //chart.SeriesTemplate.ArgumentDataMember = "Section";
            //chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });

            //// Specify the template's series view.
            //chart.SeriesTemplate.View = new StackedBarSeriesView();

            //// Specify the template's name prefix.
            //chart.SeriesNameTemplate.BeginText = "Month: ";

            //// Dock the chart into its parent, and add it to the current form.
            //chart.Dock = DockStyle.Fill;
            //this.Controls.Add(chart);

            //Series series = new Series();            

            chartControl1.DataSource = CreateChartData();

            // Specify data members to bind the chart's series template.
            
            chartControl1.SeriesDataMember = "Mes";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Anio";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });

            // Specify the template's series view.
            chartControl1.SeriesTemplate.View = new SideBySideBarSeriesView();
            //StackedBarSeriesView
            //StepLineSeriesView


            // Specify the template's name prefix.
            chartControl1.SeriesNameTemplate.BeginText = "Mes: ";

            // Dock the chart into its parent, and add it to the current form.
            //chartControl1.Dock = DockStyle.Fill;
            /// Specify the template's series view.
            //chartControl1.SeriesTemplate.View = new SideBySideBarSeriesView();

            //// Specify the BoundDataChanged event handler.
            //chartControl1.BoundDataChanged +=
            //    new BoundDataChangedEventHandler(chart_BoundDataChanged);

            //// Specify the template's name prefix.
            //chartControl1.SeriesNameTemplate.BeginText = "Month: ";





            //chartControl2.DataSource = CreateChartData();
            // Create an empty chart.
            //ChartControl pieChart = new ChartControl();

            chartControl2.Titles.Add(new ChartTitle() { Text = "Cumplimiento de presupuesto" });

            // Create a pie series.
            Series series1 = new Series("Land Area by Country", ViewType.Doughnut);

            // Bind the series to data.
            series1.DataSource = CreateChartDataPastel();
            series1.ArgumentDataMember = "Mes";
            series1.ValueDataMembers.AddRange(new string[] { "Cumplimiento" });

            // Add the series to the chart.
            chartControl2.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            // Format the series legend items.
            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels. 
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Specify a data filter to explode points.
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            myView.RuntimeExploding = true;

            // Customize the legend.
            chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            //pieChart.Dock = DockStyle.Fill;
            //this.Controls.Add(pieChart);


            
        }

        private DataTable CreateChartData()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Mes", typeof(String));
            table.Columns.Add("Anio", typeof(String));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            table.Rows.Add(new object[] { "Enero", "2020", 10 });
            table.Rows.Add(new object[] { "Enero", "2021", 20 });
            table.Rows.Add(new object[] { "Febrero", "2020", 20 });
            table.Rows.Add(new object[] { "Febrero", "2021", 30 });
            table.Rows.Add(new object[] { "Marzo", "2020", 15 });
            table.Rows.Add(new object[] { "Marzo", "2021", 25 });
            table.Rows.Add(new object[] { "Abril", "2020", 10 });

            return table;
        }

        private void chart_BoundDataChanged(object sender, EventArgs e)
        {
            ChartControl chart = (ChartControl)sender;

            // Change the view of the "Month: Feb" series from 
            // SideBySideBarSeriesView to LineSeriesView.
            Series feb = chart.GetSeriesByName("Month: Feb");
            if (feb != null)
                feb.ChangeView(ViewType.Line);

            // Change the view of the "Month: March" series from 
            // SideBySideBarSeriesView to SplineSeriesView.
            Series march = chart.GetSeriesByName("Month: March");
            if (march != null)
                march.ChangeView(ViewType.Spline);
        }

        private DataTable CreateChartDataPastel()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Mes", typeof(String));
            table.Columns.Add("Presupuesto", typeof(decimal));
            table.Columns.Add("Cumplimiento", typeof(Int32));

            // Add data rows to the table.
            table.Rows.Add(new object[] { "Enero", 100, 10 });
            table.Rows.Add(new object[] { "Febrero", 200, 20 });
            table.Rows.Add(new object[] { "Marzo", 150, 15 });
            table.Rows.Add(new object[] { "Abril", 89, 10 });

            return table;
        }


        private void loadtacometro()
        {
            ////GaugeControl gc = new GaugeControl();

            //// Add a circular gauge.
            //CircularGauge circularGauge = gaugeControl2.AddCircularGauge();

            //// Add the default elements (a scale, background layer and needle).
            //circularGauge.AddDefaultElements();
            //// Add non-default gauge element
            ////circularGauge.AddSpindleCap();
            ////hast
            //// apply the desired style  
            ////circularGauge.ApplyStyles(StyleLoader.Load("Circular.DarkNight.Full"));
            //circularGauge.ApplyStyles(StyleLoader.Load("Circular.Haze.Full"));

            //// Change the background layer's paint style.
            //ArcScaleBackgroundLayer background = circularGauge.BackgroundLayers[0];
            //background.ShapeType = BackgroundLayerShapeType.CircularFull_Style3;

            //// Customize the scale's settings.
            //ArcScaleComponent scale = circularGauge.Scales[0];
            //scale.MinValue = 0;
            //scale.MaxValue = 100;
            //scale.Value = 88;
            //scale.MajorTickCount = 6;
            //scale.MajorTickmark.FormatString = "{0:F0}";
            //scale.MajorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_2;
            //scale.MajorTickmark.ShapeOffset = -9;
            //scale.MajorTickmark.AllowTickOverlap = true;
            //scale.MajorTickmark.TextOffset = -30;
            //scale.MinorTickCount = 3;
            //scale.MinorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_1;
            //scale.AppearanceTickmarkText.TextBrush = new SolidBrushObject(Color.White);

            //// Change the needle's paint style.
            //ArcScaleNeedleComponent needle = circularGauge.Needles[0];
            //needle.ShapeType = NeedleShapeType.CircularFull_Style3;

            //// Add the gauge control to the form.
            ////gc.Size = new Size(250, 250);
            ////gc.Parent = this;

            
            // Customize the scale's settings.
            ArcScaleComponent scale = circularGauge1.Scales[0];
            scale.MinValue = 0;
            scale.MaxValue = 100;
            scale.Value = 88;
            scale.MajorTickCount = 6;
            scale.MajorTickmark.FormatString = "{0:F0}";
            scale.MajorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_2;
            scale.MajorTickmark.ShapeOffset = -9;
            scale.MajorTickmark.AllowTickOverlap = true;
            scale.MajorTickmark.TextOffset = -30;
            scale.MinorTickCount = 6;
            scale.MinorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_1;
            scale.AppearanceTickmarkText.TextBrush = new SolidBrushObject(Color.White);
            labelComponent1.Text = "88 %";
            //for(int i=1; i<10; i++)
            //{                
            //    scale.Value = i;
            //    labelComponent1.Text = i.ToString();
            //    System.Threading.Thread.Sleep(1000);
            //}
        }


        private void mapControl()
        {
            // Create a map control.
            //MapControl map = new MapControl();

            // Specify the map position on the form.           
            //mapControl1.Dock = DockStyle.Fill;

            // Create a layer.
            ImageLayer layer = new ImageLayer();
            mapControl1.Layers.Add(layer);

            // Create a data provider.           
            //BingMapDataProvider provider = new BingMapDataProvider();
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            //provider.BingKey = "Your Bing Maps key";
            layer.DataProvider = provider;

            // Specify the map zoom level and center point. 
            mapControl1.ZoomLevel = 3;
            mapControl1.CenterPoint = new GeoPoint(40, -100);

            // Add the map control to the window.
            //this.Controls.Add(map);
        }

    }
}