namespace Core.BreadthFirstSearchOnBinaryTree;
public static class BredthFirstSearchOnBinaryTree
{
    public static bool Search(BinaryNode<int> node, int needle)
    {
        var queue = new Queue<BinaryNode<int>>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var binaryNode = queue.Dequeue();
            if (binaryNode.Value == needle) return true;
            if (binaryNode.Left is not null) queue.Enqueue(binaryNode.Left);
            if (binaryNode.Right is not null) queue.Enqueue(binaryNode.Right);
        }

        return false;
    }
}
