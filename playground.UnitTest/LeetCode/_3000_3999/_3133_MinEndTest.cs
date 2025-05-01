namespace playground.UnitTest;

public class _3133_MinEndTest
{
    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(2, 7, 15)]
    [InlineData(22, 4, 45)]
    [InlineData(6715154, 7193485, 55012476815)]
    public void MinEnd(int n, int x, long expected)
    {
        var actual = _3133_MinEnd.MinEnd(n, x);
        Assert.Equal(expected, actual);
    }
}