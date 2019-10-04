using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Wallet
    {
        //member variable (Has A)
        private double money; //make a money method public so we can subtract from the wallet since this one is private

        //constructor (Spawner)
        public Wallet()
        {
            money = 20;
        }

        //member method (Can Do)
        public double Money
        {
            get => money;
            set => money = value;
        }
    }
}
