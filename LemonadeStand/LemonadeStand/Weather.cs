using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member vairables (Has A)
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictForecast;

        //constructor (Spawner)
        public Weather()
        {
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Partly Cloudy");
        }

        //member methods (Can Do)
    }
}
