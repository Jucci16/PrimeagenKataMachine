using Core.Interfaces;

namespace Core.Stack;
public class Stack<T> : IStack<T>
{
    public int Length {get; set;}

    private StackNode<T>? _head;

    public T? Peek()
    {
        var value = _head is null ? default : _head.Value;
        return value;
    }

    public T? Pop()
    {
        if (Length == 0) return default;
        --Length;

        var head  = _head!;
        _head = head.Previous;

        return head.Value;
    }

    public void Push(T item)
    {
        ++Length;
        var node = new StackNode<T>(item);
        node.Previous = _head;
        _head = node;
    }
}
