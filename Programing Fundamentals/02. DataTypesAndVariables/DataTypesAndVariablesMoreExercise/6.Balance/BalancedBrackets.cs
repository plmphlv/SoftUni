using System;

namespace _6.Balance
{
    internal class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            string balanceChecker = string.Empty;
            bool isOpen = false;

            for (int i = 1; i <= numOfInputs; i++)
            {
                string symbol = Console.ReadLine();

                if (symbol == "(")
                {
                    balanceChecker += symbol;
                    isOpen = true;
                }
                else if (symbol == ")" && balanceChecker == "(")
                {
                    balanceChecker += symbol;
                    isOpen = false;
                }

                if (balanceChecker == "()" && isOpen == false)
                {
                    balanceChecker = string.Empty;
                }
            }

            bool IsBalanced = (balanceChecker==string.Empty && isOpen == false);


            string result = IsBalanced ? "BALANCED" : "UNBALANCED";

            Console.WriteLine(result);
        }
    }
}