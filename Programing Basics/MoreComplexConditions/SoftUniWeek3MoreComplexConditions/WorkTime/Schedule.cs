using System;

namespace WorkTime
{
    internal class Schedule
    {
        static void Main(string[] args)
        {
            int workTime = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                case "Tuesday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                case "Wednesday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                case "Thursday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                case "Friday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                case "Saturday":
                    if (workTime >= 10 && workTime <= 18)
                        Console.WriteLine("open");
                    else
                        Console.WriteLine("closed");
                    break;
                default:
                    Console.WriteLine("closed");
                    break;
            }
        }
    }
}
