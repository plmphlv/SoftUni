using System;

namespace WorkShop
{
    class WorkShop
    {
        static void Main(string[] args)
        {
            double lenght =double.Parse(Console.ReadLine())*100;
            double width = (double.Parse(Console.ReadLine())*100)-100;

            double seats = Math.Floor(width / 70) * Math.Floor(lenght / 120) - 3; //Math.Floor() връща най-близкия int който е по-малък или равен на числото в скобите

            Console.WriteLine(seats);
        }
    }
}
