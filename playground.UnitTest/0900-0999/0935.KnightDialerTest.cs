namespace playground.UnitTest;

public class KnightDialerTest_0935
{
    [Theory]
    [InlineData(1, 10)]
    [InlineData(2, 20)]
    [InlineData(3131, 136006598)]
    public void KnightDialer(int n, int expected)
    {
        var actual = KnightDialer_0935.KnightDialer(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 10)]
    [InlineData(2, 20)]
    [InlineData(3131, 136006598)]
    public void KnightDialer2(int n, int expected)
    {
        var actual = KnightDialer_0935.KnightDialer2(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 10)]
    [InlineData(2, 20)]
    [InlineData(3131, 136006598)]
    public void KnightDialer3(int n, int expected)
    {
        var actual = KnightDialer_0935.KnightDialer3(n);
        Assert.Equal(expected, actual);
    }
}
