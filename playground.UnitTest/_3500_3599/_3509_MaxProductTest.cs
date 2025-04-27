using playground._3500_3599;

namespace playground.UnitTest._3500_3599;

public class _3509_MaxProductTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2, 10, 6)]
    [InlineData(new int[] { 0, 2, 3 }, -5, 12, -1)]
    [InlineData(new int[] { 2, 2, 3, 3 }, 0, 9, 9)]
    [InlineData(new int[] { 10, 10, 9, 0 }, 1, 20, 0)]
    [InlineData(new int[] { 4, 9, 12, 0 }, 7, 30, 0)]
    [InlineData(new int[] { 7, 8, 12, 2, 9, 0, 5, 12, 10, 1, 11, 9, 5, 9, 7, 12, 12, 12, 6, 7, 5, 7, 9, 2, 7, 7, 11, 8, 9, 1, 6, 12, 11, 6, 1, 4, 2, 6, 5, 4 }, 15, 100, 100)]
    public void MaxProduct(int[] nums, int k, int limit, int expected)
    {
        var actual = _3509_MaxProduct.MaxProduct(nums, k, limit);
        Assert.Equal(expected, actual);
    }
}
