using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    using Contracts;

    public class Citizen : IIdentifiable
    {
        public Citizen(string id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public string ID { get; protected set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}