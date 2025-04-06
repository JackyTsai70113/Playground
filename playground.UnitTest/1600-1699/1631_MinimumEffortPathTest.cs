using playground._1600_1699;

namespace playground.UnitTest._1600_1699;

public class _1631_MinimumEffortPathTest
{
    [Theory]
    [InlineData("[[1,2,2],[3,8,2],[5,3,5]]", 2)]
    [InlineData("[[1,2,3],[3,8,4],[5,3,5]]", 1)]
    [InlineData("[[1,2,1,1,1],[1,2,1,2,1],[1,2,1,2,1],[1,2,1,2,1],[1,1,1,2,1]]", 0)]
    public void MinimumEffortPath(string A, int expected)
    {
        var actual = _1631_MinimumEffortPath.MinimumEffortPath(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
