namespace Core;
public static class BreadthFirstSearchOnGraphMatrix
{

    public static List<int> Search(List<List<int>> weightedMatrix, int start, int needle)
    {
        var seen = GenerateSeen(weightedMatrix.Count);
        var order = GenerateOrder(weightedMatrix.Count);
        var queue = new Queue<int>();
        seen[start] = true;
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current == needle) break;

            var node = weightedMatrix[current];
            for (int i = 0; i < node.Count; ++i)
            {
                if (node[i] > 0 && !seen[i])
                {
                    queue.Enqueue(i);
                    order[i] = current;
                    seen[i] = true;
                }
            }
        }

        if (order[needle] == -1) return new ();
        var path = new List<int>();
        var index = needle;

        while(index != -1)
        {
            path.Insert(0, index);
            index = order[index];
        }

        return path;
    }

    private static bool[] GenerateSeen(int size)
    {
        var array = new bool[size];
        for (int i = 0; i < size; ++i)
        {
            array[i] = false;
        }

        return array;
    }

    private static int[] GenerateOrder(int size)
    {
        var array = new int[size];
        for (var i = 0; i < size; ++i)
        {
            array[i] = -1;
        }

        return array;
    }
}
