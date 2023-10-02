namespace Core.SinglyLinkedList;
internal class SinglyLinkedListNode<T>
{
    public T Value { get; set; }
    public SinglyLinkedListNode<T>? Next { get; set; }

    public SinglyLinkedListNode(T value)
    {
        Value = value;
    }
}
