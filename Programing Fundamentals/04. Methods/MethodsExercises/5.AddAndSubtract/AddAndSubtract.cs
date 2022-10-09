using System;

namespace _5.AddAndSubtract
{
    internal class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int finalResult = SumTheFirstTwoInts(number1, number2);
            finalResult = SumbtractTheLastInts(finalResult, number3);
            Console.WriteLine(finalResult);

        }

        static int SumTheFirstTwoInts(int number1, int number2)
        {
            return number1 + number2;
        }

        static int SumbtractTheLastInts(int finalResult, int number3)
        {
            return finalResult - number3;
        }
    }
}