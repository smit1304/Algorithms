class Node
{
    int value;
    bool visited;

    public Node(int val)
    {
        this.value = val;
        this.visited = false;
    }
}

class Graph
{
    public int numOfVertices;
    public int[,] adjacencyMatrix;

    public Graph(int v)
    {
        this.numOfVertices = v;
        adjacencyMatrix = new int[v, v];
    }

    public void _AddEdge(int src, int dest)
    {
        this.adjacencyMatrix[src, dest] = 1;
    }

    public void _PrintGraph()
    {
        for (int i = 0; i < numOfVertices; i++)
        {
            for (int j = 0; j < numOfVertices; j++)
            {
                if (this.adjacencyMatrix[i, j] == 1)
                {
                    Console.WriteLine("edge between " + i + " and " + j);
                }
            }
        }
    }
}
class CycleInDirectedGraph
{
    public static void Main(string[] args)
    {
        Graph g = new Graph(3);
        g._AddEdge(0, 1);
        g._AddEdge(1, 2);
        g._AddEdge(2, 0);
        g._PrintGraph();

    }
}
