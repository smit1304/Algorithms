using System;
class LinearSearch
{
    public static void Search(int[] arr, int size, int val)
    {
        for (int i = 0; i < size; i++)
        {
            if (val == arr[i])
            {
                Console.WriteLine("Found Element at : " + i);
                return;
            }
        }
        Console.WriteLine("Element not Found");
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
        Search(arr, n, srch);
    }
}
