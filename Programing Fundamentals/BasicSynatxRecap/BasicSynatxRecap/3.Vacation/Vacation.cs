using System;

namespace _3.Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;
            switch (dayOfWeek)
            {
                case "Friday":
                    if(group == "Students")
                    {
                        pricePerPerson = 8.45;
                    }
                    else if(group == "Business")
                    {
                        pricePerPerson = 10.90;
                    }
                    else if (group == "Regular")
                    {
                        pricePerPerson = 15;
                    }
                    break;
                case "Saturday":
                    if (group == "Students")
                    {
                        pricePerPerson = 9.80;
                    }
                    else if (group == "Business")
                    {
                        pricePerPerson = 15.60;
                    }
                    else if (group == "Regular")
                    {
                        pricePerPerson = 20;
                    }
                    break;
                case "Sunday":
                    if (group == "Students")
                    {
                        pricePerPerson = 10.46;
                    }
                    else if (group == "Business")
                    {
                        pricePerPerson = 16;
                    }
                    else if (group == "Regular")
                    {
                        pricePerPerson = 22.50;
                    }
                    break;
                    default:
                    break;
            }

            double price = pricePerPerson * count;

            if (group == "Students" && count >= 30)
            {
                price = price * 0.85;
            }
            else if (group == "Business" && count >= 100)
            {
                price -= pricePerPerson * 10;
            }
            else if (group == "Regular" && count >= 10 && count <= 20)
            {
                price = price * 0.95;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
