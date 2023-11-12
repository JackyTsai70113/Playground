namespace playground.UnitTest;

public class StringCountTest
{
    [Theory]
    [InlineData(4, 12)]
    [InlineData(5, 1460)]
    [InlineData(10, 83943898)]
    public void StringCount(int n, int expected)
    {
        var actual = StringCountClass.StringCount(n);
        Assert.Equal(expected, actual);
    }
}
