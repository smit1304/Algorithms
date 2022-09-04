using System.Collections;
class Edge
{
    public int src;
    public int dest;
    public int edgeWeight;
}
class CompareByEdge : IComparer
{
    int IComparer.Compare(object x, object y)
    {
        Edge e1 = (Edge)x;
        Edge e2 = (Edge)y;
        return e1.edgeWeight.CompareTo(e2.edgeWeight);
    }
}
class Krushkals
{
    public static int _FindParent(int[] Parent, int x)
    {
        if (Parent[x] == x)
            return x;
        else
            return _FindParent(Parent, Parent[x]);
    }
    public static void Main(string[] args)
    {
        int n = 0; // number of connections
        int edgeCount = 0; //counts number of edges are drawn in solution
        int edgeOffset = 0; // offset pointer for Edges list of object
        int sourceParent = 0;
        int destinationParent = 0;
        ArrayList Edges = new ArrayList();
        ArrayList SolutionSet = new ArrayList();
        Edge currentEdgePointer; //points to current edge

        //taking inputs
        Console.Write("Number of Connection : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Edge e = new Edge();
            Console.Write("Source : ");
            e.src = Convert.ToInt32(Console.ReadLine());
            Console.Write("Destination : ");
            e.dest = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight : ");
            e.edgeWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------");
            Edges.Add(e);
        }
        int[] Parent = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            Parent[i] = i;
        }

        //sort list according to edge weight
        Edges.Sort(new CompareByEdge());
        foreach (Edge e in Edges)
        {
            Console.WriteLine("src : " + e.src + " " + "dest : " + e.dest + " " + "Cost : " + e.edgeWeight);
        }
        Console.WriteLine("-------Solution Set------");

        //fill solution set make sure spanning tree dosent fill cycle
        while (SolutionSet.Count != n - 1)
        {
            currentEdgePointer = (Edge)Edges[edgeOffset];

            //check if this current edge makes cycle or not
            sourceParent = _FindParent(Parent, currentEdgePointer.src);
            destinationParent = _FindParent(Parent, currentEdgePointer.dest);
            if (sourceParent != destinationParent)
            {
                SolutionSet.Add(currentEdgePointer);
                Parent[sourceParent] = destinationParent;
                edgeCount++;
                Console.WriteLine("src : " + currentEdgePointer.src + " " + "dest : " + currentEdgePointer.dest + " " + "Cost : " + currentEdgePointer.edgeWeight);
            }
            edgeOffset++;
        }
    }
}
