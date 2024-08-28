namespace playground.UnitTest;

public class NumberOfPatternsTest0351
{
    [Theory]
    [InlineData(1, 1, 9)]
    [InlineData(1, 2, 65)]
    public void NumberOfPatterns(int m, int n, int expected)
    {
        var actual = NumberOfPatterns0351.NumberOfPatterns(m, n);
        Assert.Equal(expected, actual);
    }
}
