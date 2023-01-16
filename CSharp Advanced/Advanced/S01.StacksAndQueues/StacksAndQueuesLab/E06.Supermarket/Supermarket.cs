using System;

using System.Collections.Generic;

namespace E06.Supermarket
{
    internal class Supermarket
    {
        static void Main(string[] args)
        {
            Queue<string> custommers = new Queue<string>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (custommers.Count != 0)
                    {
                        Console.WriteLine(custommers.Dequeue());
                    }
                }
                else
                {
                    custommers.Enqueue(command);
                }
            }

            Console.WriteLine($"{custommers.Count} people remaining.");
        }
    }
}