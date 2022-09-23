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
                    Console.WriteLine($"{integerNum} is integer type");
                }
                else if(double.TryParse(input,out floatingPiontNum))
                {
                    Console.WriteLine($"{floatingPiontNum} is floating point type");
                }
                else if (bool.TryParse(input, out booleanType))
                {
                    Console.WriteLine($"{booleanType} is boolean type");
                }
                else if (char.TryParse(input, out characterType))
                {
                    Console.WriteLine($"{characterType} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}