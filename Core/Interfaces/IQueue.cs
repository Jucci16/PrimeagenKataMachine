using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces;
public interface IQueue<T>
{
    int Length { get; }

    void Enqueue(T item);

    T? Dequeue();

    T? Peek();
}
