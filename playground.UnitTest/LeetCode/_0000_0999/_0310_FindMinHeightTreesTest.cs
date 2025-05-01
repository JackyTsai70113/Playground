using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0310_FindMinHeightTreesTest
{
    [Theory]
    [InlineData(1, "[[]]", new int[] { 0 })]
    [InlineData(2, "[[0, 1]]", new int[] { 0, 1 })]
    [InlineData(4, "[[1, 0], [1, 2], [1, 3]]", new int[] { 1 })]
    [InlineData(6, "[[3, 0], [3, 1], [3, 2], [3, 4], [5, 4]]", new int[] { 3, 4 })]
    [InlineData(4, "[[0, 1], [1, 2], [2, 3]]", new int[] { 1, 2 })]
    public void FindMinHeightTrees(int n, string edges, int[] expected)
    {
        IList<int> actual = _0310_FindMinHeightTrees.FindMinHeightTrees(n, edges.To2dArr());
        Assert.Equal(expected, actual.ToArray());
    }
}