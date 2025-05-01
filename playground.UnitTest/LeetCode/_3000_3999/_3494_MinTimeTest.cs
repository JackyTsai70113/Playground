using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

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
