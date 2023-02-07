using FoodShortage.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public string Group { get; protected set; }

        public int Food { get; protected set; }

        public int BuyFood()
        {
            const int REBEL_FOOD_QUANTITY = 5;

            Food += REBEL_FOOD_QUANTITY;

            return REBEL_FOOD_QUANTITY;
        }
    }
}