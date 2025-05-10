using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0518_ChangeTest
{
    [Theory]
    [InlineData(5, new int[] { 1, 2, 5 }, 4)]
    [InlineData(10, new int[] { 10 }, 1)]
    [InlineData(3, new int[] { 2 }, 0)]
    public void Test(int amount, int[] coins, int expected)
    {
        int actual = _0518_Change.Change(amount, coins);
        Assert.Equal(expected, actual);
        int actual2 = _0518_Change.Change_OptimizeSpace(amount, coins);
        Assert.Equal(expected, actual2);
    }
}
