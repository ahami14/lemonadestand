using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //member vairables (Has A)
        public string name;
        public List<string> weatherConditions;
        Weather conditions;
        Player player;

        //constructor (Spawner)
        public Customer()
        {
            Player player = new Player();

        }
        

        //member methods (Can Do)
        public void DecisionToBuy(Weather weather)//done here
        {
            if (weather.condition == "Sunny" || weather.condition == "Partly Cloudy" || weather.condition == "Cloudy" && weather.temperature >= 65 && weather.temperature <= 100);
            player.wallet.Money ++ ;
        }
            
    }
}
