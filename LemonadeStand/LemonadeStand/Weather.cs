using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
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
            weatherConditions.Add("Hazy");


        }

        //member methods (Can Do)
        public void ConditionsForWeather()
        {
            Random rng = new Random();

            int index = rng.Next(weatherConditions.Count);

            condition = weatherConditions[index];
        }

        public void SetTemperature()
        {
            Random rng = new Random();
            temperature = rng.Next(60, 100);
            
        }
        public void PredictWeather()
        {
            predictForecast = (condition + temperature);
            Console.WriteLine(predictForecast);
        }
    }
}
