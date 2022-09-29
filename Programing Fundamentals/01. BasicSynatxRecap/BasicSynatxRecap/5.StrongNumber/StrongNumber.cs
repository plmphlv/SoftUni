using System;

namespace _5.StrongNumber
{
    internal class StrongNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            
            int factorial =0;
            
            while (numCopy > 0)
            {
                int lastDigit=numCopy%10;
                numCopy/=10;

                int lastDigitFactorial = 1;
                for (int i = lastDigit; i >1 ; i--)
                {
                    lastDigitFactorial *= i;
                }
                
                factorial += lastDigitFactorial;
            }

            if (factorial == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}