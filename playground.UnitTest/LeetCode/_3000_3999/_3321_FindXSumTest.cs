using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3321_FindXSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 2, 3 }, 6, 2, new long[] { 6, 10, 12 })]
    [InlineData(new int[] { 3, 8, 7, 8, 7, 5 }, 2, 2, new long[] { 11, 15, 15, 15, 12 })]
    [InlineData(new int[] { 5, 5, 3, 5, 3 }, 4, 4, new long[] { 18, 16 })]
    public void FindXSum(int[] nums, int k, int x, long[] expected)
    {
        var actual = _3321_FindXSum.FindXSum(nums, k, x);
        Assert.Equal(expected, actual);
    }
}
