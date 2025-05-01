using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0650_MinStepsTest
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 7)]
    [InlineData(8, 6)]
    [InlineData(9, 6)]
    [InlineData(1000, 21)]
    public void MinSteps(int n, int expected)
    {
        var actual = _0650_MinSteps.MinSteps(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 7)]
    [InlineData(8, 6)]
    [InlineData(9, 6)]
    [InlineData(1000, 21)]
    public void MinSteps2(int n, int expected)
    {
        var actual = _0650_MinSteps.MinSteps2(n);
        Assert.Equal(expected, actual);
    }
}
