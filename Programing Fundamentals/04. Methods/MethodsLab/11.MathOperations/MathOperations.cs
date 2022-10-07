using System;

namespace _11.MathOperations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string operatorType = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, operatorType, num2);
            Console.WriteLine(result);
        }

        static double Calculate(double number1, string operatorType, double number2)
        {
            double result = 0;
            switch (operatorType)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result= number1 - number2;
                    break;
                case "*":
                    result= number1 * number2;
                    break;
                case "/":
                    result= number1 / number2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}