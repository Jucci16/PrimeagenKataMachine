using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces;
public interface ILinkedList<T>
{
    int Length { get; }

    void Prepend(T item);

    void InsertAt(T item, int index);

    void Append(T item);

    T? Remove(T item);

    T? Get(int index);

    T? RemoveAt(int index);

}
