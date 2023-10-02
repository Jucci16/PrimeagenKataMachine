using Core.Interfaces;

namespace Core.Queue;
public class Queue<T> : IQueue<T>
{
    public int Length { get; private set; }

    private QueueNode<T>? _head;
    private QueueNode<T>? _tail;

    public T? Dequeue()
    {
        if (Length == 0) return default;

        --Length;
        var node = _head!;
        _head = node.Previous;

        if (_head is not null) _head.Next = null;
        if (Length == 0) _tail = null;
        if (Length == 1) _tail = _head;

        return node.Value;
    }

    public void Enqueue(T item)
    {
        var node = new QueueNode<T>(item);
        ++Length;

        if (Length == 1) _head = node;

        var oldNode = _tail;
        node.Next = oldNode;
        if (oldNode is not null) oldNode.Previous = node;
        _tail = node;
    }

    public T? Peek()
    {
        var value = _head is null ? default : _head.Value;
        return value;
    }
}
