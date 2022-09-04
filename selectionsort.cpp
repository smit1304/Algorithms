#include <iostream>
using namespace std;
int main()
{
    int arr[] = {3, 35, 23, 97, 4, 5};
    int n = sizeof(arr) / sizeof(arr[0]);
    int minimum_index = 0;
    for (int i = 0; i < n; i++)
    {
        minimum_index = i;
        for (int j = i; j < n; j++)
        {
            if (arr[minimum_index] > arr[j])
            {
                minimum_index = j;
            }
        }
        if (i != minimum_index)
            swap(arr[i], arr[minimum_index]);
    }
    cout << "Sorted List : ";
    for (int i = 0; i < n; i++)
    {
        cout << arr[i];
        cout << " ";
    }
}