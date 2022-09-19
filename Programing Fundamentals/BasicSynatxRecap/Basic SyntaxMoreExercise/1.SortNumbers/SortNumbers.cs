using System;

namespace _1.SortNumbers
{
    internal class SortNumbers
    {
        static void Main(string[] args)
        {
            int num1L = int.Parse(Console.ReadLine());
            int num2M = int.Parse(Console.ReadLine());
            int num3S = int.Parse(Console.ReadLine());

            int buffer = 0;

            bool needsSorting = true;

            while (needsSorting)
            {
                if (num1L < num2M)
                {
                    buffer = num1L;
                    num1L = num2M;
                    num2M = buffer;
                }

                if (num1L < num3S)
                {
                    buffer = num3S;
                    num3S = num1L;
                    num1L = buffer;
                }

                if (num2M < num3S)
                {
                    buffer = num2M;
                    num2M = num3S;
                    num3S = buffer;
                }

                if (((num1L > num2M) && (num2M >= num3S) && (num1L > num3S)) || (num1L > 0 && num2M == 0 && num3S == 0))
                {
                    needsSorting = false;
                }
            }

            Console.WriteLine(num1L);
            Console.WriteLine(num2M);
            Console.WriteLine(num3S);
        }
    }
}