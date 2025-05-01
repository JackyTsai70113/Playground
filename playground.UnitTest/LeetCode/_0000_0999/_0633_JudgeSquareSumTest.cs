using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0633_JudgeSquareSumTest
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(3, false)]
    [InlineData(5, true)]
    [InlineData(2000000000, true)]
    [InlineData(2147483646, false)]
    public void JudgeSquareSum(int c, bool expected)
    {
        var actual = _0633_JudgeSquareSum.JudgeSquareSum(c);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, true)]
    [InlineData(3, false)]
    [InlineData(5, true)]
    [InlineData(2000000000, true)]
    [InlineData(2147483646, false)]
    public void JudgeSquareSum2(int c, bool expected)
    {
        var actual = _0633_JudgeSquareSum.JudgeSquareSum2(c);
        Assert.Equal(expected, actual);
    }
}
