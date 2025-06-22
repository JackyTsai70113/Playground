using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3592_FindCoinsTest
{
    [Theory]
    [InlineData(new[] { 1, 0 }, new int[0])]
    [InlineData(new[] { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 }, new[] { 2, 4, 6 })]
    [InlineData(new[] { 1, 2, 2, 3, 4 }, new[] { 1, 2, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 15 }, new int[0])]
    public void FindCoins(int[] numWays, IList<int> expected)
    {
        var actual = _3592_FindCoins.FindCoins(numWays);
        Assert.Equal(expected, actual);
    }
}
