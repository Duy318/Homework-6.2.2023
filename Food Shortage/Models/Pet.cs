using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    using Contracts;

    public class Pet : IBirthable
    {
        public Pet(string name, int[] birthdate)
        {
            Name = name;

            Birthdate = new DateTime(birthdate[2], birthdate[1], birthdate[0]);
        }

        public string Name { get; protected set; }

        public DateTime Birthdate { get; protected set; }
    }
}