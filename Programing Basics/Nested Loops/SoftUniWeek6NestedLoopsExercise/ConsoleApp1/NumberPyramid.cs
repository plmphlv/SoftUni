using System;

namespace NumberPyramid
{
    internal class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curr = 1;
            bool breaker=false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {

                    if (curr > n)
                    {
                        breaker = true;
                        break;
                    }
                    Console.Write(curr + " ");
                    curr++;
                }
                if (breaker)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
