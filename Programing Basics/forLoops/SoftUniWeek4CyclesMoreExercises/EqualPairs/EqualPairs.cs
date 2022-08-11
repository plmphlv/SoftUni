using System;

namespace EqualPairs
{
    internal class EqualPairs
    {
        static void Main(string[] args)
        {
            int pairs=int.Parse(Console.ReadLine());

            int maxDiff = 0;
            int store = 0;

            for (int i = 1; i <= pairs; i++)
            {
                int num1=int.Parse(Console.ReadLine());
                int num2=int.Parse(Console.ReadLine());
                
                int sum=num1 + num2;
                
                if(sum>=maxDiff)
                {
                    
                }
            }
        }
    }
}
