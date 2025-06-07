using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1298_MaxCandiesTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0 }, new int[] { 7, 5, 4, 100 }, "[[],[],[1],[]]", "[[1,2],[3],[],[]]", new int[] { 0 }, 16)]
    [InlineData(new int[] { 1, 0, 0, 0, 0, 0 }, new int[] { 1, 1, 1, 1, 1, 1 }, "[[1,2,3,4,5],[],[],[],[],[]]", "[[1,2,3,4,5],[],[],[],[],[]]", new int[] { 0 }, 6)]
    [InlineData(new int[] { 0, 1 }, new int[] { 3, 5 }, "[[],[0]]", "[[],[]]", new int[] { 0, 1 }, 8)]
    [InlineData(new int[] { 0, 1 }, new int[] { 3, 5 }, "[[1],[]]", "[[],[0]]", new int[] { 1 }, 5)]
    public void MaxCandies(int[] status, int[] candies, string keys, string containedBoxes, int[] initialBoxes, int expected)
    {
        var actual = _1298_MaxCandies.MaxCandies(status, candies, keys.To2dArr(), containedBoxes.To2dArr(), initialBoxes);
        Assert.Equal(expected, actual);
    }
}