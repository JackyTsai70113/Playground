namespace playground.UnitTest;

public class CoinChangeTest0322
{
    [Theory]
    [InlineData("[1,2,5]", 11, 3)]
    [InlineData("[2]", 3, -1)]
    [InlineData("[1]", 0, 0)]
    public void CoinChange(string coins, int amount, int expected)
    {
        var actual = CoinChange0322.CoinChange(coins.ToArr(), amount);
        Assert.Equal(expected, actual);
    }
}
