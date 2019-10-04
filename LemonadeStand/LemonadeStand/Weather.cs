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
        public string actualWeather;
        public int actualTemperature;
        public string actualCondition;

        //constructor (Spawner)
        public Weather()
        {
            weatherConditions = new List<string>();
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
            weatherConditions.Add("Partly Cloudy");
            weatherConditions.Add("Hazy");

            ConditionsForWeather();
            SetTemperature();
            PredictWeather();
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
            predictForecast = (condition + " " + temperature);
        }

        public void SetActualTemperature()
        {
            Random rng = new Random();
            actualTemperature = rng.Next(temperature - 10);
        }
        public void SetActualCondition()
        {
            Random rng = new Random();

            int index = rng.Next(weatherConditions.Count);

            actualCondition = weatherConditions[index];
        }
        public void DisplayActualWeather()
        {
            actualWeather = (actualCondition + " " + actualTemperature);
        }
    }
}
