using System;

namespace DepositCalculator
{
    class DepositCalc
    {
        static void Main(string[] args)
        {
            double depSum = double.Parse(Console.ReadLine());
            int depTime = int.Parse(Console.ReadLine());
            double anItrst = double.Parse(Console.ReadLine())/100;

            double endSum = depSum +(depTime * ((depSum * anItrst) / 12));
            Console.WriteLine(endSum);
        }
    }
}
