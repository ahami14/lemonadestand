using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member vairables (Has A)
        private List<string> names;
        public string name;
        public List<string> weatherConditions;
        Weather conditions;

        //constructor (Spawner)
        public Customer()
        {
            
        }

        //member methods (Can Do)
        public void customerOne()//this is a basic outline, however we may need to find a way to increment the sale in game class
        {//Actually, it is possible that we could increment here, and when this is called in game class it will increment and display there
            if(conditions.condition == "Sunny" || conditions.condition == "Hazy" )
            {
                Console.WriteLine("CustomerOne bought lemonade!");//these will be increments soon, so we don't have to announce every time a customer buys a drink
            }
            else
            {
                Console.WriteLine("CustomerOne did not buy Lemonade.");
            }
        }
        public void customerTwo()
        {
            if (conditions.condition == "Sunny")
            {
                Console.WriteLine("CustomerTwo bought lemonade!");//these will be increments soon, so we don't have to announce every time a customer buys a drink
            }
            else
            {
                Console.WriteLine("CustomerTwo did not buy Lemonade.");
            }
        }
    }
}
