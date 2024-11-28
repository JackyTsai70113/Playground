using playground._0900_0999;

namespace playground.UnitTest._0900_0999;

public class _0952_LargestComponentSizeTest
{
    [Theory]
    [InlineData(new int[] { 4, 6, 15, 35 }, 4)]
    [InlineData(new int[] { 20, 50, 9, 63 }, 2)]
    [InlineData(new int[] { 2, 3, 6, 7, 4, 12, 21, 39 }, 8)]
    [InlineData(new int[] { 83, 99, 39, 11, 19, 30, 31 }, 4)]
    public void LargestComponentSize(int[] nums, int expected)
    {
        var actual = _0952_LargestComponentSize.LargestComponentSize(nums);
        Assert.Equal(expected, actual);
    }
}
