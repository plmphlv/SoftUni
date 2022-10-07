using System;

namespace _3.Calculations
{
    internal class Calculations
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(numA, numB);
                    break;
                case "multiply":
                    Multiply(numA, numB);
                    break;
                case "subtract":
                    Subtract(numA, numB);
                    break;
                case "divide":
                    Divide(numA, numB);
                    break;
                default:
                    break;
            }
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}