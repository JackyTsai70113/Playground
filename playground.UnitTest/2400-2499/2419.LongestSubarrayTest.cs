namespace playground.UnitTest;

public class LongestSubarrayTest2419
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3, 2, 2 }, 2)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 1)]
    [InlineData(new int[] { 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 96317, 279979 }, 1)]
    public void LongestSubarray(int[] nums, int expected)
    {
        var actual = LongestSubarray2419.LongestSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
