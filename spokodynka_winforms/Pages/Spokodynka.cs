using FileManagement;
using Locations;

namespace spokodynka_winforms
{
    public partial class Spokodynka : Form
    {

        public List<Location> locations = new List<Location>();
        private IFileHandler<XMLHandler> fileHandler = new XMLHandler(); // !!! DO OGARNIECIA: JAK ZROBIC ZEBY NIE BYLO NA SZTYWNO DLA XML (CZY IFILEHANDLER MUSI PRZYJMOWAC ATRYBUT?)

        public Spokodynka()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void LoadLocations()
        {
            try
            {
                locations = fileHandler.LoadData("GeoLocations_Data"); // Nazwa tymczasowa, potem zrobic jakos zeby bralo to jako domyslna ale wprowadzic to jako domyslna I guess??
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading locations: {ex.Message}");
            }
        }

        private Location findPlace(string query)
        {
            return locations.FirstOrDefault(loc => loc.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void Spokodynka_Resize(object sender, EventArgs e)
        {
            MainSidebarPanel.Width = (int)(this.ClientSize.Width * 0.25);
        }

        private void addPlaceBox()
        {
            Location place = findPlace(PlaceTextbox.Text);
            if (!string.IsNullOrWhiteSpace(PlaceTextbox.Text) && place != null)
            {
                string PlaceName = place.Name;

                foreach (Control control in PlaceBoxPanel.Controls)
                {
                    if (control is PlaceBox placeBox && placeBox.PlaceName == PlaceName)
                    {
                        MessageBox.Show("To miejsce ju¿ zosta³o dodane!");
                        PlaceTextbox.Clear();
                        return;
                    }
                }

                PlaceBox newPlaceBox = new PlaceBox(PlaceName)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                newPlaceBox.PlaceSelected += PlaceBox_PlaceSelected;
                PlaceBoxPanel.Controls.Add(newPlaceBox);
                PlaceBoxPanel.Controls.SetChildIndex(newPlaceBox, 0);

                PlaceTextbox.Clear();
            }
            else
            {
                MessageBox.Show("B³¹d wyszukiwania!");
            }
        }

        private void PlaceBox_PlaceSelected(object sender, EventArgs e)
        {
            if (sender is PlaceBox selectedPlace)
            {
                LoadPage(selectedPlace.PlaceName);
            }
        }


        private void PlaceAddBtn_Click(object sender, EventArgs e)
        {
            addPlaceBox();
        }

        private void PlaceTextbox_Enter(object sender, EventArgs e)
        {
            PlaceTextbox.Clear();
        }

        private void SidebarLabel_Click(object sender, EventArgs e)
        {
            foreach(PlaceBox placeBox in PlaceBoxPanel.Controls)
            {
                placeBox.Deselect();
            }
            LoadPage();
        }

        public void LoadPage(string placeName)
        {
            mainContentPanel.Controls.Clear();

            PlacePage placePage = new PlacePage(placeName)
            {
                Dock = DockStyle.Fill
            };

            mainContentPanel.Controls.Add(placePage);
        }

        public void LoadPage()
        {
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(homePage1);
        }
    }
}
