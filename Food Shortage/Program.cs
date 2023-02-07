using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodShortage
{
    using Models;
    using Models.Contracts;

    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());


            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 1; i <= peopleCount; i++)
            {
                string[] iBuyerParams = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = iBuyerParams[0];

                int age = int.Parse(iBuyerParams[1]);

                if (iBuyerParams.Length == 4)
                {
                    string id = iBuyerParams[2];

                    int[] birthdate = iBuyerParams[3]
                        .Split('/', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (!buyers.ContainsKey(name))
                        buyers.Add(name, new Citizen(id, name, age, birthdate));
                }

                else if (iBuyerParams.Length == 3)
                {
                    string group = iBuyerParams[2];

                    if (!buyers.ContainsKey(name))
                        buyers.Add(name, new Rebel(name, age, group));
                }
            }

            string token = Console.ReadLine();

            int totalFoodPurchased = 0;

            while (token != "End")
            {
                if (buyers.ContainsKey(token))
                {
                    buyers[token].BuyFood();

                    totalFoodPurchased += buyers[token].BuyFood();
                }

                token = Console.ReadLine();
            }

            Console.WriteLine(totalFoodPurchased);
        }
    }
}