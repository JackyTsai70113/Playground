using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2756_AlternatingSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 3, 4 }, 4)]
    [InlineData(new int[] { 4, 5, 6 }, 2)]
    [InlineData(new int[] { 21, 9, 5 }, -1)]
    public void AlternatingSubarray(int[] nums, int expected)
    {
        var actual = _2756_AlternatingSubarray.AlternatingSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
