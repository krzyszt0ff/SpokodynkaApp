namespace spokodynka_winforms
{
    public partial class ForecastDayBox : UserControl
    {
        public static ForecastDayBox selectedForecastBox = null;
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

        private void SelectForecastBox()
        {
            if (selectedForecastBox != null && selectedForecastBox != this)
            {
                selectedForecastBox.Deselect();
            }

            selectedForecastBox = this;
            selectBackgroundPanel.BackColor = Color.FromArgb(150, 64, 168, 255); ///kolor zaznaczenia
        }

        public void Deselect()
        {
            selectBackgroundPanel.BackColor = Color.Transparent;
        }

        private void forecastBoxTempLabel_Click(object sender, EventArgs e)
        {
            SelectForecastBox();
        }

        private void forecastBoxTempLabel_MouseEnter(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(150, 255, 255, 255); ///kolor najechania
        }

        private void forecastBoxTempLabel_MouseLeave(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255); ///kolor domyślny
        }

        private void forecastBoxTempLabel_MouseDown(object sender, MouseEventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(150, 200, 200, 200); ///kolor wciśnięcia
        }
    }
}
