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
        public double money;
        // Weather conditions;
        // Player player;

        //constructor (Spawner)
        public Customer()
        {

            

        }
        

        //member methods (Can Do)
        public void DecisionToBuy(Weather weather, Player player, double priceOfLemonade)
        {

            if (weather.condition == "Sunny" || weather.condition == "Partly Cloudy" || weather.condition == "Cloudy" && weather.temperature >= 65 && weather.temperature <= 100);
            player.wallet.Money += priceOfLemonade ;
        }

        internal bool DecisionToBuy(Weather weather1, Weather weather2, Player player1, object player2, object priceOfLemonade)
        {
            throw new NotImplementedException();
        }
    }
}
