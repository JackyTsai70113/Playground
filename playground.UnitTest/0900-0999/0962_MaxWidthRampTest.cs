using playground_0900_0999;

namespace playground.UnitTest._0900_0999;

public class _0962_MaxWidthRampTest
{
    [Theory]
    [InlineData(new int[] { 6, 0, 8, 2, 1, 5 }, 4)]
    [InlineData(new int[] { 9, 8, 1, 0, 1, 9, 4, 0, 4, 1 }, 7)]
    public void RemainingMethods(int[] nums, int expected)
    {
        var actual = _0962_MaxWidthRamp.MaxWidthRamp(nums);
        Assert.Equal(expected, actual);
    }
}
