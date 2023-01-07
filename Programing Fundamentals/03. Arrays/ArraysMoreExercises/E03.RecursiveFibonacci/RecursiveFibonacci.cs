using System;

namespace E03.RecursiveFibonacci
{
    internal class RecursiveFibonacci
    {
        static void Main(string[] args)
        {

            int seqEnd = int.Parse(Console.ReadLine());

            ulong[] fibonacciSeq = new ulong[seqEnd];

            if (seqEnd < 2)
            {
                Console.WriteLine(1);
            }
            else
            {

                fibonacciSeq[0] = 1;
                fibonacciSeq[1] = 1;

                for (int i = 1; i <= seqEnd; i++)
                {
                    Fibonacci((i - 1), ref fibonacciSeq);
                }

                Console.WriteLine(fibonacciSeq[fibonacciSeq.Length - 1]);

            }

        }

        static ulong Fibonacci(int n, ref ulong[] array)
        {

            if (array[n] != 0)
            {
                return array[n];
            }

            ulong value = Fibonacci((n - 1), ref array) + Fibonacci((n - 2), ref array);

            array[n] = value;

            return value;

        }
    }
}