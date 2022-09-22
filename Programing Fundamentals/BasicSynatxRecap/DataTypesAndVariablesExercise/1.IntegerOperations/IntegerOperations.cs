namespace _1.IntegerOperations
{
    internal class IntegerOperations
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());

            int result = firstInt + int.Parse(Console.ReadLine());

            result /= int.Parse(Console.ReadLine());

            result *= int.Parse(Console.ReadLine());

            Console.WriteLine(result);
        }
    }
}