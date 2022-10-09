using System;

namespace _8.FactorialDivision
{
    internal class FactorialDivision
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            FactorialDivisionMethod(num1, num2);
        }

        static void FactorialDivisionMethod(int num1, int num2)
        {
            double facto1 = 1;

            while (num1 > 0)
            {
                facto1 *= num1;
                num1--;
            }


            double facto2 = 1;

            while (num2 > 0)
            {
                facto2 *= num2;
                num2--;
            }

            Console.WriteLine($"{facto1 / facto2:f2}");
        }
    }
}