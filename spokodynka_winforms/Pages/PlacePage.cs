namespace spokodynka_winforms
{
    public partial class PlacePage : UserControl
    {
        public PlacePage()
        {
            InitializeComponent();
            AddHours(0, 0);
            AddDays(1,1,0,0);
        }
        public PlacePage(string name)
        {
            InitializeComponent();
            placePageName.Text = name;
            AddHours(0, 0);
            AddDays(1, 1, 0, 0);
        }
        public void AddHours(int hour, int temp)
        {
            for (int i = 0; i < 12; i++)
            {
                ForecastHourBox newforecastHourBox = new ForecastHourBox(hour + i, temp + i)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                newforecastHourBox.Dock = DockStyle.Left;
                hourlyForecastPanel.Controls.Add(newforecastHourBox);
                hourlyForecastPanel.Controls.SetChildIndex(newforecastHourBox, 0);
            }
        }

        public void AddDays(int day, int month, int tempmin, int tempmax)
        {
            for (int i = 0; i < 5; i++)
            {
                ForecastDayBox newforecastDayBox = new ForecastDayBox(day + i, month, tempmin, tempmax)
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
