namespace playground.UnitTest;

public class FindKthNumberTest0440
{
    [Theory]
    [InlineData(13, 2, 10)]
    [InlineData(1, 1, 1)]
    [InlineData(681692778, 351251360, 416126219)]
    public void FindKthNumber(int n, int k, int expected)
    {
        var actual = FindKthNumber0440.FindKthNumber(n, k);
        Assert.Equal(expected, actual);
    }
}
