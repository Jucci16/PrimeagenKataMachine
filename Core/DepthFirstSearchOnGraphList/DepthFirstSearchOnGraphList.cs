namespace Core.DepthFirstSearchOnGraphList;
public static class DepthFirstSearchOnGraphList
{
    public static List<int> Search(List<List<WeightedNode>> nodes, int start, int needle)
    {
        var stack = new Stack<int>();
        var visited = new List<bool>();
        for (var i = 0; i < nodes.Count; ++i)
        {
            visited.Add(false);
        }
        visited[start] = true;
        stack.Push(start);
        Walk(nodes, start, needle, visited, stack);

        var result = stack.ToList();
        result.Reverse();

        return result;
    }

    private static bool Walk(List<List<WeightedNode>> nodes, int index, int needle, List<bool> visited, Stack<int> path)
    {
        if (index == needle) return true;

        var found = false;
        var node = nodes[index];

        foreach (var weightedNode in node)
        {
            var to = weightedNode.To;
            if (visited[to]) continue;
            visited[to] = true;
            path.Push(to);
            if (Walk(nodes, to, needle, visited, path)) { found = true; break; }
            path.Pop();
        }

        return found;
    }
}
