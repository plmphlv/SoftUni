using System;

namespace SkiTrip
{
    internal class SkiTrip
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string gradeS = Console.ReadLine();
            bool grade = gradeS == "positive";
            double stayPrice = 0;

            switch (roomType)
            {
                case "room for one person":
                    stayPrice = nights * 18;

                    if (grade)
                    {
                        stayPrice = stayPrice + (stayPrice * 0.25);
                    }
                    else
                    {
                        stayPrice = stayPrice - (stayPrice * 0.1);
                    }
                    Console.WriteLine($"{stayPrice:f2}");
                    break;
                case "apartment":
                    stayPrice = nights * 25;

                    if (nights < 10)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.3);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.35);
                    }
                    else if (nights > 15)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.5);
                    }

                    if (grade)
                    {
                        stayPrice = stayPrice + (stayPrice * 0.25);
                    }
                    else
                    {
                        stayPrice = stayPrice - (stayPrice * 0.1);
                    }
                    Console.WriteLine($"{stayPrice:f2}");
                    break;

                case "president apartment":
                    stayPrice = nights * 35;

                    if (nights < 10)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.1);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.15);
                    }
                    else if (nights > 15)
                    {
                        stayPrice = stayPrice - (stayPrice * 0.2);
                    }

                    if (grade)
                    {
                        stayPrice = stayPrice + (stayPrice * 0.25);
                    }
                    else
                    {
                        stayPrice = stayPrice - (stayPrice * 0.1);
                    }
                    Console.WriteLine($"{stayPrice:f2}");
                    break;

                default:
                    Console.WriteLine("Judge is retarded!");
                    break;

            }
        }
    }
}
