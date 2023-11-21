namespace playground.UnitTest;

public class CircularGameLosersTest_2682
{
    [Theory]
    [InlineData(5, 2, "[4,5]")]
    [InlineData(4, 4, "[2, 3, 4]")]
    public void CircularGameLosers(int n, int k, string expected)
    {
        var actual = CircularGameLosers_2682.CircularGameLosers(n, k);
        Assert.Equal(expected.ToArr(), actual);
    }
}
