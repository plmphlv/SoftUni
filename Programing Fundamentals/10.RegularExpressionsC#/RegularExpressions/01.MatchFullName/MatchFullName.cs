using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class MatchFullName
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(names);

            foreach (Match match in matchCollection)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}