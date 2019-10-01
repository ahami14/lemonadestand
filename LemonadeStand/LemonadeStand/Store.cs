using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member vairables (Has A)
        Player player;
        int cupAmount;
        int lemonAmount;
        int sugarAmount;
        int iceAmount;

        //constructor (Spawner)
        public Store()
        {
            cupAmount = 0;
            lemonAmount = 0;
            sugarAmount = 0;
            iceAmount = 0;
        }

        //member methods (Can Do)// for now let's get these set up in here, then we can figure out how to put them in game class
        public string ItemsInStock()
        {
            Console.WriteLine("Cups: 25 for o.85, 50 for 1.73, 100 for 2.96");
            Console.WriteLine("Lemons: 10 for 0.78, 30 for 2.24, 75 for 4.47");
            Console.WriteLine("Cups of Sugar: 8 for 0.69, 20 for 1.52, 48 for 3.30");
            Console.WriteLine("Ice Cubes: 100 for 0.76, 250 for 2.16, 500 for 3.54");
            return Console.ReadLine();
        }
        
        public void ItemChoice()//something like this! Again, we will get this set up in here then move it to game class! OR we could reference it!
        {
            Console.WriteLine("How many cups are you buying?");
            cupAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many lemons are you buying?");
            lemonAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar are you buying?");
            sugarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes are you buying?");
            iceAmount = int.Parse(Console.ReadLine());
        }
        
    }
}
