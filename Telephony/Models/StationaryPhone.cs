using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class StationaryPhone : ICallCapable
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(d => !char.IsDigit(d)))
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}