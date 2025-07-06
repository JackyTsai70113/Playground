using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3604_MinTimeTest
{
    [Theory]
    [InlineData(3, "[[0,1,0,1],[1,2,2,5]]", 3)]
    [InlineData(4, "[[0,1,0,3],[1,3,7,8],[0,2,1,5],[2,3,4,7]]", 5)]
    [InlineData(3, "[[1,0,1,3],[1,2,3,5]]", -1)]
    public void MinTime(int n, string edges, int expected)
    {
        var actual = _3604_MinTime.MinTime(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
