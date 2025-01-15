using spokodynka_winforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spokodynka_gui.Pages
{
    public partial class SettingsPage : UserControl
    {
        private Spokodynka spokodynka = new Spokodynka();
        public static int forecastDays { get; set; } = 5;

        public SettingsPage()
        {
            InitializeComponent();

            for (int i = 0; i <= 16; i++)
            {
                forecastDaySelect.Items.Add(i.ToString());
            }

            forecastDaySelect.SelectedIndex = 5;
        }

        private void forecastDaySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(forecastDaySelect.SelectedItem.ToString(), out int selectedValue))
            {
                forecastDays = selectedValue;
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "";
            ofd.ShowDialog(this); //@michalplatosz ty tu ugotuj pls
        }
    }
}
