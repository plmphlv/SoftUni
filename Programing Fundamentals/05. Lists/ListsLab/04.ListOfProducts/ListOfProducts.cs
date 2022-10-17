using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    internal class ListOfProducts
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> veggies = new List<string>();

            for (int i = 0; i < n; i++)
            {
                veggies.Add(Console.ReadLine());
            }

            veggies.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{veggies[i]}");
            }
        }
    }
}