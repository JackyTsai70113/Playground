using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3318_FindXSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 2, 3 }, 6, 2, new int[] { 6, 10, 12 })]
    [InlineData(new int[] { 3, 8, 7, 8, 7, 5 }, 2, 2, new int[] { 11, 15, 15, 15, 12 })]
    [InlineData(new int[] { 5, 5, 3, 5, 3 }, 4, 4, new int[] { 18, 16 })]
    public void FindXSum(int[] nums, int k, int x, int[] expected)
    {
        var actual = _3318_FindXSum.FindXSum(nums, k, x);
        Assert.Equal(expected, actual);
    }
}
