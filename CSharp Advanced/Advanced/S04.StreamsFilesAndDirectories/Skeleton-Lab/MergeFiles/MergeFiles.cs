namespace MergeFiles
{
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            using (reader1)
            {

                StreamReader reader2 = new StreamReader(secondInputFilePath);
                using (reader2)
                {

                    StreamWriter writer = new StreamWriter(outputFilePath);
                    using (writer)
                    {
                        string line1;
                        string line2;

                        while ((line1 = reader1.ReadLine()) != null && (line2 = reader2.ReadLine()) != null)
                        {
                            if (line1 != null)
                            {
                                writer.WriteLine(line1);
                            }

                            if (line2 != null)
                            {
                                writer.WriteLine(line2);
                            }
                        }

                    }
                }
            }
        }
    }
}
