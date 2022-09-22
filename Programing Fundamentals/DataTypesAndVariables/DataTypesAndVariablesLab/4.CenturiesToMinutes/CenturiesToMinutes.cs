namespace _4.CenturiesToMinutes
{
    internal class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            int ceturies = int.Parse(Console.ReadLine());

            int years = ceturies * 100;
            int days = (int)((double)years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong)hours * 60u;

            Console.WriteLine($"{ceturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}