using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace ApiCom
{
    public interface IApiCom
    {

        /// <summary>
        /// Send built API request
        /// </summary>
        Task<List<Record>> SendAsync();


        /// <summary>
        /// Append Geolocation data to API request
        /// </summary>
        public IApiCom SetGeoLocation(double Latitude, double Longitude);

        /// <summary>
        /// Specify how many days of forecast shall be requested
        /// </summary>
        public IApiCom SetForecastDays(int Days);

        /// <summary>
        /// Specify how many days from the past shall be requested
        /// </summary>
        public IApiCom SetPastDays(int Days);


        /// <summary>
        /// Add request for hourly temperature to API request
        /// </summary>
        public IApiCom ReqHourlyTemp();

        /// <summary>
        /// Add request for hourly humidity to API request
        /// </summary>
        public IApiCom ReqHourlyHumidity();



        /// <summary>
        /// Add request for hourly wind speed to API request
        /// </summary>
        public IApiCom ReqHourlyWindspeed();


        /// <summary>
        /// Add request for hourly Surface preassure to API request
        public IApiCom ReqHourlySurfacepressure();


        /// <summary>
        /// Add request for hourly Precipitation to API request, data is stored inside Precipitation object
        /// </summary>
        public IApiCom ReqHourlyPrecipitation();

    }


    /// <summary>
    /// Class used to represnt single record of weather data
    /// </summary>
    public class Record
    {
        public DateTime date { get; internal set; }
        public double? temperature { get; internal set; }
        public int? humidity { get; internal set; }
        public double? windspeed { get; internal set; }
        public double? surfacepressure { get; internal set; }
        public Precipitation? prec { get; internal set; }

        public Record(String date, double? temperature, int? humidity, double? windspeed, double? surfacepressure, Precipitation? prec)
        {
            this.date = DateTime.Parse(date);
            this.temperature = temperature;
            this.humidity = humidity;
            this.windspeed = windspeed;
            this.surfacepressure = surfacepressure;
            this.prec = prec;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Record: ");
            builder.AppendLine($"   Date: {date}");
            if (temperature is not null) builder.AppendLine($"   Temperature: {temperature}");
            if (humidity is not null) builder.AppendLine($"   Humidity: {humidity}");
            if (windspeed is not null) builder.AppendLine($"   Wind speed: {windspeed}");
            if (surfacepressure is not null) builder.AppendLine($"   Surface pressure: {surfacepressure}");
            if (prec is not null) builder.AppendLine($"   {prec}");
            builder.AppendLine();
            return builder.ToString();

        }

    }

    public class Precipitation
    {
        public int probability { get; internal set; }
        public double rain { get; internal set; }
        public double showers { get; internal set; }
        public double snowfall { get; internal set; }

        public Precipitation(int probability, double rain, double showers, double snowfall)
        {
            this.probability = probability;
            this.rain = rain;
            this.showers = showers;
            this.snowfall = snowfall;
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Precipitation: ");
            builder.AppendLine($"   Probability: {probability}");
            builder.AppendLine($"   Rain: {rain}");
            builder.AppendLine($"   Showers: {showers}");
            builder.AppendLine($"   Snowfall: {snowfall}");
            builder.AppendLine();
            return builder.ToString();

        }
    }

    internal class APICom : IApiCom
    {

        // Internal helping classes
        private class WeatherData
        {

            [JsonPropertyName("time")]
            public List<string>? Time { get; set; }

            [JsonPropertyName("temperature_2m")]
            public List<double>? Temperature { get; set; }

            [JsonPropertyName("relative_humidity_2m")]
            public List<int>? Humidity { get; set; }

            [JsonPropertyName("wind_speed_10m")]
            public List<double>? Windspeed { get; set; }

            [JsonPropertyName("precipitation_probability")]
            public List<int>? PrecipitationProbability { get; set; }

            [JsonPropertyName("rain")]
            public List<double>? Rain { get; set; }

            [JsonPropertyName("showers")]
            public List<double>? Showers { get; set; }

            [JsonPropertyName("snowfall")]
            public List<double>? Snowfall { get; set; }

            [JsonPropertyName("surface_pressure")]
            public List<double>? Surfacepressure { get; set; }

        }

        private class ApiResponse
        {
            [JsonPropertyName("latitude")]
            public float Latitude { get; set; }

            [JsonPropertyName("longitude")]
            public float Longitude { get; set; }

            [JsonPropertyName("hourly")]
            public WeatherData? weatherData { get; set; }
        }

        private class RecordListFactory
        {
            public List<Record> GetRecords(ApiResponse resp)
            {

                List<Record> records = new List<Record>();

                if (resp.weatherData is not null)
                {
                    WeatherData h = resp.weatherData;

                    for (int i = 0; i < h.Time.Count; i++)
                    {

                        Record record = new Record(
                            h.Time[i],
                            h.Temperature?.Count > i ? (double?)h.Temperature[i] : null,
                            h.Humidity?.Count > i ? (int?)h.Humidity[i] : null,
                            h.Windspeed?.Count > i ? (double?)h.Windspeed[i] : null,
                            h.Surfacepressure?.Count > i ? (double?)h.Surfacepressure[i] : null,
                            h.PrecipitationProbability?.Count > i ? new Precipitation(h.PrecipitationProbability[i], h.Rain[i], h.Showers[i], h.Snowfall[i]) : null
                        );


                        records.Add(record);
                    }
                }

                return records;
            }
        }



        // Static objects

        private static HttpClient client = client == null ? new HttpClient() : client;
        private static RecordListFactory recordListFactory = recordListFactory == null ? new RecordListFactory() : recordListFactory;


        // Attributes

        private String parameters = "";
        private String hourly = "hourly=";
        private bool latLenSet = false;


        // https://open-meteo.com/en/docs


        //Building methods
        public IApiCom SetGeoLocation(double Latitude, double Longitude)
        {
            parameters += $"{(parameters.Length > 0 ? "&" : string.Empty)}latitude={Latitude.ToString().Replace(',', '.')}&longitude={Longitude.ToString().Replace(',', '.')}";
            latLenSet = true;
            return this;
        }

        public IApiCom SetForecastDays(int Days)
        {

            if (Days > 16 || Days < 0)
            {
                throw new Exception("Invalid number of days, acceptable range is (0;16)");
            }


            parameters += $"{(parameters.Length > 0 ? "&" : string.Empty)}forecast_days={Days}";
            return this;
        }

        public IApiCom SetPastDays(int Days)
        {
            if (Days < 0)
            {
                throw new Exception("Invalid number of days, value must be grater than 0");
            }


            parameters += $"{(parameters.Length > 0 ? "&" : string.Empty)}past_days={Days}";
            return this;
        }


        // Request hourly temperature
        public IApiCom ReqHourlyTemp()
        {
            hourly += $"{(hourly.Length > 7 ? "," : string.Empty)}temperature_2m";
            return this;
        }

        // Request hourly humidity
        public IApiCom ReqHourlyHumidity()
        {
            hourly += $"{(hourly.Length > 7 ? "," : string.Empty)}relative_humidity_2m";
            return this;
        }


        // Request hourly wind speed
        public IApiCom ReqHourlyWindspeed()
        {
            hourly += $"{(hourly.Length > 7 ? "," : string.Empty)}wind_speed_10m";
            return this;
        }


        // Request hourly rains, showers, and snowfall
        public IApiCom ReqHourlyPrecipitation()
        {
            hourly += $"{(hourly.Length > 7 ? "," : string.Empty)}precipitation_probability,rain,showers,snowfall";
            return this;
        }


        // Request hourly surface preassure levels
        public IApiCom ReqHourlySurfacepressure()
        {
            hourly += $"{(hourly.Length > 7 ? "," : string.Empty)}surface_pressure";
            return this;
        }


        public async Task<List<Record>> SendAsync()
        {

            if (!latLenSet)
            {
                throw new Exception("Latitude and Longitude not specified");
            }

            if(hourly.Length < 8)
            {
                throw new Exception("No data requested");
            }


            string APIUrl = $"https://api.open-meteo.com/v1/forecast?{parameters}&{hourly}";
            HttpResponseMessage response = await client.GetAsync(APIUrl);


            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();


            ApiResponse apiResponse = JsonSerializer.Deserialize<ApiResponse>(data, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            List<Record> RecordList = recordListFactory.GetRecords(apiResponse);


            this.parameters = "";
            this.hourly = "hourly=";
            this.latLenSet = false;


            return RecordList;

        }

    }
}
