using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class NumWaysTest
{
    [Theory]
    [InlineData(3, 2, 4)]
    [InlineData(2, 4, 2)]
    [InlineData(4, 2, 8)]
    public void NumWays(int steps, int n, int expected)
    {
        var actual = NumWaysClass.NumWays(steps, n);
        Assert.Equal(expected, actual);
    }
}
