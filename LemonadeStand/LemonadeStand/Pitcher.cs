using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        //member variable (Has A)
        public int cupsLeftInPitcher;
        Player player;
        Recipe recipe;

        //constructor (Spawner)
        public Pitcher()
        {
            Player player = new Player();
            Recipe recipe = new Recipe();
        }

        //member methods (Can Do)
        public void DisplayPitcherCups()
        {
            string thingToPrint = "";
            thingToPrint += player.recipe.amountOfLemons + "\n";
            thingToPrint += player.recipe.amountOfSugar + "\n";
            Console.WriteLine(thingToPrint);
        }
    }
}
