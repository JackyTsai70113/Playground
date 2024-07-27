namespace playground.UnitTest;

public class MinChangesTest3226
{
    [Theory]
    [InlineData(13, 4, 2)]
    [InlineData(21, 21, 0)]
    [InlineData(14, 13, -1)]
    public void MinChanges(int n, int k, int expected)
    {
        var actual = new MinChanges3226().MinChanges(n, k);
        Assert.Equal(expected, actual);
    }
}
