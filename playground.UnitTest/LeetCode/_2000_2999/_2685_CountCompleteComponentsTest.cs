using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2685_CountCompleteComponentsTest
{
    [Theory]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4],[3,5]]", 1)]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4]]", 3)]
    [InlineData(4, "[[1,2],[1,0],[3,1]]", 0)]
    [InlineData(2, "[[1,0]]", 1)]
    [InlineData(4, "[[0,1],[0,2],[1,2]]", 2)]
    public void CountCompleteComponents(int n, string edges, int expected)
    {
        var actual = _2685_CountCompleteComponents.CountCompleteComponents(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
