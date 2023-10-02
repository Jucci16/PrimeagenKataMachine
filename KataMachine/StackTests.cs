using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
public class StackTests
{
    [Fact]
    public void Stack()
    {
        var stack = new Core.Stack.Stack<int>();

        stack.Push(5);
        stack.Push(7);
        stack.Push(9);

        Assert.Equal(9, stack.Pop());
        Assert.Equal(2, stack.Length);

        stack.Push(11);
        Assert.Equal(11, stack.Pop());
        Assert.Equal(7, stack.Pop());
        Assert.Equal(5, stack.Peek());
        Assert.Equal(5, stack.Pop());
        Assert.Equal(0, stack.Pop());

        stack.Push(69);
        Assert.Equal(69, stack.Peek());
        Assert.Equal(1, stack.Length);
    }
}
