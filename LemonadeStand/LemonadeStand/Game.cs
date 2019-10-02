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
        public Game()
        {
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
            player = new Player();
        }

        //member methods (Can Do)
        public void RunGame()
        {
            UserInterface.DisplayRules();
            player.recipe.SetRecipe();
        }



        public void CustomersChoice()
        {
            Weather weather = new Weather();
        }









        // display rules
        //insert a player
        //display inventory every round, decrementing when things are used and incrementing when things are bought 
        //Allow user input when buying things and when deciding what goes in the lemonade
        //Display weather everyday 
        //Create multiple customers with certain parameters that will determine whether or not they will buy lemonade 
    }
}
