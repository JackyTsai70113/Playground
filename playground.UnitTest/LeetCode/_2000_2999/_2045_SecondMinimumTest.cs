using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2045_SecondMinimumTest
{
    [Theory]
    [InlineData(5, "[[1,2],[1,3],[1,4],[3,4],[4,5]]", 3, 5, 13)]
    [InlineData(2, "[[1,2]]", 3, 2, 11)]
    public void SecondMinimum(int n, string edges, int time, int change, int expected)
    {
        var actual = _2045_SecondMinimum.SecondMinimum(n, edges.To2dArr(), time, change);
        Assert.Equal(expected, actual);
    }
}
