using Core.QuickSort;

namespace KataMachine;
public class QuickSortTests
{
    [Fact]
    public void TestQuickSort()
    {
        var sorted = Utilities.GenerateSortedIntArray();
        var unSorted = Utilities.GenerateUnSortedIntArray();
        var quickSorted = QuickSort.Sort(unSorted);

        Assert.True(Utilities.CompareIntArrays(sorted, quickSorted));
    }
}
