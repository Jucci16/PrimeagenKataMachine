using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Queue;
internal class QueueNode<T>
{
    public T Value { get; set; }
    public QueueNode<T>? Previous { get; set; }
    public QueueNode<T>? Next { get; set; }

    public QueueNode(T value)
    {
        Value = value;
    }
}
