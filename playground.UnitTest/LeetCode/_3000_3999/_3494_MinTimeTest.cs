using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3494_MinTimeTest
{
    [Theory]
    [InlineData(new int[] { 1, 5, 2, 4 }, new int[] { 5, 1, 4, 2 }, 110)]
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 }, 21)]
    public void MinTime(int[] skill, int[] mana, long expected)
    {
        var actual = _3494_MinTime.MinTime(skill, mana);
        Assert.Equal(expected, actual);
    }
}
