namespace _9.KaminoFactory
{
    internal class KaminoFactory
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            string command;
            int[] bestDna = new int[dnaLenght];
            int bestDnaSum = 0;
            int bestDnaIndex = 0;
            int bestSeq = 0;

            while ((command=Console.ReadLine())!= "Clone them!")
            {
                int[] currentDNA =command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentLeftMostIndex = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        currentLeftMostIndex = i;
                        break;
                    }
                }

                int currSeq = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] ==currentDNA[i+1])
                    {
                        currSeq++;
                    }
                }


                if (currSeq > bestSeq)
                {
                    bestDna = currentDNA;
                    bestDnaSum = currentDNA.Sum();
                    bestDnaIndex = currentLeftMostIndex;
                    bestSeq = currSeq;
                }
                else if (currentDNA.Sum() == bestDnaSum && currentLeftMostIndex<bestDnaIndex)
                {
                    bestDna = currentDNA;
                    bestDnaSum = currentDNA.Sum();
                    bestDnaIndex = currentLeftMostIndex;
                }
                

            }
        }
    }
}