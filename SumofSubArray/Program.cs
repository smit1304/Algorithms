using System.Collections;
class SumOfSubArray
{
    public static void _PrintArray(ArrayList arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 5, 6, 8 };
        int target = 7;
        int remainngTarget = 0;
        ArrayList solutionSet = new ArrayList();
        for (int i = 0; i < arr.Count<int>() - 1; i++)
        {
            remainngTarget = target - arr[i];
            if (remainngTarget == 0)
            {
                solutionSet.Add(arr[i]);
                //print
                _PrintArray(solutionSet);
                break;
            }
            else if (remainngTarget < 0)
            {
                remainngTarget = 0;
                solutionSet.Clear();
                continue;
            }
            else
            {
                solutionSet.Add(arr[i]);
            }
            for (int j = i + 1; j < arr.Count<int>(); j++)
            {
                remainngTarget = target - arr[j];
                if (remainngTarget == 0)
                {
                    solutionSet.Add(arr[j]);
                    //print
                    _PrintArray(solutionSet);
                    break;
                }
                else if (remainngTarget < 0)
                {
                    remainngTarget = target + arr[j];
                    solutionSet.Clear();
                    continue;
                }
                else
                {
                    solutionSet.Add(arr[j]);
                }
            }
            remainngTarget = 0;
            solutionSet.Clear();
        }
    }
}


