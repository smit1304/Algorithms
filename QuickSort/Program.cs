using System;
class QuickSort
{
    static void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j <= high - 1; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return (i + 1);
    }
    static void _QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = partition(arr, low, high);
            _QuickSort(arr, low, pi - 1);
            _QuickSort(arr, pi + 1, high);
        }
    }
    static void printArray(int[] arr, int size)
    {
        for (int i = 0; i < size; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr = { 13, 12, 11, 7, 6, 5 };
        int n = arr.Length;
        Console.Write("Unsorted array : ");
        printArray(arr, n);
        Console.WriteLine("--------------");
        _QuickSort(arr, 0, n - 1);
        Console.Write("Sorted array : ");
        printArray(arr, n);
    }
}