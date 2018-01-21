using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvSite.Models
{
    public class OpenWeatherResponse
    {
        public string Name { get; set; }

        public IEnumerable<WeatherDescription> Weather { get; set; }

        public Main Main { get; set; }

        public Wind Wind { get; set; }

        public sys Sys { get; set; }

        public int id { get; set; }
    }

    public class WeatherDescription
    {
        public string Main { get; set; }
        public string Description { get; set; }

        public string icons { get; set; }
    }

    public class Main
    {
        public string Temp { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string Temp_max { get; set; }
        public string Temp_min { get; set; }
    }

    public class Wind
    {
        public string speed { get; set; }

        public string deg { get; set; }
    }

    public class sys
    {
        public string country { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }
}