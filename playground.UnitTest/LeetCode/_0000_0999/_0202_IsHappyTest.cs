using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0202_IsHappyTest
{
    [Theory]
    [InlineData(19, true)]
    [InlineData(1, true)]
    [InlineData(7, true)]
    [InlineData(2, false)]
    public void IsHappy(int n, bool expected)
    {
        var actual = _0202_IsHappy.IsHappy(n);
        Assert.Equal(expected, actual);
    }
}
