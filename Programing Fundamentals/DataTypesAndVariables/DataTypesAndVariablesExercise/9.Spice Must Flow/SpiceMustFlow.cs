using System;

namespace _9.Spice_Must_Flow
{
    internal class SpiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int spice = 0;
            bool profitable = true;

            if (startingYield >=100 )
            {
                while (profitable)
                {
                    spice += (startingYield - 26);
                    startingYield -= 10;
                    days++;

                    if (startingYield < 100)
                    {
                        profitable = false;

                        if (spice >= 26)
                        {
                            spice -= 26;
                        }
                    }
                }
            }
            

            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}