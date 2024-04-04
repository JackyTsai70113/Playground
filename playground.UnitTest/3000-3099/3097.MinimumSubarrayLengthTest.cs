namespace playground.UnitTest;

public class MinimumSubarrayLengthTest3097
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2, 1)]
    [InlineData(new int[] { 2, 1, 8 }, 10, 3)]
    [InlineData(new int[] { 1, 2 }, 0, 1)]
    [InlineData(new int[] { 1, 2 }, 8, -1)]
    public void MinimumSubarrayLength(int[] nums, int k, int expected)
    {
        var actual = MinimumSubarrayLength3097.MinimumSubarrayLength(nums, k);
        Assert.Equal(expected, actual);
    }
}
