using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1155_NumRollsToTargetTest
{
    [Theory]
    [InlineData(1, 6, 3, 1)]
    [InlineData(2, 6, 7, 6)]
    [InlineData(3, 6, 7, 15)]
    [InlineData(30, 30, 500, 222616187)]
    public void NumRollsToTarget(int n, int k, int target, int expected)
    {
        var actual = _1155_NumRollsToTarget.NumRollsToTarget(n, k, target);
        Assert.Equal(expected, actual);
    }
}
