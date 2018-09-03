using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Agriculture.App_Code;
using System.Net.Http;

namespace Agriculture
{
    public partial class DataFeed : System.Web.UI.Page
    {
        SenseData a;
        SenseData c;
        HttpClient httpClient = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private async void UpdateData()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            response = await httpClient.GetAsync("https://guardians-24413.firebaseio.com/current.json");
            string data = await response.Content.ReadAsStringAsync();
            c = JsonConvert.DeserializeObject<SenseData>(data);

            response = await httpClient.GetAsync("https://guardians-24413.firebaseio.com/average.json");
            data = await response.Content.ReadAsStringAsync();
            a = JsonConvert.DeserializeObject<SenseData>(data);

            double cTem = c.temperature;
            double cHum = c.humidity;
            double cPre = c.pressure;

            double aTem = a.temperature;
            double aHum = a.humidity;
            double aPre = a.pressure;

            double dTem = cTem - aTem;
            double dHum = cHum - aHum;
            double dPre = cPre - aPre;

            lblTemC.Text = cTem.ToString("0.00 °C");
            lblHumC.Text = cHum.ToString("0.00 g/m³");
            lblPreC.Text = cPre.ToString("0.00 mbar");

            lblTemA.Text = aTem.ToString("0.00 °C");
            lblHumA.Text = aHum.ToString("0.00 g/m³");
            lblPreA.Text = aPre.ToString("0.00 mbar");

            lblTemD.Text = dTem.ToString("+0.00 °C;-0.00 °C;0.00 °C");
            lblHumD.Text = dHum.ToString("+0.00 g/m³;-0.00 g/m³;0.00 g/m³");
            lblPreD.Text = dPre.ToString("+0.00 mbar;-0.00 mbar;0.00 mbar");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}