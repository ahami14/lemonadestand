using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member vairables (Has A)
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<Sugar> cupsOfSugar;

        //constructor (Spawner)
        public Inventory()
        {
            cups = new List<Cup>();
            lemons = new List<Lemon>();
            cupsOfSugar = new List<Sugar>();
            iceCubes = new List<IceCube>();
        }

        //member methods (Can Do)
    }
}
