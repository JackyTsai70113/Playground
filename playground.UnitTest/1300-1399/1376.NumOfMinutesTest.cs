namespace playground.UnitTest;

public class NumOfMinutesTest1376
{
    [Theory]
    [InlineData(1, 0, new int[] { -1 }, new int[] { 0 }, 0)]
    [InlineData(6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 }, 1)]
    [InlineData(7, 1, new int[] { 1, -1, 1, 0, 0, 2, 2 }, new int[] { 3, 4, 5, 0, 0, 0, 0 }, 9)]
    public void NumOfMinutes(int n, int headID, int[] manager, int[] informTime, int expected)
    {
        var actual = NumOfMinutes1376.NumOfMinutes(n, headID, manager, informTime);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0, new int[] { -1 }, new int[] { 0 }, 0)]
    [InlineData(6, 2, new int[] { 2, 2, -1, 2, 2, 2 }, new int[] { 0, 0, 1, 0, 0, 0 }, 1)]
    [InlineData(7, 1, new int[] { 1, -1, 1, 0, 0, 2, 2 }, new int[] { 3, 4, 5, 0, 0, 0, 0 }, 9)]
    public void NumOfMinutes2(int n, int headID, int[] manager, int[] informTime, int expected)
    {
        var actual = NumOfMinutes1376.NumOfMinutes2(n, headID, manager, informTime);
        Assert.Equal(expected, actual);
    }
}
