using P01.Stream_Progress.Models;
using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            File myFile = new("Skyrim.esm", 420, 10);
            Music myMusic = new("Chalga", "Za 6efa na relefa", 10, 23);

            StreamProgressInfo newStreamInfo1 = new(myFile);
            StreamProgressInfo newStreamInfo2 = new(myMusic);

            Console.WriteLine(newStreamInfo1.CalculateCurrentPercent());
            Console.WriteLine(newStreamInfo2.CalculateCurrentPercent());
        }
    }
}
