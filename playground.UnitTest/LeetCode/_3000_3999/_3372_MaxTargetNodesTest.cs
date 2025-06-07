using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3372_MaxTargetNodesTest
{
    [Theory]
    [InlineData("[[0,1],[0,2],[2,3],[2,4]]", "[[0,1],[0,2],[0,3],[2,7],[1,4],[4,5],[4,6]]", 2, new int[] { 9, 7, 9, 8, 8 })]
    [InlineData("[[0,1],[0,2],[0,3],[0,4]]", "[[0,1],[1,2],[2,3]]", 1, new int[] { 6, 3, 3, 3, 3 })]
    [InlineData("[[0,1]]", "[[0,1]]", 0, new int[] { 1, 1 })]
    public void MaxTargetNodes(string edges1, string edges2, int k, int[] expected)
    {
        var actual = _3372_MaxTargetNodes.MaxTargetNodes(edges1.To2dArr(), edges2.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}