namespace playground.UnitTest;

public class TrailingZeroesTest0172
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(3, 0)]
    [InlineData(5, 1)]
    [InlineData(30, 7)]
    [InlineData(10000, 2499)]
    public void TrailingZeroes(int n, int expected)
    {
        var actual = TrailingZeroes0172.TrailingZeroes(n);
        Assert.Equal(expected, actual);
    }
}
