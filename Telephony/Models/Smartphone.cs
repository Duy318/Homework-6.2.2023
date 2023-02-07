using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Telephony.Contracts;

namespace Telephony.Models
{
    public class Smartphone : ICallCapable, IBrowseCapable
    {
        public void Call(string phoneNumber)
        {
            if (phoneNumber.Any(d => !char.IsDigit(d)))
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            Console.WriteLine($"Calling... {phoneNumber}");
        }

        public void Browse(string websiteURL)
        {
            if (websiteURL.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Invalid URL!");

                return;
            }

            Console.WriteLine($"Browsing: {websiteURL}!");
        }
    }
}