namespace playground.UnitTest;

public class MinimumOneBitOperationsTest
{
    [Theory]
    [InlineData(3, 2)]
    [InlineData(6, 4)]
    public void MinimumOneBitOperations(int n, int expected)
    {
        var actual = MinimumOneBitOperations_1611.MinimumOneBitOperations(n);
        Assert.Equal(expected, actual);
    }
}
