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
            names = new List<string>();
            

        }

        //member methods (Can Do)
        public void DecisionToBuy()
        {

        }
            
    }
}
