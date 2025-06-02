using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3567_MinAbsDiffTest
{
    [Theory]
    [InlineData("[[1,8],[3,-2]]", 2, "[[2]]")]
    [InlineData("[[3,-1]]", 1, "[[0,0]]")]
    [InlineData("[[1,-2,3],[2,3,5]]", 2, "[[1,2]]")]
    public void MinAbsDiff(string A, int k, string expected)
    {
        var actual = _3567_MinAbsDiff.MinAbsDiff(A.To2dArr(), k);
        Assert.Equal(expected.To2dArr(), actual);
    }
}