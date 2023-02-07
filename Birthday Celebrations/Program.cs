using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BirthdayCelebrations
{
    using Models;
    using Models.Contracts;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] objectParams = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<IBirthable> birthables = new List<IBirthable>();

            while (objectParams[0] != "End")
            {
                string objectType = objectParams[0];
                string objectName = objectParams[1];

                int[] birthdate = objectParams.Last()
                    .Split('/', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (objectType == "Citizen")
                {
                    int citizenAge = int.Parse(objectParams[2]);

                    string id = objectParams[3];

                    birthables.Add(new Citizen(id, objectName, citizenAge, birthdate));
                }
                else if (objectType == "Pet")
                    birthables.Add(new Pet(objectName, birthdate));

                objectParams = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int year = int.Parse(Console.ReadLine());

            birthables =
                (from birthable in birthables
                 where birthable.Birthdate.Year == year
                 select birthable).ToList();

            birthables.ForEach(b => Console.WriteLine(b.Birthdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)));
        }
    }
}