using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3376_FindMinimumTimeTest
{
    [Theory]
    [InlineData(new int[] { 3, 4, 1 }, 1, 4)]
    [InlineData(new int[] { 2, 5, 4 }, 2, 5)]
    public void FindMinimumTime(IList<int> strength, int k, int expected)
    {
        var actual = _3376_FindMinimumTime.FindMinimumTime(strength, k);
        Assert.Equal(expected, actual);
    }
}