namespace playground.UnitTest;

public class JudgeSquareSumTest0633
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(3, false)]
    [InlineData(5, true)]
    [InlineData(2000000000, true)]
    [InlineData(2147483646, false)]
    public void JudgeSquareSum(int c, bool expected)
    {
        var actual = JudgeSquareSum0633.JudgeSquareSum(c);
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
        var actual = JudgeSquareSum0633.JudgeSquareSum2(c);
        Assert.Equal(expected, actual);
    }
}
