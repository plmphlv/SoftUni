﻿namespace E05.GenericCountMethodStrings
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();

                box.Add(item);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}