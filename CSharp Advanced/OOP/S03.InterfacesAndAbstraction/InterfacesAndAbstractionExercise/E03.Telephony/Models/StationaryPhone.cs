using System.Text.RegularExpressions;
using System;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : ICall
    {
        private const string paternPhoneNumber = @"^[0-9]{7}$";
        private Regex phoneNumberCheck;

        private Match matchSuccess;

        public StationaryPhone()
        {
            phoneNumberCheck = new Regex(paternPhoneNumber);
        }

        public string CallSomeone(string number)
        {
            matchSuccess = phoneNumberCheck.Match(number);

            if (matchSuccess.Success)
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }


        }
    }
}
