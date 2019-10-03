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
            player = new Player();

        }

        //member methods (Can Do)

        public void BuyCups()
        {
            Console.WriteLine("How many cups are you buying?");
            cupAmount = int.Parse(Console.ReadLine());

            if (player.wallet.Money > 0.85)
            {
                if (cupAmount == 25)
                {
                    player.wallet.Money -= 0.85;
                }
                else if (cupAmount == 50)
                {
                    player.wallet.Money -= 1.73;
                }
                else
                {
                    player.wallet.Money -= 2.96;
                }



                //do an if statement checking money in account, if it has more than the highest amount, then buy the item, otherwise don't
                for (int i = 0; i < cupAmount; i++)
                {
                    Cup cup = new Cup();
                    player.inventory.cups.Add(cup);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the cups!");
            }
        }


        public void BuyLemon()
        {
            Console.WriteLine("How many lemons are you buying?");
            amountOfLemons = int.Parse(Console.ReadLine());

            if (player.wallet.Money > 0.78)
            {
                if (amountOfLemons == 10)
                {
                    player.wallet.Money -= 0.78;
                }
                else if (amountOfLemons == 30)
                {
                    player.wallet.Money -= 2.24;
                }
                else
                {
                    player.wallet.Money -= 4.47;
                }



                for (int i = 0; i < amountOfLemons; i++)
                {
                    Lemon lemon = new Lemon();
                    player.inventory.lemons.Add(lemon);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("How many cups of sugar are you buying?");
            amountOfSugar = int.Parse(Console.ReadLine());

            if (player.wallet.Money > 0.69)
            {
                if (amountOfSugar == 8)
                {
                    player.wallet.Money -= 0.69;
                }
                else if (amountOfSugar == 20)
                {
                    player.wallet.Money -= 1.52;
                }
                else
                {
                    player.wallet.Money -= 3.30;
                }


                for (int i = 0; i < amountOfSugar; i++)
                {
                    Sugar sugar = new Sugar();
                    player.inventory.cupsOfSugar.Add(sugar);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }
        }



        public void BuyIce() 
        { 
            Console.WriteLine("How many ice cubes are you buying?");
            amountOfIceCubes = int.Parse(Console.ReadLine());

            if (player.wallet.Money > 0.74)
            {
                if (amountOfIceCubes == 100)
                {
                    player.wallet.Money -= 0.74;
                }
                else if (amountOfIceCubes == 250)
                {
                    player.wallet.Money -= 2.16;
                }
                else
                {
                    player.wallet.Money -= 3.54;
                }



                for (int i = 0; i < amountOfIceCubes; i++)
                {
                    IceCube iceCube = new IceCube();
                    player.inventory.iceCubes.Add(iceCube);
                }
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy the lemons!");
            }

        }

    }
}
