using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0070_ClimbStairsTest
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(10, 89)]
    [InlineData(45, 1836311903)]
    public void ClimbStairs(int n, int expected)
    {
        var actual = _0070_ClimbStairs.ClimbStairs(n);
        Assert.Equal(expected, actual);
    }
}
