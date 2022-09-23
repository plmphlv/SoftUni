namespace _8.BeerKegs
{
    internal class BeerKegs
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string biggestKegName = string.Empty;
            double biggestKegVolume = 0;

            for (int i = 0; i < lines; i++)
            {
                string kegName = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegName = kegName;
                    biggestKegVolume = kegVolume;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}