namespace Core.CompareBinaryTrees;
public static class CompareBinaryTrees
{
    public static bool Compare(BinaryNode<int> a, BinaryNode<int> b)
    {
        if (a is null || b is null) return a == b;

        if (a.Value != b.Value) return false;
        if (!Compare(a.Left, b.Left)) return false;
        if (!Compare(a.Right, b.Right)) return false;

        return true;
    }
}
