using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0834_SumOfDistancesInTreeTest
{
    [Theory]
    [InlineData(6, "[[0, 1], [0, 2], [2, 3], [2, 4], [2, 5]]", new int[] { 8, 12, 6, 10, 10, 10 })]
    [InlineData(1, "[]", new int[] { 0 })]
    [InlineData(2, "[[1,0]]", new int[] { 1, 1 })]
    public void SumOfDistancesInTree(int n, string edges, int[] expected)
    {
        var actual = _0834_SumOfDistancesInTree.SumOfDistancesInTree(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(6, "[[0, 1], [0, 2], [2, 3], [2, 4], [2, 5]]", new int[] { 8, 12, 6, 10, 10, 10 })]
    [InlineData(1, "[]", new int[] { 0 })]
    [InlineData(2, "[[1,0]]", new int[] { 1, 1 })]
    public void SumOfDistancesInTree2(int n, string edges, int[] expected)
    {
        var actual = _0834_SumOfDistancesInTree.SumOfDistancesInTree2(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
