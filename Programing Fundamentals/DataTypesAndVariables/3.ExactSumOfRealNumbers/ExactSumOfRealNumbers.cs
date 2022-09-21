using System;

namespace _3.ExactSumOfRealNumbers
{
    internal class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int numOfImputs = int.Parse(Console.ReadLine());
            decimal exactSum = 0;

            for (int i = 1; i <= numOfImputs; i++)
            {
                decimal imput = decimal.Parse(Console.ReadLine());
                exactSum += imput;
            }

            Console.WriteLine(exactSum);
        }
    }
}