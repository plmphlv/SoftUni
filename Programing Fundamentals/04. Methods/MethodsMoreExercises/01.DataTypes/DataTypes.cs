using System;

namespace _01.DataTypes
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int dataInt = int.Parse(Console.ReadLine());
                DataTupe(dataInt);
            }
            else if (dataType == "real")
            {
                double dataDouble = double.Parse(Console.ReadLine());
                DataTupe(dataDouble);
            }
            else if (dataType == "string")
            {
                string str = Console.ReadLine();
                DataTupe(str);
            }
        }

        static void DataTupe(string dataType)
        {
            Console.WriteLine($"${dataType}$");
        }
        static void DataTupe(int dataType)
        {
            Console.WriteLine(dataType * 2);
        }
        static void DataTupe(double dataType)
        {
            Console.WriteLine($"{dataType * 1.5:f2}");
        }
    }
}