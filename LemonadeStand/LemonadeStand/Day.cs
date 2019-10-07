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
        Customer customer;
        public int numberOfDays = 7;

        //constructor (Spawner)
        public Day(Random random)
        {
            customers = new List<Customer>();
            weather = new Weather(random);
            days = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            

        }


        //member methods (Can Do)
        //will have list and loop of customers here
        public void CreateCustomer()
        {
            int countOfNewCustomers = 100;

            for( int i = 0; i < countOfNewCustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                // create new customer
                // add new customer to list
            }
        }
        public void ChoiceToBuy(Weather weather, Player player, double priceOfLemonade)
        {
            foreach (Customer customer in customers)
            {
                if (weather.condition == "Sunny" || weather.condition == "Partly Cloudy" || weather.condition == "Cloudy" && weather.temperature >= 70 && weather.temperature <= 100) ;
                
                player.wallet.Money += priceOfLemonade;
                //loop customers over method
                //compare to choices and see if they will buy lemonade
            }
            
            //this loop will loop through the method in the customer class determining whether or not they buy lemonade
        }
    }
}
