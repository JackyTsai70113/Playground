using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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