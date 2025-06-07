using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1376_NumOfMinutesTest
{
    [Theory]
    [InlineData(1, 0, new int[] { -1 }, new int[] { 0 }, 0)]
    [InlineData(6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 }, 1)]
    [InlineData(7, 1, new int[] { 1, -1, 1, 0, 0, 2, 2 }, new int[] { 3, 4, 5, 0, 0, 0, 0 }, 9)]
    public void NumOfMinutes(int n, int headID, int[] manager, int[] informTime, int expected)
    {
        var actual = _1376_NumOfMinutes.NumOfMinutes(n, headID, manager, informTime);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0, new int[] { -1 }, new int[] { 0 }, 0)]
    [InlineData(6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 }, 1)]
    [InlineData(7, 1, new int[] { 1, -1, 1, 0, 0, 2, 2 }, new int[] { 3, 4, 5, 0, 0, 0, 0 }, 9)]
    public void NumOfMinutes2(int n, int headID, int[] manager, int[] informTime, int expected)
    {
        var actual = _1376_NumOfMinutes.NumOfMinutes2(n, headID, manager, informTime);
        Assert.Equal(expected, actual);
    }
}
