using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Webszolgáltatás.Entities;
using Webszolgáltatás.ServiceReference;

namespace Webszolgáltatás
{
    public partial class Form1 : Form
    {
        BindingList<RealData> Rates = new BindingList<RealData>();
        

        public Form1()
        {
            InitializeComponent();

            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            dataGridView1.DataSource = Rates;
            
            XmlFeldolgoz(result);
            AdatokDiagramra();

        }

        public void XmlFeldolgoz(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);
            
            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RealData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }
        public void AdatokDiagramra()
        {
            chartRateData.DataSource = Rates;
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartarea = chartRateData.ChartAreas[0];
            chartarea.AxisX.MajorGrid.LineWidth = 0;
            chartarea.AxisY.MajorGrid.LineWidth = 0;
            chartarea.AxisY.IsStartedFromZero = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
