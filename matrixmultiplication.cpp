#include <iostream>
using namespace std;
int main()
{
    int n;
    cout << "Size of matrix (n x n) : ";
    cin >> n;
    int a[n][n];
    int b[n][n];
    int multi[n][n];
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
            multi[i][j] = 0;
            for (int k = 0; k < n; k++)
            {
                multi[i][j] += a[i][k] * b[k][j];
            }
        }
    }
    cout << "Multiplication : " << endl;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            cout << multi[i][j];
            cout << "   ";
        }
        cout << endl;
    }
}