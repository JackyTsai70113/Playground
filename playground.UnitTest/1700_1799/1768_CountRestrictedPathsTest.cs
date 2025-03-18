using playground._1700_1799;

namespace playground.UnitTest._1700_1799;

public class _1768_CountRestrictedPathsTest
{
    [Theory]
    [InlineData(5, "[[1,2,3],[1,3,3],[2,3,1],[1,4,2],[5,2,2],[3,5,1],[5,4,10]]", 3)]
    [InlineData(7, "[[1,3,1],[4,1,2],[7,3,4],[2,5,3],[5,6,1],[6,7,2],[7,5,3],[2,6,4]]", 1)]
    public void CountRestrictedPaths(int n, string edges, int expected)
    {
        var actual = _1768_CountRestrictedPaths.CountRestrictedPaths(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
