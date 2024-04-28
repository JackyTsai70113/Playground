namespace playground.UnitTest;

public class MinEndTest3133
{
    [Theory]
    [InlineData(3, 4, 6)]
    [InlineData(2, 7, 15)]
    [InlineData(22, 4, 45)]
    [InlineData(6715154, 7193485, 55012476815)]
    public void MinEnd(int n, int x, long expected)
    {
        var actual = MinEnd3133.MinEnd(n, x);
        Assert.Equal(expected, actual);
    }
}