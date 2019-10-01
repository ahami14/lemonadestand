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
            days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");

        }


        //member methods (Can Do)
    }
}
