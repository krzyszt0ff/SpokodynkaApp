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
        public static List<PlacePage> loadedPages = new List<PlacePage>();
        private static SettingsPage settingsPage;
        private readonly string path = Path.Combine( //prywatna zmienna na sciezke!!!!!!
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName,
            "WeatherLogic",
            "LocData",
            "GeoLocations_Data.xml"
        );


        public Spokodynka()
        {
            InitializeComponent();
            settingsPage = new SettingsPage(this) { Dock = DockStyle.Fill };
            LoadLocations();
        }

        public void LoadLocations()
        {
            try
            {
                locations = fileHandler.LoadData(path); // Nazwa tymczasowa, potem zrobic jakos zeby bralo to jako domyslna ale wprowadzic to jako domyslna I guess??
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

                PlaceBox newPlaceBox = new PlaceBox(place)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(10)
                };

                newPlaceBox.PlaceRemoved += PlaceBox_PlaceRemoved;
                loadedPages.Add(new PlacePage(newPlaceBox.location) { Dock = DockStyle.Fill });
                newPlaceBox.PlaceSelected += PlaceBox_PlaceSelected;
                PlaceBoxPanel.Controls.Add(newPlaceBox);
                PlaceBoxPanel.Controls.SetChildIndex(newPlaceBox, 0);
                settingsPage.AddExportPlace(PlaceName);

                PlaceTextbox.Clear();
            }
            else
            {
                MessageBox.Show("B³¹d wyszukiwania!");
            }
        }

        private void PlaceBox_PlaceRemoved(object sender, Location location)
        {
            var pageToRemove = loadedPages.FirstOrDefault(page => page.Location.Equals(location));
            if (pageToRemove != null)
            {
                settingsPage.RemoveExportPlace(pageToRemove.Location.Name);
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
            DeselectAllPlaceBoxes();
            LoadHomePage();
        }

        private void DeselectAllPlaceBoxes()
        {
            foreach (PlaceBox placeBox in PlaceBoxPanel.Controls)
            {
                placeBox.Deselect();
            }
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
            DeselectAllPlaceBoxes();
            mainContentPanel.Controls.Clear();
            mainContentPanel.Controls.Add(settingsPage);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadSettingsPage();
        }

        private void PlaceTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPlaceBox();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadedPages.Clear();
            foreach (PlaceBox place in PlaceBoxPanel.Controls)
            {
                loadedPages.Add(new PlacePage(place.location) { Dock = DockStyle.Fill });
            }
        }


    }
}
