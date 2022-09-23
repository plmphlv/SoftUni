namespace _3.Elevator
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevetorLimit = int.Parse(Console.ReadLine());

            int cources = 0;

            // The easy way
            //while (people > 0)
            //{   
            //    people -= elevetorLimit;
            //    cources++;
            //}

            // The hard way
            // cources = (int)Math.Ceiling((double)people / elevetorLimit);

            cources = people / elevetorLimit;

            if (people % elevetorLimit > 0)
            {
                cources++;
            }

            Console.WriteLine(cources);
        }
    }
}