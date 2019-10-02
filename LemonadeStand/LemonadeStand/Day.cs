using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member vairables (Has A)
        public Weather weather;
        public List<Customer> customer;
        public List<string> days;

        //constructor (Spawner)
        public Day()
        {
            weather = new Weather();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }


        //member methods (Can Do)
        public void DisplayDay()
        {

        }
    }
}
