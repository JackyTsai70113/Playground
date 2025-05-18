using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3439_MaxFreeTimeTest
{
    [Theory]
    [InlineData(5, 1, new[] { 1, 3 }, new[] { 2, 5 }, 2)]
    [InlineData(5, 2, new[] { 1, 3 }, new[] { 2, 5 }, 2)]
    [InlineData(10, 1, new[] { 0, 2, 9 }, new[] { 1, 4, 10 }, 6)]
    [InlineData(5, 2, new[] { 0, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 }, 0)]
    public void MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime, int expected)
    {
        var result = _3439_MaxFreeTime.MaxFreeTime(eventTime, k, startTime, endTime);
        Assert.Equal(expected, result);
    }
}
