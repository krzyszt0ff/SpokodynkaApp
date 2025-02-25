﻿using spokodynka_winforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locations;
using FileManagement;
using ApiCom;

namespace Spokodynka_gui.Pages
{
    public partial class SettingsPage : UserControl
    {
        private Spokodynka spokodynka;
        public static int forecastDays { get; set; } = 5;
        bool secretValue = false;

        private readonly string path = Path.Combine(
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName,
            "WeatherLogic",
            "LocData",
            "GeoLocations_Data.xml"
        );

        public SettingsPage(Spokodynka spokodynkaInstance)
        {
            InitializeComponent();
            spokodynka = spokodynkaInstance;

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
        public void AddExportPlace(string placeName)
        {
            if (!exportPlaceSelect.Items.Contains(placeName))
            {
                exportPlaceSelect.Items.Add(placeName);
            }
        }

        public void RemoveExportPlace(string placeName)
        {
            if (exportPlaceSelect.Items.Contains(placeName))
            {
                exportPlaceSelect.Items.Remove(placeName);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "XML and CSV files (*.xml;*.csv)|*.xml;*.csv|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                if (filePath.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    XMLHandler xmlHandler = new XMLHandler();
                    List<Location> importedLocations = xmlHandler.LoadData(filePath);

                    foreach (var location in importedLocations)
                    {
                        xmlHandler.AppendToFile(path, location);
                        spokodynka.LoadLocations();
                    }
                }
                else if (filePath.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                {
                    CSVHandler csvHandler = new CSVHandler();
                    List<Location> importedLocations = csvHandler.LoadData(filePath);

                    XMLHandler xmlHandler = new XMLHandler();
                    foreach (var location in importedLocations)
                    {
                        xmlHandler.AppendToFile(path, location);
                        spokodynka.LoadLocations();
                    }
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string placeName = exportPlaceSelect.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(placeName))
            {
                MessageBox.Show("Nie wybrano miejsca do eksportu!");
                return;
            }

            PlacePage selectedPage = Spokodynka.loadedPages
            .FirstOrDefault(page => page.Location.Name.Equals(placeName, StringComparison.OrdinalIgnoreCase));
            List<Record> selectedRecords = selectedPage.records;

            Location location = spokodynka.locations.FirstOrDefault(loc => loc.Name.Equals(placeName, StringComparison.OrdinalIgnoreCase));

            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "XML files (.xml)|.xml|CSV files (.csv)|.csv|Text files (.txt)|.txt",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = $"{placeName}_forecast.{forecastDays}"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                try
                {
                    switch (fileExtension)
                    {
                        case ".xml":
                            XMLHandler xmlHandler = new XMLHandler();
                            xmlHandler.SaveData(filePath, new List<Location> { location });
                            break;

                        case ".csv":
                            CSVHandler csvHandler = new CSVHandler();
                            csvHandler.SaveData(filePath, new List<Location> { location });
                            break;

                        case ".txt":
                            TxtHandler txtHandler = new TxtHandler();
                            txtHandler.Export(filePath, selectedRecords, location);
                            break;

                        default:
                            MessageBox.Show("Nieobsługiwany format pliku!");
                            return;
                    }

                    MessageBox.Show("Dane zostały zapisane pomyślnie!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd podczas zapisu: {ex.Message}");
                }
            }
        }

        private void konieCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            secretValue = !secretValue;
            if (secretValue)
            {
                spokodynka.BackgroundImage = Spokodynka_gui.Properties.Resources.konie_bg;
            }
            else
            {
                spokodynka.BackgroundImage = Spokodynka_gui.Properties.Resources.bg;
            }
            spokodynka.isEasterEggOn(secretValue);
        }
    }
}

