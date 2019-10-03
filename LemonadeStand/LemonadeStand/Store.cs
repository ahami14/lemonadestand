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
        int amountOfLemons;
        int amountOfSugar;
        int amountOfIceCubes;

        //constructor (Spawner)
        public Store()
        {
            cupAmount = 0;
            amountOfLemons = 0;
            amountOfSugar = 0;
            amountOfIceCubes = 0;
        }

        //member methods (Can Do)
        public void ItemsInStock()//move this to userinterface
        {
            Console.WriteLine("Cups: 25 for 0.85, 50 for 1.73, 100 for 2.96");
            Console.WriteLine("Lemons: 10 for 0.78, 30 for 2.24, 75 for 4.47");
            Console.WriteLine("Cups of Sugar: 8 for 0.69, 20 for 1.52, 48 for 3.30");
            Console.WriteLine("Ice Cubes: 100 for 0.76, 250 for 2.16, 500 for 3.54");
        }

        public void BuyCups()
        {
            Console.WriteLine("How many cups are you buying?");
            cupAmount = int.Parse(Console.ReadLine());

            if (cupAmount == 25)
            {
                player.wallet.Money--;
            }
            else if (cupAmount == 50)
            {
                player.wallet.Money--;
            }
            else
            {
                player.wallet.Money--;
            }


            if (player.wallet.Money > 2.96)
            {
                //buy the cups
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the cups!");
            }

            //do an if statement checking money in account, if it has more than the highest amount, then buy the item, otherwise don't
            for (int i = 0; i < cupAmount; i++)
            {
                Cup cup = new Cup();
                player.inventory.cups.Add(cup);
            }
        }


        public void BuyLemon()
        {
            Console.WriteLine("How many lemons are you buying?");
            amountOfLemons = int.Parse(Console.ReadLine());

            if (amountOfLemons == 10)
            {
                player.wallet.Money--;
            }
            else if (amountOfLemons == 30)
            {
                player.wallet.Money--;
            }
            else
            {
                player.wallet.Money--;
            }


            if (player.wallet.Money > 4.47)
            {
                //buy the lemons
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }


            for (int i = 0; i < amountOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.lemons.Add(lemon);
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("How many cups of sugar are you buying?");
            amountOfSugar = int.Parse(Console.ReadLine());

            if (amountOfSugar == 8)
            {
                player.wallet.Money--;
            }
            else if (amountOfSugar == 20)
            {
                player.wallet.Money--;
            }
            else
            {
                player.wallet.Money--;
            }

            if (player.wallet.Money > 3.30)
            {
                //buy the sugar
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }


            for (int i = 0; i < amountOfSugar; i++)
            {
                Sugar sugar = new Sugar();
                player.inventory.cupsOfSugar.Add(sugar);
            }
        }



        public void BuyIce() 
        { 
            Console.WriteLine("How many ice cubes are you buying?");
            amountOfIceCubes = int.Parse(Console.ReadLine());

            if (amountOfIceCubes == 8)
            {
                player.wallet.Money--;
            }
            else if (amountOfIceCubes == 20)
            {
                player.wallet.Money--;
            }
            else
            {
                player.wallet.Money--;
            }

            if (player.wallet.Money > 3.54)
            {
                //buy the Ice
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }


            for (int i = 0; i < amountOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                player.inventory.iceCubes.Add(iceCube);
            }

        }

    }
}
