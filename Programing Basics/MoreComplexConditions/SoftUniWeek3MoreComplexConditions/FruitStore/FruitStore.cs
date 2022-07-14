using System;

namespace FruitStore
{
    internal class FruitStore
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double kilos =double.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case"banana":
                    if(dayOfWeek == "Monday"||dayOfWeek== "Tuesday" || dayOfWeek== "Wednesday" || dayOfWeek== "Thursday" || dayOfWeek=="Friday") price = 2.50;
                    else price = 2.70;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "apple":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 1.20;
                    else price = 1.75;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "orange":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 0.85;
                    else price = 0.90;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "grapefruit":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 1.45;
                    else price = 1.60;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "kiwi":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 2.70;
                    else price = 3.00;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "pineapple":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 5.50;
                    else price = 2.60;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                case "grapes":
                    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek=="Friday") price = 2.50;
                    else price = 2.70;

                    price = price * kilos;
                    Console.WriteLine($"{price:f2}");
                    break;
                    default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
