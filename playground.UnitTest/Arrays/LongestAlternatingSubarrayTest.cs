using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class LongestAlternatingSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 5, 4 }, 5, 3)]
    [InlineData(new int[] { 1, 2 }, 2, 1)]
    [InlineData(new int[] { 2, 3, 4, 5 }, 4, 3)]
    public void LongestAlternatingSubarray(int[] nums, int threshold, int expected)
    {
        var actual = LongestAlternatingSubarrayClass.LongestAlternatingSubarray(nums, threshold);
        Assert.Equal(expected, actual);
    }
}
