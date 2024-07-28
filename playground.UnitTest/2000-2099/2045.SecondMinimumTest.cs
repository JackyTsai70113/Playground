namespace playground.UnitTest;

public class SecondMinimumTest2045
{
    [Theory]
    [InlineData(5, "[[1,2],[1,3],[1,4],[3,4],[4,5]]", 3, 5, 13)]
    [InlineData(2, "[[1,2]]", 3, 2, 11)]
    public void SecondMinimum(int n, string edges, int time, int change, int expected)
    {
        var actual = SecondMinimum2045.SecondMinimum(n, edges.To2dArr(), time, change);
        Assert.Equal(expected, actual);
    }
}
