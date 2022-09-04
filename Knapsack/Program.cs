class Item
{
    public int weight;
    public int value;
    public float pwRatio;
    public Item(int v1, int v2)
    {
        this.value = v1;
        this.weight = v2;
    }
}

class Knapsack
{
    //returns index of maximum pw ratio 
    public static int searchMaxPwRatio(List<Item> listOfObjects)
    {
        int indexOfMaxPwRatio = 0;
        float temp = Int16.MinValue;
        for (int i = 0; i < listOfObjects.Count; i++)
        {
            if (temp < listOfObjects[i].pwRatio)
            {
                indexOfMaxPwRatio = i;
                temp = listOfObjects[i].pwRatio;
            }
        }
        return indexOfMaxPwRatio;
    }

    public static void Main(string[] Args)
    {
        List<Item> listOfObjects = new List<Item>()
        {
            new Item(22,4),new Item(12,8),new Item(8,2),new Item(21,7),new Item(15,5) //(profit,value)
        };
        foreach (Item item in listOfObjects)
        {
            Console.WriteLine("Value : " + item.value + " " + "Weight : " + item.weight);
        }
        int containerSize = 20;
        float selectedObjectWeight = 0, selectedObjectProfit = 0, optimalProfit = 0, currentContainerSize = 0;
        bool containerIsFull = false;
        int indexOfMaxPwRatio = 0;
        int objectCounter = 0;
        //calculating pw ratio
        foreach (Item item in listOfObjects)
        {
            item.pwRatio = (float)item.value / item.weight;
        }
        Console.Write("Profit/weight : ");
        foreach (var item in listOfObjects)
        {
            Console.Write(item.pwRatio + " ");
        }
        Console.WriteLine("");

        while (!containerIsFull)
        {
            //searching for maximum profit/weight ratio
            indexOfMaxPwRatio = searchMaxPwRatio(listOfObjects);

            selectedObjectWeight = listOfObjects[indexOfMaxPwRatio].weight;
            selectedObjectProfit = listOfObjects[indexOfMaxPwRatio].value;
            objectCounter++;

            //condition for final item
            if (currentContainerSize + selectedObjectWeight > containerSize)
            {
                optimalProfit += ((float)(containerSize - currentContainerSize) / selectedObjectWeight) * selectedObjectProfit;
                currentContainerSize += ((float)(containerSize - currentContainerSize) / selectedObjectWeight) * selectedObjectWeight;
                listOfObjects.Remove(listOfObjects[indexOfMaxPwRatio]);
                break;
            }

            currentContainerSize += selectedObjectWeight;
            optimalProfit += selectedObjectProfit;

            listOfObjects.Remove(listOfObjects[indexOfMaxPwRatio]);
            if (currentContainerSize >= containerSize)
                containerIsFull = true;
        }
        Console.WriteLine("Current container size : " + currentContainerSize);
        Console.WriteLine("Total number of items in bag : " + objectCounter);
        Console.WriteLine("Optimal Profit : " + optimalProfit);
    }
}