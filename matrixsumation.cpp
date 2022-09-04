#include <iostream>
using namespace std;
int main()
{
    int n;
    cout << "Size of matrix (n x n) : ";
    cin >> n;
    int a[n][n];
    int b[n][n];
    int sum[n][n];

    cout << "Input for matrix A : " << endl;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cin >> a[i][j];
        }
    }
    cout << "Input for matrix B : " << endl;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cin >> b[i][j];
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i][j] = a[i][j] + b[i][j];
        }
    }
    cout << "Sum : " << endl;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << sum[i][j];
            cout << "   ";
        }
        cout << endl;
    }
}