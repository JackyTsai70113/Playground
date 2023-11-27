namespace playground.UnitTest;

public class MinimumCoinsTest
{
    [Theory]
    [InlineData("[3,1,2]", 4)]
    [InlineData("[1,10,1,1]", 2)]
    public void MinimumCoins(string A, int expected)
    {
        var actual = MinimumCoins_2944.MinimumCoins(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
