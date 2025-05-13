namespace playground.UnitTest.LeetCode._3000_3999;

public class _3095_MinimumSubarrayLengthTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2, 1)]
    [InlineData(new int[] { 2, 1, 8 }, 10, 3)]
    [InlineData(new int[] { 1, 2 }, 0, 1)]
    [InlineData(new int[] { 1, 2 }, 8, -1)]
    public void MinimumSubarrayLength(int[] nums, int k, int expected)
    {
        var actual = _3095_MinimumSubarrayLength.MinimumSubarrayLength(nums, k);
        Assert.Equal(expected, actual);
    }
}
