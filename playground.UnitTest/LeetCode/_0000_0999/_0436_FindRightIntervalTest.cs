using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0436_FindRightIntervalTest
{
    [Theory]
    [InlineData("[[1,2]]", "[-1]")]
    [InlineData("[[3,4],[2,3],[1,2]]", "[-1,0,1]")]
    [InlineData("[[1,4],[2,3],[3,4]]", "[-1,2,-1]")]
    public void FindRightInterval(string intervals, string expected)
    {
        var actual = _0436_FindRightInterval.FindRightInterval(intervals.To2dArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
