using System;
using System.Text.RegularExpressions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICall, IBrowse
    {
        private const string paternUrl = @"^http://[a-z]+.[a-z]+$";
        private Regex urlCheck;

        private const string paternPhoneNumber = @"^[0-9]{10}$";
        private Regex phoneNumberCheck;

        private Match matchSuccess;

        public Smartphone()
        {
            urlCheck = new Regex(paternUrl);
            phoneNumberCheck = new Regex(paternPhoneNumber);
        }

        public void BrowseTheInternet(string websiteUrl)
        {

            matchSuccess = urlCheck.Match(websiteUrl);

            if (matchSuccess.Success)
            {
                Console.WriteLine($"Browsing: {websiteUrl}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void CallSomeone(string number)
        {
            matchSuccess = phoneNumberCheck.Match(number);

            if (matchSuccess.Success)
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
