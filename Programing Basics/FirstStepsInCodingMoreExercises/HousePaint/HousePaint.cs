using System;

namespace HousePaint
{
    class HousePaint
    {
        static void Main(string[] args)
        {
            double xHeight = double.Parse(Console.ReadLine()); //височина на къщата
            double yLenght = double.Parse(Console.ReadLine()); //дължина на страничната стена
            double hRoofHeight = double.Parse(Console.ReadLine()); //височината на триъгълната стена

            double sideWallsArea =2 * (xHeight * yLenght)  - 2 * 2.25;
            double backWallAndFrontWall = 2*(xHeight*xHeight) - 2.4;
            double allWallsGreen = (sideWallsArea + backWallAndFrontWall)/3.4;

            double roofSideWalls = 2 * ((xHeight * hRoofHeight) / 2);
            double roofPaintRed = (2 * (xHeight * yLenght) + roofSideWalls) / 4.3;

            Console.WriteLine($"{allWallsGreen:f2}");
            Console.WriteLine($"{roofPaintRed:f2}");

        }
    }
}
