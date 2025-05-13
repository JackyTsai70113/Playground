namespace playground.UnitTest.LeetCode._3000_3999;

public class _3296_MinNumberOfSecondsTest
{
    [Theory]
    [InlineData(4, new int[] { 2, 1, 1 }, 3)]
    [InlineData(10, new int[] { 3, 2, 2, 4 }, 12)]
    [InlineData(5, new int[] { 1 }, 15)]
    [InlineData(1, new int[] { 3, 5 }, 3)]
    [InlineData(90, new int[] { 1, 16, 19, 74, 97, 95, 9, 2, 23, 67 }, 495)]
    [InlineData(99, new int[] { 1, 57 }, 3916)]
    public void MinNumberOfSeconds(int h, int[] workerTimes, long expected)
    {
        var actual = _3296_MinNumberOfSeconds.MinNumberOfSeconds(h, workerTimes);
        Assert.Equal(expected, actual);
    }
}
