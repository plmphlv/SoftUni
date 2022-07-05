using System;

namespace FuelTankPart2
{
    internal class FillTheTank
    {
        static void Main()
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double fuelCost=0;


            if (clubCard == "yes" || clubCard == "Yes")
            {
                if (fuelType == "Gasoline" || fuelType == "gasoline")
                {
                    fuelCost = fuelLiters * 2.04;

                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                else if (fuelType == "Diesel" || fuelType == "diesel")
                {
                    fuelCost = fuelLiters * 2.21;

                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                else if (fuelType == "Gas" || fuelType == "gas")
                {
                    fuelCost = fuelLiters * 0.85;
                    
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                Console.WriteLine($"{fuelCost:f2} lv.");
            }

            else
            {
                if (fuelType == "Gasoline" || fuelType == "gasoline")
                {
                    fuelCost = fuelLiters * 2.22;
                    
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                else if (fuelType == "Diesel" || fuelType == "diesel")
                {
                    fuelCost = fuelLiters * 2.33;
                    
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                else if (fuelType == "Gas" || fuelType == "gas")
                {
                    fuelCost = fuelLiters * 0.93;
                    
                    if (fuelLiters >= 20 && fuelLiters <= 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.08);
                    }
                    else if (fuelLiters > 25)
                    {
                        fuelCost = fuelCost - (fuelCost * 0.10);
                    }
                }

                Console.WriteLine($"{fuelCost:f2} lv.");
            }
        }
    }
}
