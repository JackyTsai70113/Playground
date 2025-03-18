using playground._2400_2499;

namespace playground.UnitTest._2400_2499;

public class _2401_LongestNiceSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 8, 48, 10 }, 3)]
    [InlineData(new int[] { 3, 1, 5, 11, 13 }, 1)]
    public void LongestNiceSubarray(int[] nums, int expected)
    {
        var actual = _2401_LongestNiceSubarray.LongestNiceSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
