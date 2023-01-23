namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            FileStream imageStream = new FileStream(binaryFilePath, FileMode.Open);
            using (imageStream)
            {
                FileStream bytesStream = new FileStream(bytesFilePath, FileMode.Open);
                using (bytesStream)
                {
                    byte[] bytesBuffer = new byte[bytesStream.Length];
                    bytesStream.Read(bytesBuffer, 0, bytesBuffer.Length);

                    byte[] imageBuffer = new byte[imageStream.Length];
                    imageStream.Read(imageBuffer, 0, (int)imageStream.Length);

                    FileStream output = new FileStream(outputPath, FileMode.Create);
                    using (output)
                    {
                        for (int i = 0; i < imageBuffer.Length; i++)
                        {
                            for (int j = 0; j < bytesBuffer.Length; j++)
                            {
                                if (imageBuffer[i] == bytesBuffer[j])
                                {
                                    output.Write(new byte[] { imageBuffer[i] });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
