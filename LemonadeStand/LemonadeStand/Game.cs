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

        //constructor (Spawner)
        public Game()
        {
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
            
            //for(int i = 0; i < 7; i++)
            //{
            //    Day day = new Day();
            //    days.Add(day);
            //}

            player = new Player();
            store = new Store();
        }

        //member methods (Can Do)
        public void RunGame()
        {

            UserInterface.DisplayRules();
            UserInterface.DisplayWeatherForecast(days);
            player.recipe.SetRecipe();
            UserInterface.DisplayStock();
            store.BuyCups();
            store.BuyLemon();
            store.BuySugar();
            store.BuyIce();
            Console.WriteLine(player.wallet.Money);
            player.pitcher.DisplayPitcherCups();
            UserInterface.DisplayActualWeather(days);
        }


        









        // display rules
        //insert a player
        //display inventory every round, decrementing when things are used and incrementing when things are bought 
        //Allow user input when buying things and when deciding what goes in the lemonade
        //Display weather everyday 
        //Create multiple customers with certain parameters that will determine whether or not they will buy lemonade 
    }
}
