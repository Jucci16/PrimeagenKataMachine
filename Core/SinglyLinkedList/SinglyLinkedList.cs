using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SinglyLinkedList;
public class SinglyLinkedList<T> : ILinkedList<T>
{
    public int Length { get; private set; }
    private SinglyLinkedListNode<T>? _head;

    public SinglyLinkedList()
    {
        Length = 0;
        _head = null;
    }

    public void Append(T item)
    {
        ++Length;
        var newNode = new SinglyLinkedListNode<T>(item);
        if (_head == null)
        {
            _head = newNode;
            return;
        }

        var currentNode = GetPreviousNodeByIndex(Length - 1)!;
        currentNode.Next = newNode;
    }

    public T? Get(int index)
    {
        var node = GetNodeByIndex(index);

        return node == null ? default : node.Value;
    }

    public void InsertAt(T item, int index)
    {
        var newNode = new SinglyLinkedListNode<T>(item);
        if (index == 0)
        {
            var head = _head;
            newNode.Next = head;
            _head = newNode;
            ++Length;

            return;
        }

        var node = GetPreviousNodeByIndex(index);
        if (node == null) return;

        newNode.Next = node.Next;
        node.Next = newNode;
        ++Length;
    }

    public void Prepend(T item)
    {
        ++Length;
        var node = new SinglyLinkedListNode<T>(item);
        node.Next = _head;
        _head = node;
    }

    public T? Remove(T item)
    {
        if (_head != null && _head.Value != null && _head.Value.Equals(item))
        {
            --Length;
            var head = _head;
            _head = _head.Next;

            return head.Value;
        }

        var previous = GetPriviousNode(item);
        if (previous == null) return default;

        --Length;
        var toRemove = previous.Next!;
        var next = toRemove.Next;
        previous.Next = next;

        return toRemove.Value;
    }

    public T? RemoveAt(int index)
    {
        if (index == 0)
        {
            Length = Math.Max(0, Length - 1);
            var head = _head;
            _head = head?.Next;

            return head == null ? default : head.Value;
        }

        var previous = GetPreviousNodeByIndex(index);
        if (previous == null || previous.Next == null) return default;

        var toRemove = previous.Next;
        var next = toRemove.Next;
        previous.Next = next;
        --Length;

        return toRemove.Value;
    }

    private SinglyLinkedListNode<T>? GetPriviousNode(T item)
    {
        if (_head == null) return null;
        var node = _head;

        while(node.Next != null)
        {
            node = node.Next;
            if (EqualityComparer<T>.Default.Equals(node.Value, item)) break;
        }

        return EqualityComparer<T>.Default.Equals(node.Value, item) ? node : null;
    }

    private SinglyLinkedListNode<T>? GetNode(T item)
    {
        return GetPriviousNode(item)?.Next;
    }

    private SinglyLinkedListNode<T>? GetPreviousNodeByIndex(int index)
    {
        if (_head == null || index == 0) return _head;

        var node = _head;
        var i = 0;
        while ( i < index - 1)
        {
            node = node?.Next;
            ++i;
        }

        return node;
    }

    private SinglyLinkedListNode<T>? GetNodeByIndex(int index)
    {
        return index == 0 ? _head : GetPreviousNodeByIndex(index)?.Next;
    }
}
