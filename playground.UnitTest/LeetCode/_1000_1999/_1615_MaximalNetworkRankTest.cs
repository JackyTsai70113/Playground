using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1615_MaximalNetworkRankTest
{
    [Theory]
    [InlineData(4, "[[0,1],[0,3],[1,2],[1,3]]", 4)]
    [InlineData(5, "[[0,1],[0,3],[1,2],[1,3],[2,3],[2,4]]", 5)]
    [InlineData(8, "[[0,1],[1,2],[2,3],[2,4],[5,6],[5,7]]", 5)]
    public void MaximalNetworkRank(int n, string roads, int expected)
    {
        var actual = _1615_MaximalNetworkRank.MaximalNetworkRank(n, roads.To2dArr());
        Assert.Equal(expected, actual);
    }
}
