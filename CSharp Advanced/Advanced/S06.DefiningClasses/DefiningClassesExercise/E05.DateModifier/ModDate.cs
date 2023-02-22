using System;

namespace DefiningClasses
{
    internal class ModDate
    {
        public static int GetTimeDifference(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan diff = startDate - endDate;

            return Math.Abs(diff.Days);
        }
    }
}
