class ChangMaking
{

    public static void _MakeChange(float[,] records, int[] Di, int rowSize, int columnSize)
    {
        //List<int> availableCoins = new List<int>();
        //int coinOffset = 0;
        //fill the records 
        for (int i = 1; i < rowSize; i++)
        {
            // if (i != 0)
            // {
            //     availableCoins.Add(Di[coinOffset]);
            // }
            //availableCoins.Add(i);
            for (int j = 1; j < columnSize; j++)
            {
                // if (availableCoins.Count == 0 && j > 0)
                // {
                //     records[i, j] = 0;
                //     continue;
                // }
                if (i == 1 && j < Di[i - 1])
                {
                    records[i, j] = 0;
                    continue;
                }
                if (i == 1)
                {
                    records[i, j] = 1 + records[1, j - Di[i - 1]];
                    continue;
                }
                if (j < Di[i - 1])
                {
                    records[i, j] = records[i - 1, j];
                    continue;
                }
                records[i, j] = MathF.Min(records[i - 1, j], 1 + records[1, j - Di[i - 1]]);
            }
            // if (i != 0)
            // {
            //     coinOffset++;
            // }
        }
    }
    public static void _TraceMakeChange(int[,] records)
    {
        //fill the solution set
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Amount : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Di = new int[] { 1, 4, 6 };
        float[,] records = new float[Di.Length + 1, n + 1];
        List<int> solution = new List<int>();
        Console.WriteLine(records.Length);

        //Console.Write(Di[0]);
        _MakeChange(records, Di, Di.Length + 1, n + 1);

        for (int i = 1; i < Di.Length + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                Console.Write(records[i, j] + " ");
            }
            Console.WriteLine();
        }


    }
}