using Core.BreadthFirstSearchOnBinaryTree;

namespace KataMachine;
public class BredthFirstSearchOnBinaryTreeTests
{
    [Fact]
    public void TestBredthFirstSearchOnBinaryTree()
    {
        var tree = Utilities.GenerateTree1();
        Assert.True(BredthFirstSearchOnBinaryTree.Search(tree, 45));
        Assert.True(BredthFirstSearchOnBinaryTree.Search(tree, 7));
        Assert.True(BredthFirstSearchOnBinaryTree.Search(tree, 69));
    }
}
