﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //member variables (Has A)
        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIceCubes;
        public double pricePerCup;
        public double priceOfLemonade;
        Random rng;
        public double priceForCustomer;

        //constructor (Spawner)
        public Recipe()
        {
            Random random = new Random();
        }
        //member methods (Can Do)
        //make a method that will allow the player to set a recipe 
        public void SetRecipe()
        {
            Console.WriteLine("How many lemons do you want per pitcher?");
            amountOfLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar do you want per pitcher?");
            amountOfSugar = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ice cubes do you want per cup?");
            amountOfIceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("How much do you want each cup of Lemonade to cost?");
            priceOfLemonade = double.Parse(Console.ReadLine());
        }

        public void RandomizeCustomerPriceCondition()
        {
            priceForCustomer = rng.Next(1, 5);
        }
    }
}
