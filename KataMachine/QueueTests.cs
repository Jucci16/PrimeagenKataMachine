using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
public class QueueTests
{
    [Fact]
    public void TestQueu()
    {
        var queue = new Core.Queue.Queue<int>();
        queue.Enqueue(5);
        queue.Enqueue(7);
        queue.Enqueue(9);

        Assert.Equal(5, queue.Dequeue());
        Assert.Equal(2, queue.Length);

        queue.Enqueue(11);

        Assert.Equal(7, queue.Dequeue());
        Assert.Equal(9, queue.Dequeue());
        Assert.Equal(11, queue.Peek());
        Assert.Equal(11, queue.Dequeue());
        Assert.Equal(0, queue.Dequeue());
        Assert.Equal(0, queue.Length);

        queue.Enqueue(69);
        Assert.Equal(69, queue.Peek());
        Assert.Equal(1, queue.Length);
    }
}
