using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0475_FindRadiusTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 2 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4 }, 1)]
    [InlineData(new int[] { 1, 5 }, new int[] { 2 }, 3)]
    public void FindRadius(int[] houses, int[] heaters, int expected)
    {
        var actual = _0475_FindRadius.FindRadius(houses, heaters);
        Assert.Equal(expected, actual);
    }
}
