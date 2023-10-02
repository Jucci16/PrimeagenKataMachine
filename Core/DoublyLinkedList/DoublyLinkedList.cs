using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DoublyLinkedList;
public class DoublyLinkedList<T> : ILinkedList<T>
{
    public int Length { get; private set; }
    private DoublyLinkedListNode<T>? _head;

    public DoublyLinkedList()
    {
        Length = 0;
        _head = null;
    }

    public void Append(T item)
    {
        var newNode = new DoublyLinkedListNode<T>(item);
        var lastNode = GetByIndex(Length - 1);
        ++Length;

        if (lastNode is null)
        {
            _head = newNode;
            return;
        }

        lastNode.Next = newNode;
        newNode.Previous = lastNode;
    }

    public T? Get(int index)
    {
        var node = GetByIndex(index);
        return node is null ? default : node.Value;
    }

    public void InsertAt(T item, int index)
    {
        var newNode = new DoublyLinkedListNode<T>(item);
        DoublyLinkedListNode<T>? indexNode;
        if (index == 0)
        {
            indexNode = _head;
            newNode.Next = indexNode;
            if (indexNode is not null) indexNode.Previous = newNode;
            _head = newNode;
            ++Length;
            return;
        }

        indexNode = GetByIndex(index);
        if (indexNode == null) return;

        newNode.Next = indexNode;
        newNode.Previous = indexNode.Previous;
        indexNode.Previous = newNode;
        ++Length;
    }

    public void Prepend(T item)
    {
        InsertAt(item, 0);
    }

    public T? Remove(T item)
    {
        var toRemove = GetByValue(item);
        if (toRemove is null) return default;

        if (toRemove.Previous is not null)
        {
            toRemove.Previous.Next = toRemove.Next;
        }
        if (toRemove.Next is not null)
        {
            toRemove.Next.Previous = toRemove.Previous;
        }
        if (EqualityComparer<T>.Default.Equals(toRemove.Value, _head!.Value)) _head = toRemove.Next;
        --Length;

        return toRemove.Value;
    }

    public T? RemoveAt(int index)
    {
        if (index == 0 && _head is null) return default;

        DoublyLinkedListNode<T>? toRemove;
        if (index == 0)
        {
            toRemove = _head;
            _head = _head?.Next;
        }
        else 
        {
            toRemove = GetByIndex(index);
        }

        if (toRemove is null) return default;

        if (toRemove.Previous is not null) toRemove.Previous.Next = toRemove.Next;
        if (toRemove.Next is not null) toRemove.Next.Previous = toRemove.Previous;

        --Length;

        return toRemove.Value;
    }

    private DoublyLinkedListNode<T>? GetByIndex(int index)
    {
        if (index <= 0) return _head;

        var node = _head;
        for (var i = 1; i <= index; ++i)
        {
            node = node?.Next;
        }

        return node;
    }

    private DoublyLinkedListNode<T>? GetByValue(T item)
    {
        var node = _head;
        while (node != null)
        {
            if (EqualityComparer<T>.Default.Equals(node.Value, item)) break;
            node = node.Next;
        }

        return node;
    }
}
