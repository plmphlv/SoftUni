namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream source = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (FileStream partOne = new FileStream(partOneFilePath, FileMode.Create))
                {
                    int odd = source.Length % 2 == 1 ? 1 : 0;
                    byte[] bufferPt1 = new byte[source.Length / 2 + odd];
                    source.Read(bufferPt1);
                    partOne.Write(bufferPt1);

                }

                using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    byte[] bufferPt2 = new byte[source.Length / 2];
                    source.Read(bufferPt2);
                    partTwo.Write(bufferPt2);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joined = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (FileStream partOne = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] bufferPt1 = new byte[partOne.Length];
                    partOne.Read(bufferPt1);
                    joined.Write(bufferPt1);

                }

                using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] bufferPt2 = new byte[partTwo.Length];
                    partTwo.Read(bufferPt2);
                    joined.Write(bufferPt2);

                }
            }
        }
    }
}