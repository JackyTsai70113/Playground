using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2257_CountUnguardedTest
{
    [Theory]
    [InlineData(4, 6, "[[0,0],[1,1],[2,3]]", "[[0,1],[2,2],[1,4]]", 7)]
    [InlineData(3, 3, "[[1,1]]", "[[0,1],[1,0],[2,1],[1,2]]", 4)]
    public void CountUnguarded(int m, int n, string guards, string walls, int expected)
    {
        var actual = _2257_CountUnguarded.CountUnguarded(m, n, guards.To2dArr(), walls.To2dArr());
        Assert.Equal(expected, expected);
    }
}
