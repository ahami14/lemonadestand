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
            customers = new List<Customer>();
            weather = new Weather();
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        }


        //member methods (Can Do)
        //will have list and loop of customers here
        public void CreateCustomer()
        {
            int countOfNewCustomers = 100;

            for( int i = 0; i < countOfNewCustomers; i++)
            {
                
                // create new customer
                // add new customer to list
            }
        }
        public void ChoiceToBuy()
        {
            //this loop will loop throught the method in the customer class determining whether or not they buy lemonade
        }
    }
}
