using Locations;
using ApiCom;
using Spokodynka_gui.Pages;

namespace spokodynka_winforms
{
    public partial class PlacePage : UserControl
    {
        private readonly IApiCom _apiCom;
        private Location location;
        public List<Record> records;
        int sysHour = DateTime.Now.Hour;

        public Location Location => location;

        public PlacePage(Location location)
        {
            InitializeComponent();
            placePageName.Text = location.Name;
            this.location = location;

            _apiCom = ApiComFactory.CreateInstance()
                .SetGeoLocation(location.Lat, location.Lon)
                .SetForecastDays(SettingsPage.forecastDays)
                .ReqHourlyTemp()
                .ReqHourlyHumidity()
                .ReqHourlyWindspeed()
                .ReqHourlySurfacepressure()
                .ReqHourlyPrecipitation();
            LoadWeatherDataAsync();
        }

        public async void LoadWeatherDataAsync()
        {
            try
            {
                records = await _apiCom.SendAsync();

                if (records != null && records.Count > 0)
                {
                    Record currentRecord = records.FirstOrDefault(r => r.date.Hour == sysHour);
                    DisplayHourlyData(records);
                    DisplayDailyData(records);
                    currentTempLabel.Text = currentRecord.temperature.ToString() + "°C";
                    LoadWeatherVisuals(currentRecord);
                    weatherInfoLabel.Text += (currentRecord.windspeed is not null) ? "Prędkość wiatru: " + currentRecord.windspeed + " m/s\n\n" : "";
                    weatherInfoLabel.Text += (currentRecord.prec is not null) ? "Opady: " + currentRecord.prec.probability + "%\n\n" : "";
                    weatherInfoLabel.Text += (currentRecord.surfacepressure is not null) ? "Ciśnienie: " + currentRecord.surfacepressure + "hPa\n\n" : "";
                    weatherInfoLabel.Text += (currentRecord.humidity is not null) ? "Wilgotność: " + currentRecord.humidity + "%\n\n" : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWeatherVisuals(Record record)
        {
            bool isDaytime = sysHour > 6 && sysHour <= 18;
            bool hasPrecipitation = record.prec.probability > 20;
            bool isSnowing = hasPrecipitation && record.temperature < 0;

            if (isDaytime)
            {
                currentWeatherPicture.BackgroundImage = isSnowing
                    ? Spokodynka_gui.Properties.Resources.snow_sun
                    : hasPrecipitation
                        ? Spokodynka_gui.Properties.Resources.rain_sun
                        : Spokodynka_gui.Properties.Resources.sun;
            }
            else
            {
                currentWeatherPicture.BackgroundImage = isSnowing
                    ? Spokodynka_gui.Properties.Resources.snow_moon
                    : hasPrecipitation
                        ? Spokodynka_gui.Properties.Resources.rain_moon
                        : Spokodynka_gui.Properties.Resources.moon;
            }
        }


        private void DisplayHourlyData(List<Record> records)
        {
            var hourlyRecords = records.Take(24).ToList();

            foreach (var record in hourlyRecords)
            {
                int hour = record.date.Hour;
                double temp = record.temperature.HasValue ? (double)record.temperature.Value : 0;

                ForecastHourBox newforecastHourBox = new ForecastHourBox(hour, temp)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };
                if(hour == sysHour)
                {
                    newforecastHourBox.BackColor = Color.FromArgb(100, 20, 112, 189);
                }

                hour = (hour + 1) % 24;

                newforecastHourBox.Dock = DockStyle.Left;
                hourlyForecastPanel.Controls.Add(newforecastHourBox);
                hourlyForecastPanel.Controls.SetChildIndex(newforecastHourBox, 0);
            }
        }


        private void DisplayDailyData(List<Record> records)
        {
            var dailyData = records
                .GroupBy(r => r.date.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TempMin = g.Min(r => r.temperature) ?? 0,
                    TempMax = g.Max(r => r.temperature) ?? 0
                })
                .Take(SettingsPage.forecastDays);

            foreach (var day in dailyData)
            {
                int dayNum = day.Date.Day;
                int monthNum = day.Date.Month;
                int tempMin = (int)day.TempMin;
                int tempMax = (int)day.TempMax;

                ForecastDayBox newforecastDayBox = new ForecastDayBox(dayNum, monthNum, tempMin, tempMax)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                newforecastDayBox.Dock = DockStyle.Top;
                forecastDaysPanel.Controls.Add(newforecastDayBox);
                forecastDaysPanel.Controls.SetChildIndex(newforecastDayBox, 0);
            }
        }
    }
}
