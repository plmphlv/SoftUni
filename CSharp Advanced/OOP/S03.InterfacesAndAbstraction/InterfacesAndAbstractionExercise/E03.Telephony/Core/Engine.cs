using System;
using Telephony.Core.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] urlAdresses = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            ICall phone;
            foreach (string phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Length > 7 && phoneNumber.Length < 11)
                {
                    phone = new Smartphone();
                    phone.CallSomeone(phoneNumber);
                }
                else
                {
                    phone = new StationaryPhone();
                    phone.CallSomeone(phoneNumber);
                }
            }

            IBrowse smartphone = new Smartphone();
            foreach (string urlAdress in urlAdresses)
            {
                smartphone.BrowseTheInternet(urlAdress);
            }
        }
    }
}
