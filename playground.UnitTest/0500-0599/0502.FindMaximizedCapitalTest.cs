namespace playground.UnitTest;

public class FindMaximizedCapitalTest0502
{
    [Theory]
    [InlineData(2, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 1 }, 4)]
    [InlineData(3, 0, new int[] { 1, 2, 3 }, new int[] { 0, 1, 2 }, 6)]
    public void FindMaximizedCapital(int k, int w, int[] ps, int[] cs, int expected)
    {
        var actual = FindMaximizedCapital0502.FindMaximizedCapital(k, w, ps, cs);
        Assert.Equal(expected, actual);
    }
}
