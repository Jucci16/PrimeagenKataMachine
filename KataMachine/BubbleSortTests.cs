using Core.BubbleSort;

namespace KataMachine;
public class BubbleSortTests
{
    [Fact]
    public void DoBubbleSort()
    {
        var sortedArray = Utilities.GenerateSortedIntArray();
        var unsortedArray = Utilities.GenerateUnSortedIntArray();
        var bubbleSortedArray = BubbleSort.Sort(unsortedArray);
        Assert.True(Utilities.CompareIntArrays(sortedArray, bubbleSortedArray));
    }
}
