using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MaxStrengthTest
{
    [Theory]
    [InlineData(new int[] { 9, 6, 3 }, 162)]
    [InlineData(new int[] { 9, 6, 3, -2 }, 162)]
    [InlineData(new int[] { 9, 6, 3, -1, -2 }, 324)]
    [InlineData(new int[] { 9, 6, 3, -1, -2, -2 }, 648)]
    [InlineData(new int[] { 3, -1, -5, 2, 5, -9 }, 1350)]
    [InlineData(new int[] { -4, -5, -4 }, 20)]
    [InlineData(new int[] { 0, -5, -4 }, 20)]
    [InlineData(new int[] { -4, 0 }, 0)]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { -1 }, -1)]
    [InlineData(new int[] { -3, -1, -4, -6, -4, 8, -1, 3, 9, -3 }, 186624)]
    [InlineData(new int[] { 9, 6, 3, 0 }, 162)]
    public void DistinctDifferenceArray(int[] nums, long expected)
    {
        var actual = MaxStrengthClass.MaxStrength(nums);
        Assert.Equal(expected, actual);
    }
}
