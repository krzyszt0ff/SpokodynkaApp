## Główne klasy i ich metody

Metody klasy ApiCom:

| Nazwa metody | Funkcja |
| ------ | ------ |
| SetGeoLocation(double lat, double lon) | Wymagane wywołanie. Metoda ta ustawia szerokość i wysokość geograficzną z której API ma pobrać dane |
| SetForecastDays(int days) | Metoda ustawia z ilu dni w przyszłość ma być pobrana prognoza pogody, dozwolony zakres dni to od 0 do 16 |
| SetPastDays(int days) | Metoda ustawia z ilu dni z przeszłości powinna być pobrana pogoda |
| ReqHourlyTemp() | Metoda dodaje do zapytania informacje o temperaturze ( w stopniach celcjusza) |
| ReqHourlyHumidity() | Metoda dodaje do zapytania informacje o względnej wilgotności |
| ReqHourlyWindspeed() | Metoda dodaje do zapytania informacje o prędkości wiatru (w km/h) |
| ReqHourlySurfacepressure() | Metoda dodaje do zapytania informacje o ciśnieniu |
| ReqHourlyPrecipitation() | Metoda dodaje do zapytania informacje o opadach, przechowywane są w klasie Precipitation |

Klasa ApiCom definiuje dwie klasy obiektów: Record i Precipitation

struktura obiektów Record:

```  
public DateTime date 
public double? temperature
public int? humidity
public double? windspeed 
public double? surfacepressure
public Precipitation? prec

```

W każdym rekordzie pewna jest data, reszta danych jest nullable.

struktura obiektów Precipitation:
```
public int probability 
public double rain
public double showers
public double snowfall

```


Metody klasy XMLHandler i CSVHandler:

| Nazwa metody | Funkcja |
| ------ | ------ |
| LoadData(string filename) | Pobiera dane z pliku \{filename} |
| SaveData(string filename, List\<Location> locations ) | Zapisuje dane o lokacjach do pliku \{filename}, nadpisując istniejący już plik |
| AppendToFile(string filename, Location location) | Metoda dodaje do pliku \{filename} nowy wpis o lokacji \{location} |

Metody Klasy TxtHandler:

| Nazwa metody | Funkcja |
| ------ | ------ |
| Export(string filename ,Record weather, Location place) | Zapisuje do pliku txt \{filename} informacje o podanej pogodzie i lokalizacji |

## Przykłady:

Zapytanie do Api z użyciem klasy ApiCom

```
    IApiCom apiCom = new APICom();

    // Zapytanie ze wszystkimi dostępnymi metodami
    apiCom.SetGeoLocation(52.13, 31.24).SetForecastDays(1).SetPastDays(5).ReqHourlyTemp().ReqHourlyHumidity().ReqHourlyWindspeed().ReqHourlyPrecipitation().ReqHourlySurfacepressure();

    // Wysłanie zbudowanego zapytania, i oczekiwanie na odpowiedź
    List<Record> response = await apiCom.SendAsync();

    // Wyświetlenie uzyskanej odpowiedzi
    foreach (Record record in response)
    {
        Console.WriteLine(record);            
    }

```


Obsługa plików XML

```
    XMLHandler xml_data = new XMLHandler();

    List<Location> dataFromXml = xml_data.LoadData("GeoLocations_Data"); // Załadowanie domyślnie istniejącego pliku z danymi

    foreach(Location location in dataFromXml)
    {
        Console.WriteLine(location);
    }

    xml_data.SaveData("new_geolocations", dataFromXml); // Zapisanie pobranych wcześniej danych do nowego pliku o nazwie "new_geolocations"

    xml_data.AppendToFile("skibidi", new Location("skibidus", 21.37, 69)); // Dodanie nowego wpisu w nowym pliku "skibidus.xml""
    xml_data.AppendToFile("new_geolocations", new Location("skibidus", 21.37, 69)); // Dodanie nowego wpisu w istniejącym pliku "new_geolocations"
```

Obsługa plików CSV


```
    CSVHandler csv_data = new CSVHandler();

    XMLHandler xml_data = new XMLHandler(); // Utworzenie instancji obiektu XMLHandler w celu wczytania danych
    List<Location> dataFromXml = xml_data.LoadData("GeoLocations_Data"); // Wczytanie danych z pliku xml

    csv_data.SaveData("csv_data", dataFromXml); // Zapisanie wczytanych danych jako plik csv pod nazwą "csv_data"

    List<Location> new_csv_data = csv_data.LoadData("csv_data"); // Wczytanie z pliku zapisanych przed chwilą danych do nowej zmiennej


    // Wyświetlanie danych z nowego pliku csv
    foreach (Location entry in new_csv_data)
    {
        Console.WriteLine(entry);
    }

```


Export do pliku txt


```
    TxtHandler txt_handler = new TxtHandler();
    Location location = new Location("Sledzikowo", 53.1345005504925, 23.134627602104985); // Stworzenie nowej lokacji 
    IApiCom apiCom = new APICom();

    apiCom.SetGeoLocation(location.Lat, location.Lon).SetForecastDays(1).ReqHourlyPrecipitation().ReqHourlyTemp(); // Pobranie danych o opadach i temperaturze z utowrzonej przed chwilą lokacji

    List<Record> records = await apiCom.SendAsync();

    txt_handler.Export("main", records[0], location); // Export danych o pogodzie i lokacji do pliku "main.txt"
    txt_handler.Export("main", records[1], location); // Nadpisanie poprzednich danych
```

## Todos:
- Poprawić export danych w klasie TxtHandler, umożliwić zapis wielu danych (wykorzystać klasę WeatherAtLocation)
- Dodać nową klasę która łączy dane klasy Location z danymi klasy Record
- Możliwośc rozszerzenia istniejących klas xml i csv (przy pomocy dekoratora?, nie jestem pewien) o możliwość exportu danych jak w przypadku .txt (wykorzystać klasę WeatherAtLocation)
- Wykorzystać zależność wspólnego interface'u klas xml i csv Handler w celu dodania wzorca adapter
- Upewnić się że nie ma wycieków pamięci w klasach odpowiedzialnych za obsługę pliku
