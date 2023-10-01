using Core.LinearSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataMachine;
public class LinearSearchTests
{
    [Fact]
    public void DoLinearSearch()
    {
        int[] numbers = Utilities.GenerateSortedIntArray();
        Assert.True(LinearSearch.Search(numbers, 69));
        Assert.False(LinearSearch.Search(numbers, 1336));
        Assert.True(LinearSearch.Search(numbers, 69420));
        Assert.False(LinearSearch.Search(numbers, 69421));
        Assert.True(LinearSearch.Search(numbers, 1));
        Assert.False(LinearSearch.Search(numbers, 0));
    }
}
