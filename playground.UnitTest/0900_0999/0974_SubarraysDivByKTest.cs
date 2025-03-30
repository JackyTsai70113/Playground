using playground._0900_0999;

namespace playground.UnitTest._0900_0999;

public class _0974_SubarraysDivByKTest
{
    [Theory]
    [InlineData(new int[] { 4, 5, 0, -2, -3, 1 }, 5, 7)]
    [InlineData(new int[] { 5 }, 9, 0)]
    public static void DistributeCoins(int[] nums, int k, int expected)
    {
        var actual = _0974_SubarraysDivByK.SubarraysDivByK(nums, k);
        Assert.Equal(expected, actual);
    }
}
