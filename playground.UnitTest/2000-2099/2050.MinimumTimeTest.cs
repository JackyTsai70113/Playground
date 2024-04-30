namespace playground.UnitTest;

public class MinimumTimeTest2050
{
    [Theory]
    [InlineData(3, "[[1,3],[2,3]]", new int[] { 3, 2, 5 }, 8)]
    [InlineData(5, "[[1,5],[2,5],[3,5],[3,4],[4,5]]", new int[] { 1, 2, 3, 4, 5 }, 12)]
    [InlineData(5, "[[1,5],[2,5],[3,4]]", new int[] { 1, 2, 3, 4, 5 }, 7)]
    public void MinimumTime(int n, string relations, int[] time, int expected)
    {
        var actual = MinimumTime2050.MinimumTime(n, relations.To2dArr(), time);
        Assert.Equal(expected, actual);
    }
}
