using System;

namespace _9.GreaterOfTwoValues
{
    internal class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            switch (dataType)
            {
                case "int":

                    int num1 = int.Parse(input1);
                    int num2 = int.Parse(input2);

                    int maxInputInt = GetMax(num1, num2);
                    Console.WriteLine(maxInputInt);
                    break;

                case "char":

                    char symbol1 = char.Parse(input1);
                    char symbol2 = char.Parse(input2);

                    char maxInputChar = GetMax(symbol1, symbol2);
                    Console.WriteLine(maxInputChar);
                    break;

                case "string":

                    string maxInputString = GetMax(input1, input2);
                    Console.WriteLine(maxInputString);
                    break;

            }
        }

        static int GetMax(int input1, int input2)
        {
            int bigger = (input1 > input2) ? input1 : input2;

            return bigger;
        }

        static string GetMax(string input1, string input2)
        {
            int maxi = input1.CompareTo(input2);
            string maxString = (maxi > 0) ? input1 : input2;

            return maxString;
        }

        static char GetMax(char input1, char input2)
        {
            int charNum1 = (int)input1;
            int charNum2 = (int)input2;
            char charMax = (charNum1 > charNum2) ? input1 : input2;

            return charMax;
        }
    }
}