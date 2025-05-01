using playground._1900_1999;

namespace playground.UnitTest._1900_1999;

public class _1976_CountPathsTest
{
    [Theory]
    [InlineData(1, "[]", 1)]
    [InlineData(7, "[[0,6,7],[0,1,2],[1,2,3],[1,3,3],[6,3,3],[3,5,1],[6,5,1],[2,5,1],[0,4,5],[4,6,2]]", 4)]
    [InlineData(2, "[[1,0,10]]", 1)]
    [InlineData(5, "[[0,1,1],[1,2,4],[0,4,3],[3,2,5],[3,4,1],[3,0,5],[1,3,1]]", 2)]
    public void CountPaths(int n, string roads, int expected)
    {
        var actual = _1976_CountPaths_cs.CountPaths(n, roads.To2dArr());
        Assert.Equal(expected, actual);
    }
}