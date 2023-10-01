using Core.BinarySearch;

namespace KataMachine;
public class BinarySearchTests
{
    [Fact]
    public void DoBinarySearch()
    {
        var numbers = Utilities.GenerateIntArray();
        Assert.True(BinarySearch.Search(numbers, 69));
        Assert.False(BinarySearch.Search(numbers, 1336));
        Assert.True(BinarySearch.Search(numbers, 69420));
        Assert.False(BinarySearch.Search(numbers, 69421));
        Assert.True(BinarySearch.Search(numbers, 1));
        Assert.False(BinarySearch.Search(numbers, 0));
    }
}
