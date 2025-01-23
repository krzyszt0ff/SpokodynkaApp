
using ApiCom;
using Locations;

using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Xml;

namespace FileManagement
{


    public interface IFileHandler<T>
    {
        public List<Location> LoadData(string filename);

        public bool SaveData(string filename, List<Location> locations);

        public T AppendToFile(string filename, Location location);
      
    }

    /// <summary>
    /// XML files handler allows reading, writing and appending data
    /// </summary>
    public class XMLHandler(): IFileHandler<XMLHandler>
    {
        private readonly string path = Path.Combine(
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName,
            "WeatherLogic",
            "LocData"
        );


        /// <summary>
        /// Load data from {filename} path , .xml format is already specified
        /// </summary>
        public List<Location> LoadData(string filepath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(filepath);
            XmlNodeList locationNoodes = document.SelectNodes("/root/row");

            List<Location> locations = new List<Location>();



            for (int i = 0; i < locationNoodes.Count; i++)
            {
                XmlNode place = locationNoodes[i];
                try
                {
                    string raw_lat = place.SelectSingleNode("lat").InnerText;
                    string raw_lon = place.SelectSingleNode("lon").InnerText;
                    string name = place.SelectSingleNode("miasto").InnerText;


                    if (raw_lat == null || raw_lon == null || name == null)
                    {
                        continue;
                    }

                    double Lat = double.Parse(raw_lat, CultureInfo.InvariantCulture);
                    double Lon = double.Parse(raw_lon, CultureInfo.InvariantCulture);

                    locations.Add(new Location(name, Lat, Lon));

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception while reading file on line {i} : {ex}");
                }
            }


            return locations;
        }


        /// <summary>
        /// Save data to {filename} path , .xml format is already specified. Would overwrite existing files!
        /// </summary>
        public bool SaveData(string filepath, List<Location> locations)
        {
            try
            {
                XmlDocument document = new XmlDocument();


                XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = document.DocumentElement;
                document.InsertBefore(xmlDeclaration, root);

                XmlElement rootElement = document.CreateElement(string.Empty, "root", string.Empty);
                document.AppendChild(rootElement);


                foreach (Location location in locations)
                {
                    AppendToDocument(location, document, rootElement);
                }

                document.Save(filepath);
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine($"Exception encountered whille saving data: {ex}");
                return false;
            }

        }


        /// <summary>
        /// Append data to {filename} path , .xml format is already specified. If filename does not exist, it creates a new file with single entry
        /// </summary>
        public XMLHandler AppendToFile(string filepath, Location location)
        {
            XmlDocument document = new XmlDocument();
            XmlElement rootElement;

            if (File.Exists(filepath))
            {
                document.Load(filepath);
                rootElement = (XmlElement)document.SelectSingleNode("/root");
            }
            else
            {
                rootElement = document.CreateElement(string.Empty, "root", string.Empty);
                document.AppendChild(rootElement);
            }



            AppendToDocument(location, document, rootElement);
            document.Save(filepath);
            return this;
        }



        // Private function to be reused in SaveData and AppendToFile
        private XMLHandler AppendToDocument(Location location ,XmlDocument document, XmlElement rootElement)
        {
            XmlElement row = document.CreateElement(string.Empty, "row", string.Empty);
            rootElement.AppendChild(row);

            XmlElement miasto = document.CreateElement(string.Empty, "miasto", string.Empty);
            XmlText miastoName = document.CreateTextNode(location.Name);
            miasto.AppendChild(miastoName);
            row.AppendChild(miasto);


            XmlElement latitude = document.CreateElement(string.Empty, "lat", string.Empty);
            XmlText latVal = document.CreateTextNode(location.Lat.ToString().Replace(',', '.'));
            latitude.AppendChild(latVal);
            row.AppendChild(latitude);

            XmlElement longitude = document.CreateElement(string.Empty, "lon", string.Empty);
            XmlText lonVal = document.CreateTextNode(location.Lon.ToString().Replace(',', '.'));
            longitude.AppendChild(lonVal);
            row.AppendChild(longitude);

            return this;
        }

    }


    /// <summary>
    /// CSV files handler allows reading, writing
    /// </summary>
    public class CSVHandler: IFileHandler<CSVHandler>
    {
        private readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocData/");

        /// <summary>
        /// Load data from {filename} path , .csv format is already specified
        /// </summary>
        public List<Location> LoadData(string filepath)
        {
            if (File.Exists(filepath))
            {
                List<Location> Locations = new List<Location>();

                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');

                        try
                        {
                            Locations.Add(new Location(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), double.Parse(fields[2], CultureInfo.InvariantCulture)));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"Error in entry: {fields[0]}, {fields[1]}, {fields[2]} - {ex}");
                        }

                    }
                }

                return Locations;
            }
            else
            {
                return new List<Location>();
            }
        }

        /// <summary>
        /// Save data to {filename} path , .csv format is already specified. Would overwrite existing files!
        /// </summary>
        public bool SaveData(string filename, List<Location> places)
        {
            try
            {
                StringBuilder csvContent = new StringBuilder();
                csvContent.AppendLine("Name,Latitude,Longitude");

                foreach (Location place in places)
                {
                    csvContent.AppendLine($"{place.Name},{place.Lat.ToString().Replace(',', '.')},{place.Lon.ToString().Replace(',', '.')}");
                }

                File.WriteAllText(Path.Combine(path, filename + ".csv"), csvContent.ToString());
                Console.WriteLine("Data exported to CSV file successfully.");

                return true;
            }
            catch (Exception ex) { 
                Console.WriteLine($"Error exporting to CSV: {ex.Message}"); 
                return false; 
            }
        }

        /// <summary>
        /// Append data to {filename} path , .csv format is already specified. If filename does not exist, it creates a new file with single entry
        /// </summary>
        public CSVHandler AppendToFile(string filename, Location place)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(path, filename + ".csv"), append: true))
                {
                    string newLine = $"{place.Name},{place.Lat},{place.Lon}";
                    writer.WriteLine(newLine);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to the CSV file:");
                Console.WriteLine(ex.Message);
                
            }

            return this;
        }




    }

    /// <summary>
    /// Txt files handler allows export of single weather data combined with a place
    /// </summary>
    public class TxtHandler
    {
        private readonly string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Exports/");
        private StreamWriter writer;

        public void Export(string filepath, List<Record> weatherRecords, Location place)
        {
            try
            {
                if (place == null) throw new ArgumentException("Invalid data format");
                if ((place.Lat == 0 || place.Lon == 0) && string.IsNullOrEmpty(place.Name)) throw new ArgumentException("No location for the data to go with.");

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                writer = new StreamWriter(filepath);

                writer.WriteLine($"---{place.Name}---");
                writer.WriteLine($"Latitude and longitude: {place.Lat} : {place.Lon}");

                foreach (var weather in weatherRecords)
                {
                    writer.WriteLine($"Date: {weather.date:dd-MM-yyyy:HH:mm:ss}");

                    if (weather.temperature != null) writer.WriteLine($"Temperature: {weather.temperature}");
                    if (weather.humidity != null) writer.WriteLine($"Humidity: {weather.humidity}");
                    if (weather.windspeed != null) writer.WriteLine($"Windspeed: {weather.windspeed}");
                    if (weather.surfacepressure != null) writer.WriteLine($"Surfacepressure: {weather.surfacepressure}");

                    if (weather.prec != null) writer.WriteLine($"Probability: {weather.prec.probability}");
                    if (weather.prec != null) writer.WriteLine($"Rain: {weather.prec.rain}");
                    if (weather.prec != null) writer.WriteLine($"Showers: {weather.prec.showers}");
                    if (weather.prec != null) writer.WriteLine($"Snowfall: {weather.prec.snowfall}");

                    writer.WriteLine();
                }

                writer.WriteLine($"---{place.Name}---");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting to TXT: {ex.Message}");
            }
            finally
            {
                writer?.Close();
            }
        }
    }



}

