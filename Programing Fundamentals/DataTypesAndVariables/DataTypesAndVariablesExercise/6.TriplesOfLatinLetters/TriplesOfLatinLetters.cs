namespace _6.TriplesOfLatinLetters
{
    internal class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + n; i++)
            {
                char firstChar = (char)i;
                for (int j = 97; j < 97 + n; j++)
                {
                    char secondChar = (char)j;
                    for (int k = 97; k < 97 + n; k++)
                    {
                        char thirdChar = (char)k;
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}