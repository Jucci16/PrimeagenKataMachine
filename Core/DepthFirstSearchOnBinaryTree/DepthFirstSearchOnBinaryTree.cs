namespace Core.DepthFirstSearchOnBinaryTree;

public static class DepthFirstSearchOnBinaryTree
{
    public static bool Search(BinaryNode<int> node, int needle)
    {
        if (node.Value == needle) return true;

        if (node.Left is not null && Search(node.Left, needle)) return true;
        if (node.Right is not null && Search(node.Right, needle)) return true;

        return false;
    }
}
