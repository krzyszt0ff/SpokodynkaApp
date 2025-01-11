using Locations;
using ApiCom;

namespace spokodynka_winforms
{
    public partial class PlacePage : UserControl
    {
        private readonly IApiCom _apiCom;
        private Location location;

        public PlacePage()
        {
            InitializeComponent();
        }

        public PlacePage(Location location)
        {
            InitializeComponent();
            placePageName.Text = location.Name;
            this.location = location;

            _apiCom = ApiComFactory.CreateInstance()
                .SetGeoLocation(location.Lat, location.Lon)
                .SetForecastDays(7)
                .ReqHourlyTemp()
                .ReqHourlyHumidity()
                .ReqHourlyWindspeed()
                .ReqHourlySurfacepressure()
                .ReqHourlyPrecipitation();
            LoadWeatherDataAsync();
        }

        private async void LoadWeatherDataAsync()
        {
            try
            {
                List<Record> records = await _apiCom.SendAsync();
                Record currentRecord = records[0];

                if (records != null && records.Count > 0)
                {
                    DisplayHourlyData(records);
                    DisplayDailyData(records);
                    currentTempLabel.Text = currentRecord.temperature.ToString() + "°C";
                    LoadWeatherVisuals(currentRecord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWeatherVisuals(Record record)
        {
            if (record.date.Hour > 6 && record.date.Hour > 18) //daytime
            {
                currentWeatherPicture.BackgroundImage = Spokodynka_gui.Properties.Resources.sun;

            }
            else //nighttime
            {
                currentWeatherPicture.BackgroundImage = Spokodynka_gui.Properties.Resources.moon;
            }

        }

        private void DisplayHourlyData(List<Record> records)
        {
            var hourlyRecords = records.Take(12).ToList();
            int hour = DateTime.Now.Hour; // nie wiem czy tego uzyc czy wartosci z api bo wartosc z api chyba nie dziala

            foreach (var record in hourlyRecords)
            {
                //int hour = record.date.Hour;
                double temp = record.temperature.HasValue ? (double)record.temperature.Value : 0;

                ForecastHourBox newforecastHourBox = new ForecastHourBox(hour, temp)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

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
                .Take(5);

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
