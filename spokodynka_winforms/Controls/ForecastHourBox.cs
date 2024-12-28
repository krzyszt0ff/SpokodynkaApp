using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spokodynka_winforms
{
    public partial class ForecastHourBox : UserControl
    {
        public ForecastHourBox()
        {
            InitializeComponent();
        }

        public ForecastHourBox(int hour, int temp)
        {
            InitializeComponent();
            this.Margin = new Padding(10);
            forecastHourLabel.Text = hour.ToString() + ":00";
            forecastHourTempLabel.Text = temp.ToString() + "°C";
        }

        private void ForecastHourBox_MouseEnter(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
        }

        private void ForecastHourBox_MouseLeave(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255);

        }

        private void forecastHourTempLabel_MouseEnter(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
        }

        private void forecastHourTempLabel_MouseLeave(object sender, EventArgs e)
        {
            backgroundPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
    }
}
