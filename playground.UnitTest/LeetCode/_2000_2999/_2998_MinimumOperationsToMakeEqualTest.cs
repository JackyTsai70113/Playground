using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2998_MinimumOperationsToMakeEqualTest
{
    [Theory]
    [InlineData(26, 1, 3)]
    [InlineData(54, 2, 4)]
    [InlineData(25, 30, 5)]
    public void MinimumOperationsToMakeEqual(int x, int y, int expected)
    {
        var actual = _2998_MinimumOperationsToMakeEqual.MinimumOperationsToMakeEqual(x, y);
        Assert.Equal(expected, actual);
    }
}
