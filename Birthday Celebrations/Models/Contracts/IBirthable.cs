using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Models.Contracts
{
    public interface IBirthable
    {
        DateTime Birthdate { get; }
    }
}