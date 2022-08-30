using System;

namespace Dishwasher
{
    internal class Dishwasher
    {
        static void Main(string[] args)
        {
            int bootle = int.Parse(Console.ReadLine());
            int detergent = bootle * 750;
            int dishes = 0; //чинии
            int pans = 0; //тенджери
            int count = 1;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int washerLoad = int.Parse(command);

                if (count % 3 == 0)
                {
                    detergent -= washerLoad * 15;
                    if (detergent < 0)
                    {
                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                        return;
                    }
                    else
                    {
                        pans += washerLoad;
                    }
                }
                else
                {
                    detergent -= washerLoad * 5;

                    if (detergent < 0)
                    {
                        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                        return;
                    }
                    else
                    {
                        dishes += washerLoad;
                    }
                }
                count++;
            }
            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{dishes} dishes and {pans} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergent} ml.");
        }
    }
}