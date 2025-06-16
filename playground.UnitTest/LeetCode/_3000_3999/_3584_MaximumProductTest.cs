using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3584_MaximumProductTest
{
    [Theory]
    [InlineData(new[] { -1, 1 }, 2, -1)]
    [InlineData(new[] { -1, -9, 2, 3, -2, -3, 1 }, 1, 81)]
    [InlineData(new[] { 1, 3, -5, 5, 6, -4 }, 3, 20)]
    [InlineData(new[] { 2, -1, 2, -6, 5, 2, -5, 7 }, 2, 35)]
    [InlineData(new[] { 1, 10, 2, 11 }, 2, 110)]
    public void MaximumProduct(int[] nums, int m, long expected)
    {
        var actual = _3584_MaximumProduct.MaximumProduct(nums, m);
        Assert.Equal(expected, actual);
    }
}
