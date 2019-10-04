using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        //member vairables (Has A)
        public Weather weather;
        public List<Customer> customers;
        public List<string> days;
        

        //constructor (Spawner)
        public Day()
        {
            weather = new Weather();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }


        //member methods (Can Do)
        //will have list and loop of customers here
        public void CreateCustomer()
        {
            for( int i = 0; i<1; i++)
            {
                List<Customer> customers;
                
            }
        }
    }
}
