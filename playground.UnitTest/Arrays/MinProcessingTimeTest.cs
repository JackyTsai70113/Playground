using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MinProcessingTimeTest
{
    [Theory]
    [InlineData(new int[] { 8, 10 }, new int[] { 2, 2, 3, 1, 8, 7, 4, 5 }, 16)]
    [InlineData(new int[] { 10, 20 }, new int[] { 2, 3, 1, 2, 5, 8, 4, 3 }, 23)]
    public void MinProcessingTime(int[] processorTime, int[] tasks, int expected)
    {
        var actual = MinProcessingTimeClass.MinProcessingTime(processorTime.ToList(), tasks.ToList());
        Assert.Equal(expected, actual);
    }
}
