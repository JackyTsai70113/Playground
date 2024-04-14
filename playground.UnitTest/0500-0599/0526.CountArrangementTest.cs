namespace playground.UnitTest;

public class CountArrangementTest0526
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(1, 1)]
    public void CountArrangement(int n, int expected)
    {
        var actual = CountArrangement0526.CountArrangement(n);
        Assert.Equal(expected, actual);
    }
}
