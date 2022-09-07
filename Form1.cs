using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Sockets;

namespace Weather_app
{
    public partial class Form1 : Form
    {

        private string[] sortedCities;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sortedCities = getCities();
            // fill form with default data
            foreach (Control item in this.Controls)
            {
                if (item is Panel)
                {
                    item.BackColor = Color.FromArgb(80, 0, 0, 0);
                }

            }
            comboBoxCity1.Items.AddRange(sortedCities);
            comboBoxCity2.Items.AddRange(sortedCities);
            comboBoxCity3.Items.AddRange(sortedCities);
            comboBoxCity4.Items.AddRange(sortedCities);
            comboBoxCity5.Items.AddRange(sortedCities);
            comboBoxCity1.SelectedIndex = 0;
            comboBoxCity2.SelectedIndex = 1;
            comboBoxCity3.SelectedIndex = 2;
            comboBoxCity4.SelectedIndex = 3;
            comboBoxCity5.SelectedIndex = 4;
            updateWeather(comboBoxCity1, btnIcon1, labTemperature1);
            updateWeather(comboBoxCity2, btnIcon2, labTemperature2);
            updateWeather(comboBoxCity3, btnIcon3, labTemperature3);
            updateWeather(comboBoxCity4, btnIcon4, labTemperature4);
            updateWeather(comboBoxCity5, btnIcon5, labTemperature5);
        }
        private string[] getCities()
        {
            sortedCities = System.Configuration.ConfigurationManager.AppSettings["Cities"].Split(';');
            List<string> sortedCitiesList = sortedCities.ToList<string>();
            sortedCitiesList.Sort();
            return sortedCitiesList.ToArray();
        }

        private string getTemperature(dynamic kelvinTemp)
        {
            string test = (string)kelvinTemp;
            double cels = Convert.ToDouble(test.Replace('.', ',')) - 273.15;
            cels = Math.Round(cels, 2);
            return cels.ToString() + "°C";
        }

        private dynamic getWeather(ComboBox comboBoxCity)
        {
            using (WebClient web = new WebClient())
            {
                string[] cityCoords = System.Configuration.ConfigurationManager.AppSettings[sortedCities[comboBoxCity.SelectedIndex]].Split(';');
                double lat = Convert.ToDouble(cityCoords[0].Replace('.', ','));
                double lon = Convert.ToDouble(cityCoords[1].Replace('.', ','));
                string url = string.Format("{0}lat={1}&lon={2}&appid={3}&cnt=1", Program.apiUrl, lat, lon, Program.apiKey);
                try
                {
                    var json = web.DownloadString(url);
                    dynamic weatherInfo = (JObject)JsonConvert.DeserializeObject(json);
                    return weatherInfo;
                }
                catch (WebException)
                {
                    return "N/A";
                }
            }
        }

        private void setIcon(dynamic weatherInfo, Button btnIcon)
        {

            WeatherInfo weather = new WeatherInfo();
            try
            {
                weather.clouds = weatherInfo.SelectToken("current.clouds");
                weather.snow = weatherInfo.SelectToken("current.snow.1h") != null ? weatherInfo.SelectToken("current.snow.1h") : 0.00;
                weather.rain = weatherInfo.SelectToken("current.rain.1h") != null ? weatherInfo.SelectToken("current.rain.1h") : 0.00;
            }
            catch(Exception)
            {
                btnIcon.Text = "Internet connection lost";
                return;
            }

            if (isSunny(weather))
            {
                btnIcon.ImageKey = "sunny_icon.png";
                btnIcon.Text = "słonecznie";
            }
            else if (isCloudsSun(weather))
            {
                btnIcon.ImageKey = "clouds_sun_icon.png";
                btnIcon.Text = "słońce za chmurami";
            }
            else if (isCloudy(weather))
            {
                btnIcon.ImageKey = "clouds_sun_icon.png";
                btnIcon.Text = "chmury";
            }
            else if (isRaining(weather))
            {
                btnIcon.ImageKey = "cloudy_icon.png";
                btnIcon.Text = "deszcz";
            }
            else if (isSnowing(weather))
            {
                btnIcon.ImageKey = "rain_icon.png";
                btnIcon.Text = "śnieg";
            }
        }

        private bool isRainFalling(WeatherInfo weather)
        {
            if (weather.snow == 0 && weather.rain == 0) return false;
            return true;
        }
        private bool isSunny(WeatherInfo weather)
        {
            if (weather.clouds <= 0.1 && !isRainFalling(weather)) return true;
            return false;
        }

        private bool isCloudsSun(WeatherInfo weather)
        {
            if (weather.clouds <= 0.6 && !isRainFalling(weather)) return true;
            return false;
        }

        private bool isCloudy(WeatherInfo weather)
        {
            if (weather.clouds > 0.6 && !isRainFalling(weather)) return true;
            return false;
        }

        private bool isRaining(WeatherInfo weather)
        {
            if (weather.rain != 0) return true;
            return false;
        }

        private bool isSnowing(WeatherInfo weather)
        {
            if (weather.snow != 0) return true;
            return false;
        }

        private void updateWeather(ComboBox comboBoxCity, Button btnIcon, Label labTemperature)
        {
            dynamic weatherInfo = getWeather(comboBoxCity);
            try
            {
                labTemperature.Text = getTemperature(weatherInfo.SelectToken("current.temp"));
            }
            catch(Exception)
            {
                labTemperature.Text = "N/A";
            }
            
            setIcon(weatherInfo, btnIcon);
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeather(comboBoxCity1, btnIcon1, labTemperature1);
        }

        private void comboBoxCity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeather(comboBoxCity2, btnIcon2, labTemperature2);
        }

        private void comboBoxCity3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeather(comboBoxCity3, btnIcon3, labTemperature3);
        }

        private void comboBoxCity4_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeather(comboBoxCity4, btnIcon4, labTemperature4);
        }

        private void comboBoxCity5_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWeather(comboBoxCity5, btnIcon5, labTemperature5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void weatherInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labTemperature_Click(object sender, EventArgs e)
        {

        }

    }
}
