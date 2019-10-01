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

        //constructor (Spawner)

        //member methods (Can Do)
        public void RunGame()
        {
            DisplayRules();
        }


        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand! You will sell lemonade for 7 days.");
            Console.WriteLine("Weather conditions will change throughout the week, but you will get a forecast to plan accordingly!");
            Console.WriteLine("Each day you will hav the option to refill your stock of lemons, sugar, ice cubes, and cups!");
            Console.WriteLine("You start out with $20 to spend! Hopefully you will earn a profit by the end of the week!");
            Console.WriteLine("Starting money: $20");
            Console.WriteLine("Starting Inventory: "); //we could potentially make a list of the inventory the player has and update it based on user input
        }









        // display rules
        //insert a player
        //display inventory every round, decrementing when things are used and incrementing when things are bought 
        //Allow user input when buying things and when deciding what goes in the lemonade
        //Display weather everyday 
        //Create multiple customers with certain parameters that will determine whether or not they will buy lemonade 
    }
}
