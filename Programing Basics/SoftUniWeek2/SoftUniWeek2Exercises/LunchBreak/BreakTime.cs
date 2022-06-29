using System;

namespace LunchBreak
{
    internal class BreakTime
    {
        static void Main(string[] args)
        {
            string tvShowName = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125;
            double restTime = breakTime * 0.25;
            double timeLeft = breakTime - (lunchTime + restTime);

            if (timeLeft >= episodeLenght)
            {
                timeLeft =Math.Ceiling(breakTime - (lunchTime + restTime+episodeLenght));
                Console.WriteLine($"You have enough time to watch {tvShowName} and left with {timeLeft} minutes free time.");
            }
            else
            {
                timeLeft = Math.Ceiling( episodeLenght - (breakTime - (lunchTime + restTime)));
                Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {timeLeft} more minutes.");
            }
        }
    }
}
