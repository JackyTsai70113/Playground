namespace playground.UnitTest;

public class CountPrimesTest0204
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(2, 0)]
    [InlineData(10, 4)]
    [InlineData(11, 4)]
    [InlineData(5000000, 348513)]
    public void CountPrimes(int n, int expected)
    {
        var actual = CountPrimes0204.CountPrimes(n);
        Assert.Equal(expected, actual);
    }
}
