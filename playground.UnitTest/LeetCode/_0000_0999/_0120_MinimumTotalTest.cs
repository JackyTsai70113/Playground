using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0120_MinimumTotalTest
{
    [Theory]
    [InlineData("[[2],[3,4],[6,5,7],[4,1,8,3]]", 11)]
    [InlineData("[[-10]]", -10)]
    [InlineData("[[-1],[3,2],[-3,1,-1]]", -1)]
    public void MinimumTotal(string A, int expected)
    {
        var actual = _0120_MinimumTotal.MinimumTotal(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
