using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member vairables (Has A)
        Player player;
        List<Day> days;
        int currentDay;
        Store store;
        Day day;
        Weather weather;
        public double priceOfLemonade;
        
        

        //constructor (Spawner)
        public Game()
        {
            
            Random random = new Random();
            days = new List<Day>() { new Day(random), new Day(random), new Day(random), new Day(random), new Day(random), new Day(random), new Day(random) };
            
            //for(int i = 0; i < 7; i++)
            //{
            //    Day day = new Day();
            //    days.Add(day);
            //}

            player = new Player();
            store = new Store();
            day = new Day(random);
            weather = new Weather(random);


        }

        //member methods (Can Do)
        public void RunGame()
        {

            UserInterface.DisplayRules();
            UserInterface.DisplayWeatherForecast(days);
            while (day.numberOfDays <= 7)
            {
                day.CreateCustomer();
                player.recipe.SetRecipe();
                UserInterface.DisplayStock();
                store.BuyCups();
                store.BuyLemon();
                store.BuySugar();
                store.BuyIce();
                Console.WriteLine("Here is your money leftover! " + player.wallet.Money);
                Console.ReadLine();
                player.pitcher.DisplayPitcherCups(player);
                //DisplayActualWeather();
                day.ChoiceToBuy(weather, player, priceOfLemonade);
                Console.WriteLine("Here is your amount of money after the day! " + player.wallet.Money);
                Console.ReadLine();
            }
        }

        //public void DisplayActualWeather()
        //{
        //    Console.WriteLine("Here is the actual weather for today! " + day.weather.actualWeather);
        //}


        









        // display rules
        //insert a player
        //display inventory every round, decrementing when things are used and incrementing when things are bought 
        //Allow user input when buying things and when deciding what goes in the lemonade
        //Display weather everyday 
        //Create multiple customers with certain parameters that will determine whether or not they will buy lemonade 
    }
}
