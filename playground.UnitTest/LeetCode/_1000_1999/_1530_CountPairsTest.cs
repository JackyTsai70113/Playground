namespace playground.UnitTest.LeetCode._1000_1999;

public class _1530_CountPairsTest
{
    [Theory]
    [InlineData("[1,2,3,null,4]", 3, 1)]
    [InlineData("[1,2,3,4,5,6,7]", 3, 2)]
    [InlineData("[7,1,4,6,null,5,3,null,null,null,null,null,2]", 3, 1)]
    public void CreateBinaryTree(string root, int distance, int expected)
    {
        var actual = new _1530_CountPairs().CountPairs(root.ToTreeNode(), distance);
        Assert.Equal(expected, actual);
    }
}
