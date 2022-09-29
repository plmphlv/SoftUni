using System;

namespace _4.SumOfChars
{
    internal class SumOfChars
    {
        static void Main(string[] args)
        {
            int numberOfReadings = int.Parse(Console.ReadLine());

            int charSum=0;

            for (int i = 0; i < numberOfReadings; i++)
            {
                charSum += Convert.ToInt32(char.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
