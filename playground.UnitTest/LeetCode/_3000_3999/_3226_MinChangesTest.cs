namespace playground.UnitTest.LeetCode._3000_3999;

public class _3226_MinChangesTest
{
    [Theory]
    [InlineData(13, 4, 2)]
    [InlineData(21, 21, 0)]
    [InlineData(14, 13, -1)]
    public void MinChanges(int n, int k, int expected)
    {
        var actual = new _3226_MinChanges().MinChanges(n, k);
        Assert.Equal(expected, actual);
    }
}
