namespace spokodynka_winforms
{
    public partial class ForecastDayBox : UserControl
    {
        public ForecastDayBox()
        {
            InitializeComponent();
        }

        public ForecastDayBox(int day, int month, int mintemp, int maxtemp)
        {
            InitializeComponent();
            this.Margin = new Padding(10);
            forecastBoxDateLabel.Text = $"{day}.{month}";
            forecastBoxTempLabel.Text = mintemp + "° | " + maxtemp + "°";
        }

        public void Deselect()
        {
            selectBackgroundPanel.BackColor = Color.Transparent;
        }

        private void forecastBoxTempLabel_MouseEnter(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(150, 255, 255, 255); ///kolor najechania
        }

        private void forecastBoxTempLabel_MouseLeave(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255); ///kolor domyślny
        }
    }
}
