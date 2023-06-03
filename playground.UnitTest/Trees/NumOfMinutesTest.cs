using playground.Trees;

namespace playground.UnitTest.Trees;

public class NumOfMinutesTest
{
    [Theory]
    [InlineData(1, 0, new int[] { -1 }, new int[] { 0 }, 0)]
    [InlineData(6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 }, 1)]
    [InlineData(7, 1, new int[] { 1, -1, 1, 0, 0, 2, 2 }, new int[] { 3, 4, 5, 0, 0, 0, 0 }, 9)]
    public void NumOfMinutes(int n, int headID, int[] manager, int[] informTime, int expected)
    {
        var actual = NumOfMinutesClass.NumOfMinutes(n, headID, manager, informTime);
        Assert.Equal(expected, actual);
    }
}
