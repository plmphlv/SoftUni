using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int theInt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = theInt * i;
                Console.WriteLine($"{theInt} X {i} = {product}");
            }
        }
    }
}