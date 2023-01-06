using System;

namespace E02.PascalTriangle
{
    internal class PascalTriangle
    {
        static void Main(string[] args)
        {
            int triangleSize = int.Parse(Console.ReadLine());

            int[] triangleRow = { 1 };

            for (int i = 1; i <= triangleSize; i++)
            {

                int[] newTriangleRow = new int[i];

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