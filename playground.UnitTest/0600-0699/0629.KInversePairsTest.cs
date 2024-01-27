namespace playground.UnitTest;

public class KInversePairsTest0629
{
    [Theory]
    [InlineData(3, 0, 1)]
    [InlineData(3, 1, 2)]
    [InlineData(4, 4, 5)]
    [InlineData(4, 6, 1)]
    [InlineData(4, 7, 0)]
    [InlineData(1000, 1000, 663677020)]
    public void KInversePairs(int n, int k, int expected)
    {
        var actual = KInversePairs0629.KInversePairs(n, k);
        Assert.Equal(expected, actual);
    }
}
