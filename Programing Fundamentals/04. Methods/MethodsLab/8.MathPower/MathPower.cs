using System;

namespace _8.MathPower
{
    internal class MathPower
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int toThePower = int.Parse(Console.ReadLine());

            double result = MathToThePower(baseNumber, toThePower);

            Console.WriteLine(result);
        }

        static double MathToThePower(double baseNum, int powerNum)
        {
            double result = 1;

            for (int i = 1; i <= powerNum; i++)
            {
                result*=baseNum;
            }

            return result;
        }
    }
}