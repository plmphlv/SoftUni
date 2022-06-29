using System;

namespace SecondsSum
{
    internal class Seconds
    {
        static void Main(string[] args)
        {
            int timeOne = int.Parse(Console.ReadLine());
            int timeTwo = int.Parse(Console.ReadLine());
            int timeThree = int.Parse(Console.ReadLine());
            
            int totalSeconds = timeOne + timeTwo + timeThree;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            //Console.WriteLine($"{minutes}:{seconds:d2}");
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
