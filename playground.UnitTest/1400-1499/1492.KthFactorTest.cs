namespace playground.UnitTest;

public class KthFactorTest1492
{
    [Theory]
    [InlineData(12, 3, 3)]
    [InlineData(7, 2, 7)]
    [InlineData(4, 4, -1)]
    public void KthFactor(int n, int k, int expected)
    {
        var actual = KthFactor1492.KthFactor(n, k);
        Assert.Equal(expected, actual);
    }
}
