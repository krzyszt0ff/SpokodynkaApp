namespace spokodynka_winforms
{
    public partial class PlaceBox : UserControl
    {
        public static PlaceBox selectedPlaceBox = null;
        public event EventHandler PlaceSelected;
        public PlaceBox()
        {
            InitializeComponent();
        }

        public PlaceBox(string name)
        {
            InitializeComponent();
            this.Margin = new Padding(10);
            nameLabel.Text = name;
        }

        public string PlaceName
        {
            get { return nameLabel.Text; }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
            if (selectedPlaceBox == this)
                selectedPlaceBox = null;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            SelectPlaceBox();
        }

        private void nameLabel_MouseEnter(object sender, EventArgs e)
        {
            nameLabel.BackColor = Color.FromArgb(150, 255, 255, 255); ///kolor najechania
        }

        private void nameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            nameLabel.BackColor = Color.FromArgb(150, 200, 200, 200); ///kolor wciśnięcia
        }

        private void nameLabel_MouseLeave(object sender, EventArgs e)
        {
            nameLabel.BackColor = Color.FromArgb(100, 255, 255, 255); ///kolor domyślny
        }

        private void SelectPlaceBox()
        {
            if (selectedPlaceBox != null && selectedPlaceBox != this)
            {
                selectedPlaceBox.Deselect();
            }

            selectedPlaceBox = this;
            backgroundPanel.BackColor = Color.FromArgb(150, 64, 168, 255); ///kolor zaznaczenia

            PlaceSelected?.Invoke(this, EventArgs.Empty);
        }

        public void Deselect()
        {
            backgroundPanel.BackColor = Color.Transparent;
        }
    }
}
