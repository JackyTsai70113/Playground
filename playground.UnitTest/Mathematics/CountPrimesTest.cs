using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class CountPrimesTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(2, 0)]
    [InlineData(10, 4)]
    [InlineData(11, 4)]
    public void CountPrimes(int n, int expected)
    {
        var actual = CountPrimesClass.CountPrimes(n);
        Assert.Equal(expected, actual);
    }
}
