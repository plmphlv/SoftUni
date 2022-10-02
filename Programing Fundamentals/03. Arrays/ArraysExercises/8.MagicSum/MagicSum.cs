namespace _8.MagicSum
{
    internal class MagicSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetSum && nums[k] != nums[i])
                    {
                        Console.WriteLine($"{nums[i]} {nums[k]}");
                    }
                }
            }
        }
    }
}