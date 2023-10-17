using playground.UnionFinds;

namespace playground.UnitTest.UnionFind;

public class ValidateBinaryTreeNodesTest
{
    [Theory]
    [InlineData(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, -1, -1, -1 }, true)]
    [InlineData(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, 3, -1, -1 }, false)]
    [InlineData(2, new int[] { 1, 0 }, new int[] { -1, -1 }, false)]
    [InlineData(3, new int[] { 1, -1, -1 }, new int[] { 2, -1, 0 }, false)]
    [InlineData(3, new int[] { 1, -1, -1 }, new int[] { -1, -1, 1 }, false)]
    [InlineData(3, new int[] { 1, -1, -1 }, new int[] { 2, 2, -1 }, false)]
    public void ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild, bool expected)
    {
        var actual = ValidateBinaryTreeNodesClass.ValidateBinaryTreeNodes(n, leftChild, rightChild);
        Assert.Equal(expected, actual);
    }
}
