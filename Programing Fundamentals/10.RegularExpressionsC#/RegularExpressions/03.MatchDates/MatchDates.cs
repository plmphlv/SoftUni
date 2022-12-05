using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class MatchDates
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string dayPattern = @"\b(?<day>\d{2})(?<separators>[\/|\-|\.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            Regex regex = new Regex(dayPattern);

            MatchCollection dates = regex.Matches(input);

            foreach (Match date in dates)
            {
                 var day = date.Groups["day"].Value;
                 var month = date.Groups["month"].Value;
                 var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}