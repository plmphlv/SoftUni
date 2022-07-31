using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());

            int gr1Musala = 0;
            int gr2Monbaln = 0;
            int gr3Kilimanjaro = 0;
            int gr4K2 = 0;
            int gr5Everest = 0;
            int totalito = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int members = int.Parse(Console.ReadLine());

                if (members <= 5)
                    gr1Musala += members;
                else if (members >= 6 && members <= 12)
                    gr2Monbaln += members;
                else if (members >= 13 && members <= 25)
                    gr3Kilimanjaro += members;
                else if (members >= 26 && members <= 40)
                    gr4K2 += members;
                else if (members >= 41)
                    gr5Everest += members;
            }

            totalito = gr1Musala + gr2Monbaln + gr3Kilimanjaro + gr4K2 + gr5Everest;

            double gr1MusalaP = ((double)gr1Musala / (double)totalito) * 100;
            double gr2MonbalnP = ((double)gr2Monbaln / (double)totalito) * 100;
            double gr3KilimanjaroP = ((double)gr3Kilimanjaro / (double)totalito) * 100;
            double gr4K2P = ((double)gr4K2 / (double)totalito) * 100;
            double gr5EverestP = ((double)gr5Everest / (double)totalito) * 100;


            Console.WriteLine($"{gr1MusalaP:f2}%");
            Console.WriteLine($"{gr2MonbalnP:f2}%");
            Console.WriteLine($"{gr3KilimanjaroP:f2}%");
            Console.WriteLine($"{gr4K2P:f2}%");
            Console.WriteLine($"{gr5EverestP:f2}%");
        }
    }
}
