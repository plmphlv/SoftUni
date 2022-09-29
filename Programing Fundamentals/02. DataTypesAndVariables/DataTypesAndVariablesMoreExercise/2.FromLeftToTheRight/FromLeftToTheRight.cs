using System;

namespace _2.FromLeftToTheRight
{
    internal class FromLeftToTheRight
    {
        static void Main(string[] args)
        {

            int reads = int.Parse(Console.ReadLine());

            for (int i = 1; i <= reads; i++)
            {
                string leftRight = Console.ReadLine();
                string[] split = leftRight.Split(' ');


                long left = long.Parse(split[0]);
                long right = long.Parse(split[1]);

                long biggest;

                if (left > right)
                {
                    biggest = left;
                }
                else
                {
                    biggest = right;
                }

                long digitSum = 0;

                while (biggest != 0)
                {
                    digitSum += biggest % 10;
                    biggest /= 10;
                }

                Console.WriteLine(Math.Abs(digitSum));
            }
        }
    }
}