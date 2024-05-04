namespace playground.UnitTest;

public class FirstBadVersionTest0278
{
    [Theory]
    [InlineData(5, 4, 4)]
    [InlineData(1, 1, 1)]
    public void FirstBadVersion(int n, int bad, int expected)
    {
        var actual = new FirstBadVersion0278().FirstBadVersion(n, bad);
        Assert.Equal(expected, actual);
    }
}
