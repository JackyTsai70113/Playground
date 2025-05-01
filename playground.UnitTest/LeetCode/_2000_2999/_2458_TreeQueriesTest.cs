using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2458_TreeQueriesTest
{
    [Theory]
    [InlineData("[1,3,4,2,null,6,5,null,null,null,null,null,7]", new int[] { 4 }, new int[] { 2 })]
    [InlineData("[1,3,4,2]", new int[] { 4 }, new int[] { 2 })]
    [InlineData("[5,8,9,2,1,3,7,4,6]", new int[] { 3, 2, 4, 8 }, new int[] { 3, 2, 3, 2 })]
    [InlineData("[1,3,null]", new int[] { 3 }, new int[] { 0 })]
    public void TreeQueries(string root, int[] queries, int[] expected)
    {
        var actual = new _2458_TreeQueries().TreeQueries(root.ToTreeNode(), queries);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[1,3,4,2,null,6,5,null,null,null,null,null,7]", new int[] { 4 }, new int[] { 2 })]
    [InlineData("[1,3,4,2]", new int[] { 4 }, new int[] { 2 })]
    [InlineData("[5,8,9,2,1,3,7,4,6]", new int[] { 3, 2, 4, 8 }, new int[] { 3, 2, 3, 2 })]
    [InlineData("[1,3,null]", new int[] { 3 }, new int[] { 0 })]
    public void TreeQueries2(string root, int[] queries, int[] expected)
    {
        var actual = new _2458_TreeQueries().TreeQueries2(root.ToTreeNode(), queries);
        Assert.Equal(expected, actual);
    }
}
