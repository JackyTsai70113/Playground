namespace playground.UnitTest.LeetCode._3000_3999;

public class _3015_CountOfPairsTest
{
    [Theory]
    [InlineData(3, 1, 3, "[6,0,0]")]
    [InlineData(5, 2, 4, "[10,8,2,0,0]")]
    [InlineData(4, 1, 1, "[6,4,2,0]")]
    public void CountOfPairs(int n, int x, int y, string expected)
    {
        var actual = _3015_CountOfPairs.CountOfPairs(n, x, y);
        Assert.Equal(expected.ToArr(), actual);
    }
}
