namespace playground.UnitTest;

public class FindPathsTest0576
{
    [Theory]
    [InlineData(2, 2, 2, 0, 0, 6)]
    [InlineData(1, 3, 3, 0, 1, 12)]
    public void FindPaths(int m, int n, int maxMove, int r, int c, int expected)
    {
        var actual = FindPaths0576.FindPaths(m, n, maxMove, r, c);
        Assert.Equal(expected, actual);
    }
}
