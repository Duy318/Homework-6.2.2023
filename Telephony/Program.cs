using System;
using Telephony.Contracts;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] websites = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Smartphone smartphone = new Smartphone();

            StationaryPhone stationaryPhone = new StationaryPhone();

            ICallCapable smartphoneCaller = smartphone;
            ICallCapable stationaryPhoneCaller = stationaryPhone;

            IBrowseCapable smartphoneBrowser = smartphone;

            foreach (string number in phoneNumbers)
            {
                if (number.Length == 10)
                    smartphoneCaller.Call(number);

                else
                    stationaryPhoneCaller.Call(number);
            }

            foreach (string URL in websites)
                smartphoneBrowser.Browse(URL);
        }
    }
}