using System;

namespace MultiplicationTable
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int theInt = int.Parse(Console.ReadLine());
            int theTimes = int.Parse(Console.ReadLine());

            do
            {
                int product = theInt * theTimes;
                Console.WriteLine($"{theInt} X {theTimes} = {product}");
                theTimes++;
            } while (theTimes <= 10);
        }
    }
}