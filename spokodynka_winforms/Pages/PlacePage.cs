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
                .SetForecastDays(5)
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

                if (records != null && records.Count > 0)
                {
                    DisplayHourlyData(records);
                    DisplayDailyData(records);
                    currentTempLabel.Text = records[0].temperature.ToString() + "°C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas pobierania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayHourlyData(List<Record> records)
        {
            // Pobranie pierwszych 12 rekordów do wyświetlenia godzinowego
            var hourlyRecords = records.Take(12).ToList();

            foreach (var record in hourlyRecords)
            {
                int hour = record.date.Hour;
                int temp = record.temperature.HasValue ? (int)record.temperature.Value : 0;

                ForecastHourBox newforecastHourBox = new ForecastHourBox(hour, temp)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

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
