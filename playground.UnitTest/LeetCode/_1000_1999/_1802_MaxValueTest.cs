namespace playground.UnitTest;

public class _1802_MaxValueTest
{
    [Theory]
    [InlineData(4, 2, 6, 2)]
    [InlineData(4, 0, 4, 1)]
    [InlineData(3, 2, 18, 7)]
    [InlineData(6, 1, 10, 3)]
    [InlineData(8, 1, 10, 2)]
    [InlineData(4, 1, 100, 26)]
    [InlineData(3, 0, 815094800, 271698267)]
    public void MaxValue(int n, int index, int maxSum, int expected)
    {
        var actual = _1802_MaxValue.MaxValue(n, index, maxSum);
        Assert.Equal(expected, actual);
    }
}
