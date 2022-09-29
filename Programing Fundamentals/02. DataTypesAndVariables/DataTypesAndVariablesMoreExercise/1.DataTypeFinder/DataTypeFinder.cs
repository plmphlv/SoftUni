using System;

namespace _1.DataTypeFinder
{
    internal class DataTypeFinder
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine())!="END")
            {
                int integerNum;
                double floatingPiontNum;
                char characterType;
                bool booleanType;

                if (int.TryParse(input, out integerNum))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if(double.TryParse(input,out floatingPiontNum))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out characterType))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out booleanType))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}