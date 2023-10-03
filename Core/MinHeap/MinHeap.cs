namespace Core.MinHeap;
public class MinHeap
{
    public int Length { get; private set; }
    private List<int> _heap;

    public MinHeap()
    {
        _heap = new List<int>();
        Length = 0;
    }

    public void Insert(int number)
    {
        _heap.Add(number);
        HeapifyUp(Length);
        ++Length;
    }

    public int Delete()
    {
        var value = _heap[0];
        --Length;
        _heap[0] = _heap[Length];
        HeapifyDown(0);
        _heap.RemoveAt(Length);

        return value;
    }

    private static int GetParentIndex(int index) => (index - 1) / 2;
    private static int GetLeftChildIndex(int index) => index * 2 + 1;
    private static int GetRighChildIndex(int index) => index * 2 + 2;

    private void Swap(int indexA, int indexB)
    {
        var temp = _heap[indexA];
        _heap[indexA] = _heap[indexB];
        _heap[indexB] = temp;
    }

    private void HeapifyUp(int index)
    {
        if (index <= 0) return;
        var parentIndex = GetParentIndex(index);
        var parentValue = _heap[parentIndex];
        var value = _heap[index];

        if (parentValue <= value) return;

        Swap(parentIndex, index);
        HeapifyUp(parentIndex);
    }

    private void HeapifyDown(int index)
    {
        if (index >= Length) return;
        var leftChildIndex = GetLeftChildIndex(index);
        var rightChildIndex = GetRighChildIndex(index);

        if (leftChildIndex >= Length) return;

        if (_heap[leftChildIndex] < _heap[rightChildIndex] && _heap[index] > _heap[leftChildIndex])
        {
            Swap(leftChildIndex, index);
            HeapifyDown(leftChildIndex);
        } else if (_heap[rightChildIndex] <= _heap[leftChildIndex] && _heap[index] > _heap[rightChildIndex])
        {
            Swap(rightChildIndex, index);
            HeapifyDown(rightChildIndex);
        }
    }
}
