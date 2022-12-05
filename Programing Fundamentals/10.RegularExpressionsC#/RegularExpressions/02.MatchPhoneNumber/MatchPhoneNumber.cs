using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[359]+( |-)2\1\d{3}\1\d{4}\b";
            string numbers = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(numbers);
            string[] matchedPhones = matchCollection.Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}