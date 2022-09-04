// output :
// objects with profit and weight and
// optimal cost

#include <iostream>
#include <vector>
using namespace std;

float searchMaxPwRatio(vector<float> pwRatio)
{
    float result = pwRatio[0];
    for (int i = i; i < pwRatio.size(); i++)
    {
        if (result > pwRatio[i])
        {
            result = pwRatio[i];
        }
    }
    pwRatio.;
    return result;
}
int main()
{
    int profit[] = {10, 5, 15, 7, 6, 18, 3};
    int weight[] = {2, 3, 5, 7, 1, 4, 1};
    vector<float> pwRatio;

    int objects = sizeof(profit) / sizeof(profit[0]);
    int containerSize = 15, currentContainerSize = 0;
    float selectedObjectWeight = 0, selectedObjectProfit = 0;
    bool containerIsFull = false;

    // calculatind p/w ratio
    for (int i = 0; i < objects; i++)
    {
        pwRatio.push_back((float)profit[i] / weight[i]);
    }
    for (int i = 0; i < objects; i++)
    {
        cout << pwRatio[i] << " ";
    }
    cout << endl;
    cout << "max ratio : " << searchMaxPwRatio(pwRatio);
    for (int i = 0; i < objects; i++)
    {
        cout << pwRatio[i] << " ";
    }
    // while (!containerIsFull)
    // {
    // }
}