namespace playground.UnitTest;

public class ArrangeCoinsTest0441
{
    [Theory]
    [InlineData(5, 2)]
    [InlineData(8, 3)]
    [InlineData(1804289383, 60070)]
    public void ArrangeCoins(int n, int expected)
    {
        var actual = ArrangeCoins0441.ArrangeCoins(n);
        Assert.Equal(expected, actual);
    }
}
