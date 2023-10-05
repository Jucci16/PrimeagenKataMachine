using Core.DepthFirstSearchOnGraphList;

namespace KataMachine;
public class DepthFirstSearchOnGraphListTests
{
    [Fact]
    public void DepthFirstSearchOnGraphListTest()
    {
        var expected = new List<int> { 0, 1, 4, 5, 6 };
        var result = DepthFirstSearchOnGraphList.Search(Utilities.GenerateWeightedList2(), 0, 6);

        Assert.True(Utilities.CompareIntArrays(expected, result));
    }
}
