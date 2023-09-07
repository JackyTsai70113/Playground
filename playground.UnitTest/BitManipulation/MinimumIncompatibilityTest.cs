using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class MinimumIncompatibilityTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 4 }, 4, 0)]
    [InlineData(new int[] { 1, 2, 1, 4 }, 2, 4)]
    [InlineData(new int[] { 6, 3, 8, 1, 3, 1, 2, 2 }, 4, 6)]
    [InlineData(new int[] { 5, 3, 3, 6, 3, 3 }, 3, -1)]
    public void MinimumIncompatibility(int[] nums, int k, int expected)
    {
        var actual = MinimumIncompatibilityClass.MinimumIncompatibility(nums, k);
        Assert.Equal(expected, actual);
    }
}
