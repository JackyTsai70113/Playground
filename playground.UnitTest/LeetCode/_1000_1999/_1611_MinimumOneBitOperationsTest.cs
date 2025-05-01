namespace playground.UnitTest;

public class _1611_MinimumOneBitOperationsTest
{
    [Theory]
    [InlineData(3, 2)]
    [InlineData(6, 4)]
    public void MinimumOneBitOperations(int n, int expected)
    {
        var actual = _1611_MinimumOneBitOperations.MinimumOneBitOperations(n);
        Assert.Equal(expected, actual);
    }
}
