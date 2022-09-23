namespace _7.WaterOverflow
{
    internal class WaterOverflow
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            byte capacity = 0;

            for (int i = 1; i <= nLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (capacity + liters < 255)
                {
                    capacity += (byte)liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(capacity);
        }
    }
}