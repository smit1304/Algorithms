class BinarySearch
{
    public static int mid;
    public static void Search(int[] arr, int left, int right, int val)
    {
        mid = (left + right) / 2;
        while (left <= right)
        {
            if (val == arr[mid])
            {
                Console.WriteLine("Found Element at : " + mid);
                return;
            }
            else if (val < arr[mid])
            {
                Search(arr, left, mid, val);
            }
            else if (val > arr[mid])
            {
                Search(arr, mid + 1, right, val);
            }
        }
        Console.WriteLine("Element Not Found");
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Search Element : ");
        int srch = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Legnth of Array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element " + i + " : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Search(arr, 0, n - 1, srch);
    }
}