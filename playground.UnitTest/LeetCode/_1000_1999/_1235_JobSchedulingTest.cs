using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1235_JobSchedulingTest
{
    [Theory]
    [InlineData(
        new int[] { 1, 2, 3, 3 },
        new int[] { 3, 4, 5, 6 },
        new int[] { 50, 10, 40, 70 },
        120)]
    [InlineData(
        new int[] { 1, 2, 3, 4, 6 },
         new int[] { 3, 5, 10, 6, 9 },
         new int[] { 20, 20, 100, 70, 60 },
          150)]
    [InlineData(
        new int[] { 1, 1, 1 },
        new int[] { 2, 3, 4 },
        new int[] { 5, 6, 4 },
         6)]
    [InlineData(
        new int[] { 3, 5, 3, 7, 4 },
        new int[] { 10, 8, 8, 10, 9 },
        new int[] { 10, 8, 10, 9, 9 }, 10)]
    [InlineData(
        new int[] { 11, 13, 2, 40, 26, 6, 25, 21, 62, 45 },
        new int[] { 91, 76, 45, 56, 27, 99, 26, 26, 93, 52 },
        new int[] { 80, 31, 56, 80, 52, 57, 12, 59, 70, 4 },
         261)]
    public void JobScheduling(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var actual = _1235_JobScheduling.JobScheduling(startTime, endTime, profit);
        Assert.Equal(expected, actual);
    }
}
