using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class AlternatingSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 3, 4 }, 4)]
    [InlineData(new int[] { 4, 5, 6 }, 2)]
    public void AlternatingSubarray(int[] nums, int expected)
    {
        var actual = AlternatingSubarrayClass.AlternatingSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
