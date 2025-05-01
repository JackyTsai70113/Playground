using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0322_CoinChangeTest
{
    [Theory]
    [InlineData("[1,2,5]", 11, 3)]
    [InlineData("[2]", 3, -1)]
    [InlineData("[1]", 0, 0)]
    public void CoinChange(string coins, int amount, int expected)
    {
        var actual = _0322_CoinChange.CoinChange(coins.ToArr(), amount);
        Assert.Equal(expected, actual);
    }
}
