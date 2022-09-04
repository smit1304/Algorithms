#include <iostream>
using namespace std;
int main()
{
    int arr[] = {1231, 213, 45, 2, 4, 5};
    int n = sizeof(arr) / sizeof(arr[0]);
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j > 0; j--)
        {
            if (arr[j] > arr[j - 1])
            {
                break;
            }
            swap(arr[j], arr[j - 1]);
        }
    }
    cout << "Sorted List : ";
    for (int i = 0; i < n; i++)
    {
        cout << arr[i] << " ";
    }
}