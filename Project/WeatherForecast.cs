using System;

namespace Project
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public int TemperatureF { get; set; }

        public string Summary { get; set; }

        public int CalculateTemperatureF()
        {
            int result;
            result = 32 + (int)(TemperatureC / 0.5556);
            return result;
        }
    }
}
