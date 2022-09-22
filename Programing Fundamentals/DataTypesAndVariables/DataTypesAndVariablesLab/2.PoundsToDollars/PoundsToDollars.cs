namespace _2.PoundsToDollars
{
    internal class PoundsToDollars
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}