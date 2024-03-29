﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        //member vairables (Has A)



        //member methods (Can Do)
        public static void DisplayRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand! You will sell lemonade for 7 days.");
            Console.WriteLine("Weather conditions will change throughout the week, but you will get a forecast to plan accordingly!");
            Console.WriteLine("Each day you will hav the option to refill your stock of lemons, sugar, ice cubes, and cups!");
            Console.WriteLine("You start out with $20 to spend! Hopefully you will earn a profit by the end of the week!");
            Console.WriteLine("Starting money: $20");
        }
        public static void DisplayStock()
        {
            Console.WriteLine("Cups: 25 for 0.85, 50 for 1.73, 100 for 2.96");
            Console.WriteLine("Lemons: 10 for 0.78, 30 for 2.24, 75 for 4.47");
            Console.WriteLine("Cups of Sugar: 8 for 0.69, 20 for 1.52, 48 for 3.30");
            Console.WriteLine("Ice Cubes: 100 for 0.76, 250 for 2.16, 500 for 3.54");
        }

        public static void DisplayWeatherForecast(List<Day> days)
        {
            Console.WriteLine("This is the forecast for this week!");

            foreach (Day day in days)
            {
                Console.WriteLine(day.weather.predictForecast);
            }
        }
        //for actual weather, you can get a method in here to display the variable with the info, but the info will have to be gathered in a different class
        
    }
}
