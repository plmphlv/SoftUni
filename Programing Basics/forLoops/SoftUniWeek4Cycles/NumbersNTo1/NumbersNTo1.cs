using System;

namespace NumbersNTo1
{
    internal class NumbersNTo1
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            for(int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
