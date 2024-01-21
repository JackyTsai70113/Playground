namespace playground.UnitTest;

public class CountOfPairsTest3015
{
    [Theory]
    [InlineData(3, 1, 3, "[6,0,0]")]
    [InlineData(5, 2, 4, "[10,8,2,0,0]")]
    [InlineData(4, 1, 1, "[6,4,2,0]")]
    public void CountOfPairs(int n, int x, int y, string expected)
    {
        var actual = CountOfPairs3015.CountOfPairs(n, x, y);
        Assert.Equal(expected.ToArr(), actual);
    }
}
