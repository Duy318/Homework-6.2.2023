using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    using Contracts;

    public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string id, string name, int age, int[] birthdate)
        {
            ID = id;
            Name = name;
            Age = age;

            Birthdate = new DateTime(birthdate[2], birthdate[1], birthdate[0]);
        }

        public string ID { get; protected set; }

        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public DateTime Birthdate { get; protected set; }
    }
}