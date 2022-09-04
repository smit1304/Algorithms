#include <iostream>
using namespace std;
int main()
{
    int arr[] = {1, 32, 45, 12, 4, 5};
    int n = sizeof(arr) / sizeof(arr[0]);
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(arr[i], arr[j]);
            }
        }
    }
    cout << "Sorted List : ";
    for (int i = 0; i < n; i++)
    {
        cout << arr[i];
        cout << " ";
    }
}