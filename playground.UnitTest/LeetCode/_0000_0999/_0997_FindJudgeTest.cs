using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0997_FindJudgeTest
{
    [Theory]
    [InlineData(2, "[[1,2]]", 2)]
    [InlineData(3, "[[1,3],[2,3]]", 3)]
    [InlineData(3, "[[1,3],[2,3],[3,1]]", -1)]
    public void FindJudge(int n, string trust, int expected)
    {
        var actual = _0997_FindJudge.FindJudge(n, trust.To2dArr());
        Assert.Equal(expected, actual);
    }
}
