namespace Core.Stack;
internal class StackNode<T>
{
    public T Value { get; set; }
    public StackNode<T>? Previous { get; set; }

    public StackNode(T value)
    {
        Value = value;
    }
}
