class ChangMaking
{

    public static void _FillTable(float[,] records, int[] Di, int rowSize, int columnSize)
    {
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < columnSize; j++)
            {
                if (i == 0 || j == 0)
                {
                    records[i, j] = 0;
                    continue;
                }
                if (i == 1)
                {
                    records[i, j] = 1 + records[i, j - Di[i - 1]];
                    continue;
                }
                if (j < Di[i - 1])
                {
                    records[i, j] = records[i - 1, j];
                    continue;
                }

                records[i, j] = MathF.Min(records[i - 1, j], 1 + records[i, j - Di[i - 1]]);
            }
        }
    }
    public static void _TraceMakeChange(float[,] records, int[] Di, List<float> solution, int i, int j)
    {
        if (j == 0)
        {
            return;
        }
        if (records[i, j] == records[i - 1, j])
        {
            i--;
            _TraceMakeChange(records, Di, solution, i, j);
        }
        else
        {
            solution.Add(Di[i - 1]);
            j = j - Di[i - 1];
            _TraceMakeChange(records, Di, solution, i, j);
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Amount : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] Di = new int[] { 1, 4, 6 };
        float[,] records = new float[Di.Length + 1, n + 1];
        List<float> solution = new List<float>();

        _FillTable(records, Di, Di.Length + 1, n + 1);
        _TraceMakeChange(records, Di, solution, Di.Length, n);

        // Debug
        Console.WriteLine("Taable : ");
        for (int i = 0; i < Di.Length + 1; i++)
        {
            for (int j = 0; j < n + 1; j++)
            {
                Console.Write(records[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.Write("Solution : ");
        for (int i = 0; i < solution.Count; i++)
        {
            Console.Write(solution[i] + " ");
        }
    }
}