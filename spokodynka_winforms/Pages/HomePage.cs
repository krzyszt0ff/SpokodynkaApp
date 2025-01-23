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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void EasterEgg(bool value)
        {
            if (value)
            {
                this.spokoPictureBox.BackgroundImage = Spokodynka_gui.Properties.Resources.spoko_kon;
                this.sloganLabel.Text = "Twoja konska pogodynka!";
            }
            else
            {
                this.spokoPictureBox.BackgroundImage = Spokodynka_gui.Properties.Resources.spoko;
                this.sloganLabel.Text = "Twoja spoko pogodynka!";
            }


        }
    }
}
