namespace playground.UnitTest;

public class ReverseTest0007
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(1534236469, 0)]
    public void CountPrimes(int n, int expected)
    {
        var actual = Reverse0007.Reverse(n);
        Assert.Equal(expected, actual);
    }
}
