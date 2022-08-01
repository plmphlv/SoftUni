using System;

namespace Salary
{
    internal class Salary
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i < salary; i++)
            {
                string webSite = Console.ReadLine();

                if (webSite == "Facebook")
                {
                    salary -= 150;
                }
                else if (webSite == "Instagram")
                {
                    salary -= 100;
                }
                else if(webSite =="Reddit")
                {
                    salary -= 50;
                }

                if (salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
