namespace playground.UnitTest;

public class _1137_TribonacciTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(4, 4)]
    [InlineData(25, 1389537)]
    [InlineData(31, 53798080)]
    public void Tribonacci(int n, int expected)
    {
        var actual = _1137_Tribonacci.Tribonacci(n);
        Assert.Equal(expected, actual);
    }
}
