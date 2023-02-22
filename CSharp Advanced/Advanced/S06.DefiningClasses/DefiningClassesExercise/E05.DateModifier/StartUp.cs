using System;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            Console.WriteLine(ModDate.GetTimeDifference(start, end));
        }
    }
}