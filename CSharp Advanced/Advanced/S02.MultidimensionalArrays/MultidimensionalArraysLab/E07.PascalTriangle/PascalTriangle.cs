using System;

namespace E07.PascalTriangle
{
    internal class PascalTriangle
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());

            long[] triangleRow = { 1 };

            for (int i = 1; i <= triangleSize; i++)
            {

                long[] newTriangleRow = new long[i];

                for (int j = 0; j < newTriangleRow.Length; j++)
                {

                    if (j == 0 || j == newTriangleRow.Length - 1)
                    {
                        newTriangleRow[j] = 1;
                    }
                    else
                    {
                        newTriangleRow[j] = triangleRow[j - 1] + triangleRow[j];
                    }

                }

                triangleRow = newTriangleRow;
                Console.WriteLine(String.Join(" ", triangleRow));
            }
        }
    }
}