public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode result = null;
    public static TreeNode searchNode(TreeNode node, int val)
    {
        if (node == null || node.val == val)
            return node;
        searchNode(node.left, val);
        searchNode(node.right, val);
    }

}

public class BinarySearchTree
{
    public static void Main(string[] args)
    {
        TreeNode root = new TreeNode(10, null, null);
        root.left = new TreeNode(2, null, null);
        root.left.left = new TreeNode(1, null, null);
        root.left.right = new TreeNode(3, null, null);
        root.right = new TreeNode(7, null, null);

        Console.Write(root.left.left.val);

        TreeNode result = TreeNode.searchNode(root, 2, result);
    }
}