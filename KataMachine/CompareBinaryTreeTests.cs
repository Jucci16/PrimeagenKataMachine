using Core.CompareBinaryTrees;

namespace KataMachine;
public class CompareBinaryTreeTests
{
    [Fact]
    public void ComparyBinaryTreesTest()
    {
        Assert.True(CompareBinaryTrees.Compare(Utilities.GenerateTree1(), Utilities.GenerateTree1()));
        Assert.False(CompareBinaryTrees.Compare(Utilities.GenerateTree1(), Utilities.GenerateTree2()));
    }
}
