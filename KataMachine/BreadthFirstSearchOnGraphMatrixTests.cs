using Core;

namespace KataMachine;
public class BreadthFirstSearchOnGraphMatrixTests
{
    [Fact]
    public void BreadthFirstSearchTests()
    {
        var expected = new List<int> { 0, 1, 4, 5, 6 };
        var result = BreadthFirstSearchOnGraphMatrix.Search(Utilities.GenerateWeightedMatrix(), 0, 6);
        Assert.True(Utilities.CompareIntArrays(expected, result));
    }
}
