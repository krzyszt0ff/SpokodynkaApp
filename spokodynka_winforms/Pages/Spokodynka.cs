using ApiCom;
using FileManagement;
using Locations;
using Spokodynka_gui.Pages;

namespace spokodynka_winforms
{
    public partial class Spokodynka : Form
    {

        public List<Location> locations = new List<Location>();
        private IFileHandler<XMLHandler> fileHandler = new XMLHandler(); // !!! DO OGARNIECIA: JAK ZROBIC ZEBY NIE BYLO NA SZTYWNO DLA XML (CZY IFILEHANDLER MUSI PRZYJMOWAC ATRYBUT?)
        public List<PlacePage> loadedPages = new List<PlacePage>();
        private SettingsPage settingsPage = new SettingsPage() { Dock = DockStyle.Fill };

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
            return locations.FirstOrDefault(loc => loc.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0); ///Wyszukiwanie do poprawienia!!! Za bardzo wyszukuje,,,,,
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
                        MessageBox.Show("To miejsce ju� zosta�o dodane!");
                        PlaceTextbox.Clear();
                        return;
                    }
                }

                PlaceBox newPlaceBox = new PlaceBox(place)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                newPlaceBox.PlaceRemoved += PlaceBox_PlaceRemoved;

                loadedPages.Add(new PlacePage(newPlaceBox.location));
                newPlaceBox.PlaceSelected += PlaceBox_PlaceSelected;
                PlaceBoxPanel.Controls.Add(newPlaceBox);
                PlaceBoxPanel.Controls.SetChildIndex(newPlaceBox, 0);

                PlaceTextbox.Clear();
            }
            else
            {
                MessageBox.Show("B��d wyszukiwania!");
            }
        }

        private void PlaceBox_PlaceRemoved(object sender, Location location)
        {
            var pageToRemove = loadedPages.FirstOrDefault(page => page.Location.Equals(location));
            if (pageToRemove != null)
            {
                loadedPages.Remove(pageToRemove);
            }
        }


        private void PlaceBox_PlaceSelected(object sender, EventArgs e)
        {
            if (sender is PlaceBox selectedPlace)
            {
                LoadPage(selectedPlace.location);
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
            foreach (PlaceBox placeBox in PlaceBoxPanel.Controls)
            {
                placeBox.Deselect();
            }
            LoadHomePage();
        }

        public void SetBackgroundImage(Image image) //do usuniecia?? nie wiem czy zmienianie tel nie przekomplikuje wielu rzeczy
        {
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void LoadPage(Location location)
        {
            mainContentPanel.Controls.Clear();

            var cachedPage = loadedPages.FirstOrDefault(page => page.Location.Equals(location));

            if (cachedPage == null)
            {
                cachedPage = new PlacePage(location)
                {
                    Dock = DockStyle.Fill
                };
                loadedPages.Add(cachedPage);
            }

            mainContentPanel.Controls.Add(cachedPage);
        }

        public void LoadHomePage()
        {
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(homePage1);
        }

        public void LoadSettingsPage()
        {
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(settingsPage);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadSettingsPage();
        }
    }
}
