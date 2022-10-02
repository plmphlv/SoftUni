namespace _4.ArrayRotation
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine()) % myArr.Length;

            for (int i = 0; i < rotations; i++)
            {
                int firstArrNum = myArr[0];
                for (int r = 0; r < myArr.Length - 1; r++)
                {
                    myArr[r] = myArr[r + 1];
                }

                myArr[myArr.Length - 1] = firstArrNum;
            }

            Console.WriteLine(String.Join(" ", myArr));
        }
    }
}