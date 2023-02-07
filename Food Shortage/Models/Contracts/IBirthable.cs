using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models.Contracts
{
    public interface IBirthable
    {
        DateTime Birthdate { get; }
    }
}