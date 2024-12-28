using ApiCom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Locations
{
    public class Location
    {
        public string Name;
        public double Lat;
        public double Lon;
        public Location(string Name, double Lat, double Lon) {
            this.Name = Name;
            this.Lat = Lat;
            this.Lon = Lon;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Location: ");
            builder.AppendLine($"   Name: {Name}");
            builder.AppendLine($"   Latitude: {Lat}");
            builder.AppendLine($"   Longitude: {Lon}");
            builder.AppendLine();
            return builder.ToString();
        }

    }
}

