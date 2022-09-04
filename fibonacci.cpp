#include <iostream>
using namespace std;
int fib(int x)
{
    if ((x == 1) || (x == 0))
    {
        return (x);
    }
    else
    {
        return (fib(x - 1) + fib(x - 2));
    }
}
int main()
{
    int n, i = 0;
    cout << "Enter number of terms : ";
    cin >> n;
    cout << "Series : ";
    while (i < n)
    {
        cout << fib(i) << " ";
        i++;
    }
}