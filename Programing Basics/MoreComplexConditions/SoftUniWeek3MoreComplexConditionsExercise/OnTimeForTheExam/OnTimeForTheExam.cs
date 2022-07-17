using System;

namespace OnTimeForTheExam
{
    internal class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examTimeHour = int.Parse(Console.ReadLine());
            int examTimeMinute = int.Parse(Console.ReadLine());
            int arivalHour = int.Parse(Console.ReadLine());
            int arivalMinute = int.Parse(Console.ReadLine());
            int delayM = 0;
            int delayH = 0;

            if (examTimeHour == 0)
                examTimeHour += 24;

            int timerExam = examTimeHour * 60 + examTimeMinute;
            int timerArival = arivalHour * 60 + arivalMinute;
            int diff = Math.Abs(timerExam - timerArival);//Difference in minutes. Math.Abs() returns the absolute value of a number, which is always the positive value number in the brackets.
            delayH = diff / 60;
            delayM = diff % 60;


            if (timerExam < timerArival) // Late
            {
                if (diff >= 60) // An hour late
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{delayH}:{delayM:d2} hours after the start");
                }
                else if (diff < 60)// Less than an hour late
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{delayM} minutes after the start");
                }
            }
            else if (diff >= 0 && diff <= 30) // On time
            {
                if (diff > 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    Console.WriteLine("On time");
                }
            }
            else //Early
            {
                if (diff >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{delayH}:{delayM:d2} hours before the start");
                }
                else if (diff < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{timerExam - timerArival:d2} minutes before the start");
                }

            }
        }
    }
}