namespace playground.UnitTest;

public class MagicalStringTest0481
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(6, 3)]
    [InlineData(8, 4)]
    [InlineData(100000, 49972)]
    public void MagicalString(int n, int expected)
    {
        var actual = MagicalString0481.MagicalString(n);
        Assert.Equal(expected, actual);
    }
}
