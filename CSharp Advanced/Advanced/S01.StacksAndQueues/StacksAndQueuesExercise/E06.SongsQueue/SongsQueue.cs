using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.SongsQueue
{
    internal class SongsQueue
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));


            while (songs.Any())
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = String.Join(" ", cmdArgs.Skip(1));

                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}