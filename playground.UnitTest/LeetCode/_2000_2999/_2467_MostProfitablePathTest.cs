using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2467_MostProfitablePathTest
{
    [Theory]
    [InlineData("[[0,1],[1,2],[1,3],[3,4]]", 3, new int[] { -2, 4, 2, -4, 6 }, 6)]
    [InlineData("[[0,1]]", 1, new int[] { -7280, 2350 }, -7280)]
    public void MostProfitablePath(string edges, int bob, int[] amount, int expected)
    {
        var actual = _2467_MostProfitablePath.MostProfitablePath(edges.To2dArr(), bob, amount);
        Assert.Equal(expected, actual);
    }
}
