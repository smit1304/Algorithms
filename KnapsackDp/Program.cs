class Item
{
    public int weight;
    public int value;
    //public float pwRatio;
    public Item(int v1, int v2)
    {
        this.value = v1;
        this.weight = v2;
    }
}

class KnapsackDp
{
    public static void _TraceKnapackDp()
    {

    }
    public static void _FillTable(float[,] records, List<Item> listOfObjects, int outerBound, int innerBound)
    {
        for (int i = 0; i < outerBound; i++)
        {
            for (int j = 0; j < innerBound; j++)
            {
                if (j == 0)
                {
                    records[i, j] = 0;
                    return;
                }
                if (j < listOfObjects[i - 1].weight)
                {
                    records[i, j] = records[i - 1, j];
                    return;
                }
                if (j >= listOfObjects[i - 1].weight)
                {
                    records[i, j] = MathF.Max(records[i - 1, j], records[i - 1, j - listOfObjects[i - 1].weight] + listOfObjects[i - 1].value);
                    return;
                }

            }
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Size of bag : ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Item> listOfObjects = new List<Item>()
        {
            new Item(22,4),new Item(12,8),new Item(8,2),new Item(21,7),new Item(15,5) //(profit,value)
        };
        //int[] Di = new int[] { 1, 4, 6 };
        float[,] records = new float[listOfObjects.Count + 1, n + 1];
        List<float> solution = new List<float>();

        _FillTable(records, listOfObjects, listOfObjects.Count + 1, n + 1);
        //_TraceKnapackDp();

        // Debug
        Console.WriteLine("Taable : ");
        for (int i = 0; i < listOfObjects.Count + 1; i++)
        {
            for (int j = 0; j < n + 1; j++)
            {
                Console.Write(records[i, j] + " ");
            }
            Console.WriteLine();
        }
        // Console.Write("Solution : ");
        // for (int i = 0; i < solution.Count; i++)
        // {
        //     Console.Write(solution[i] + " ");
        // }
    }
}