namespace playground.UnitTest;

public class MinNonZeroProductTest1969
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(2, 6)]
    [InlineData(3, 1512)]
    [InlineData(31, 138191773)]
    [InlineData(32, 505517599)]
    [InlineData(33, 861896614)]
    [InlineData(34, 640964173)]
    [InlineData(60, 813987236)]
    public void MinNonZeroProduct(int p, int expected)
    {
        var actual = MinNonZeroProduct1969.MinNonZeroProduct(p);
        Assert.Equal(expected, actual);
        actual = MinNonZeroProduct1969.MinNonZeroProduct2(p);
        Assert.Equal(expected, actual);
    }
}
