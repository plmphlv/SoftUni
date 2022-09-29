using System;

namespace _5.PrintPartOfTheASCIITable
{
    internal class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}