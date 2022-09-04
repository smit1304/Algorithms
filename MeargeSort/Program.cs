class MeargeSort
{
    public static int n1;
    public static int n2;
    public static int mid;
    public static int arrIndex;
    public static int leftSubArrayIndex;
    public static int rightSubArrayIndex;
    public static List<int> leftSubArray = new List<int>();
    public static List<int> rightSubArray = new List<int>();
    public static void Mearge(List<int> arr, int left, int mid, int right)
    {
        n1 = mid - left + 1;
        n2 = right - mid;
        //filling left sub array
        for (int i = 0; i < n1; i++, arrIndex++)
        {
            leftSubArray.Add(arr[left + i]);
        }
        //filling right sub array
        for (int i = 0; i < n2; i++, arrIndex++)
        {
            rightSubArray.Add(arr[mid + 1 + i]);
        }
        //mearging right and left sub arrays with the help of index insort copping them to main array
        arrIndex = left;
        while (leftSubArrayIndex < n1 && rightSubArrayIndex < n2)
        {
            if (leftSubArray[leftSubArrayIndex] <= rightSubArray[rightSubArrayIndex])
            {
                arr[arrIndex] = leftSubArray[leftSubArrayIndex];
                leftSubArrayIndex++;
            }
            else
            {
                arr[arrIndex] = rightSubArray[rightSubArrayIndex];
                rightSubArrayIndex++;
            }
            arrIndex++;
        }

        while (leftSubArrayIndex < n1)
        {
            arr[arrIndex] = leftSubArray[leftSubArrayIndex];
            arrIndex++;
            leftSubArrayIndex++;
        }

        while (rightSubArrayIndex < n2)
        {
            arr[arrIndex] = rightSubArray[rightSubArrayIndex];
            arrIndex++;
            rightSubArrayIndex++;
        }
        //nullifying sub arrays
        leftSubArray.Clear();
        rightSubArray.Clear();
        leftSubArrayIndex = 0;
        rightSubArrayIndex = 0;
        arrIndex = 0;
    }
    public static void Sort(List<int> arr, int left, int right)
    {
        if (left < right)
        {
            mid = (left + right) / 2;
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Mearge(arr, left, mid, right);
        }
    }
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>()
        {
            13,12,11,7,6,5
        };
        Console.Write("Unsorted array : ");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("--------------");
        Sort(arr, 0, 5);
        Console.Write("Sorted array : ");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("");
    }
}
