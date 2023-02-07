using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models.Contracts
{
    public interface IIdentifiable
    {
        string ID { get; }
    }
}