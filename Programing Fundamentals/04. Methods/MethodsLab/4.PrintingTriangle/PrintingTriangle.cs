using System;

namespace _4.PrintingTriangle
{
    internal class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int triangle = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangle; i++)
            {
                PtrintTriangleTop(1, i);
            }

            for (int i = triangle - 1; i >= 1; i--)
            {
                PtrintTriangleBotom(1, i);
            }

        }

        static void PtrintTriangleTop(int topStart, int topEnd)
        {
            for (int i = topStart; i <= topEnd; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PtrintTriangleBotom(int botomStart, int botomEnd)
        {
            for (int i = botomStart; i <= botomEnd; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}