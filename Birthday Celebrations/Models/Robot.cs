using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models
{
    using Contracts;

    public class Robot : IIdentifiable
    {
        public Robot(string id, string model)
        {
            ID = id;
            Model = model;
        }

        public string ID { get; protected set; }

        public string Model { get; protected set; }
    }
}