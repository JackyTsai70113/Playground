namespace playground.UnitTest;

public class _1492_KthFactorTest
{
    [Theory]
    [InlineData(12, 3, 3)]
    [InlineData(7, 2, 7)]
    [InlineData(4, 4, -1)]
    public void KthFactor(int n, int k, int expected)
    {
        var actual = _1492_KthFactor.KthFactor(n, k);
        Assert.Equal(expected, actual);
    }
}
