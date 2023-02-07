using System;
using System.Linq;
using System.Collections.Generic;

namespace BorderControl
{
    using Models;
    using Contracts;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] iIdentifiableParams = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (iIdentifiableParams[0] != "End")
            {
                string id;

                if (iIdentifiableParams.Length == 2)
                {
                    string model = iIdentifiableParams[0];

                    id = iIdentifiableParams[1];

                    identifiables.Add(new Robot(id, model));
                }
                else if (iIdentifiableParams.Length == 3)
                {
                    string name = iIdentifiableParams[0];

                    int age = int.Parse(iIdentifiableParams[1]);

                    id = iIdentifiableParams[2];

                    identifiables.Add(new Citizen(id, name, age));
                }

                iIdentifiableParams = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string fakeIDLastNumber = Console.ReadLine();

            identifiables = identifiables
                .Where(i => i.ID.EndsWith(fakeIDLastNumber))
                .ToList();

            identifiables.ForEach(i => Console.WriteLine(i.ID));
        }
    }
}