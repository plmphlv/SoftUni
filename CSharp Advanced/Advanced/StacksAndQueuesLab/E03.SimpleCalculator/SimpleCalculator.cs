using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.SimpleCalculator
{
    internal class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            chars = chars.Reverse().ToArray();

            Stack<string> calculator = new Stack<string>();

            foreach (string c in chars)
            {
                calculator.Push(c);
            }

            int operator1 = 0;

            while (calculator.Count > 1)
            {
                string poppedMember = calculator.Pop();

                if (poppedMember == "+" || poppedMember == "-")
                {
                    int operator2 = int.Parse(calculator.Pop());
                    int sum = 0;

                    if (poppedMember == "+")
                    {
                        sum = operator1 + operator2;

                    }
                    else
                    {
                        sum = operator1 - operator2;
                    }

                    calculator.Push(sum.ToString());
                }
                else
                {
                    operator1 = int.Parse(poppedMember);
                }
            }

            Console.WriteLine(calculator.Pop());
        }
    }
}