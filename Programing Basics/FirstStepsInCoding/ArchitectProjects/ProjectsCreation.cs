using System;

namespace ArchitectProjects
{
    class ProjectsCreation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projAmaount = int.Parse(Console.ReadLine());
            int projTime = projAmaount * 3;
            Console.WriteLine($"The architect {name} will need {projTime} hours to complete {projAmaount} project/s.");
        }
    }
}
