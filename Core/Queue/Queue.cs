using Core.Interfaces;

namespace Core.Queue;
public class Queue<T> : IQueue<T>
{
    public int Length => throw new NotImplementedException();

    public T? Dequeue()
    {
        throw new NotImplementedException();
    }

    public void Enqueue(T item)
    {
        throw new NotImplementedException();
    }

    public T? Peek()
    {
        throw new NotImplementedException();
    }
}
