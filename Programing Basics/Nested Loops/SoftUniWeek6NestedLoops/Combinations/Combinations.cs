using System;

namespace Combinations
{
    internal class Combinations
    {
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int posibleSolutionsCount = 0;


            for (int x1 = 0; x1 <= goal; x1++)
            {
                for (int x2 = 0; x2 <= goal; x2++)
                {
                    for (int x3 = 0; x3 <= goal; x3++)
                    {
                        int n = x1 + x2 + x3;
                        if (n == goal)
                            posibleSolutionsCount++;
                    }
                }
            }
            Console.WriteLine(posibleSolutionsCount);
        }
    }
}