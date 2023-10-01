using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
internal static class ListTests
{
    public static void TestList(ILinkedList<int> list)
    {
        list.Append(5);
        list.Append(7);
        list.Append(9);

        Assert.Equal(9, list.Get(2));
        Assert.Equal(7, list.RemoveAt(1));
        Assert.Equal(2, list.Length);

        list.Append(11);
        Assert.Equal(9, list.RemoveAt(1));
        Assert.Equal(-1, list.Remove(9));
        Assert.Equal(5, list.RemoveAt(0));
        Assert.Equal(11, list.RemoveAt(0));
        Assert.Equal(0, list.Length);

        list.Prepend(5);
        list.Prepend(7);
        list.Prepend(9);

        Assert.Equal(5, list.Get(2));
        Assert.Equal(0, list.Get(9));
        Assert.Equal(9, list.Remove(9));
        Assert.Equal(2, list.Length);
        Assert.Equal(7, list.Get(0));
    }
}
