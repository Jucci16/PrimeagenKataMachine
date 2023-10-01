using Core.DepthFirstSearchOnBinaryTree;

namespace KataMachine;
public class DeapthFirstSearchOnBinaryTreeTests
{
    [Fact]
    public void TestDepthFirstSearchOnBinaryTree()
    {
        var tree = Utilities.GenerateTree1();
        Assert.True(DepthFirstSearchOnBinaryTree.Search(tree, 45));
        Assert.True(DepthFirstSearchOnBinaryTree.Search(tree, 7));
        Assert.True(DepthFirstSearchOnBinaryTree.Search(tree, 69));
    }
}
