using System;
using System.Linq;

namespace _07.AppendArrays
{
    internal class AppendArrays
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').Reverse().ToArray();
            string temp = string.Join(" ", input);
            string[] results = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", results));
        }
    }
}