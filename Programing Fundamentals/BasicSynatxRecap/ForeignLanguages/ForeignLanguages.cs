using System;

namespace MonthPrinter
{
    internal class MonthPrinter
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();

            switch (month)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}