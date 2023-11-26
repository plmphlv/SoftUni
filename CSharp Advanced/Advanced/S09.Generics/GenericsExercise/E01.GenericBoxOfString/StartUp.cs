using System;

namespace BoxOfString
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            Box<string> box = new();

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string item = Console.ReadLine();

                box.Add(item);
            }

            Console.WriteLine(box.ToString());
        }
    }
}