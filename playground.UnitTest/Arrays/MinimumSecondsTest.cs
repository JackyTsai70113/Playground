using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MinimumSecondsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 2 }, 1)]
    [InlineData(new int[] { 2, 1, 3, 3, 2 }, 2)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 1 }, 3)]
    public void MinimumSeconds(int[] nums, int expected)
    {
        var actual = MinimumSecondsClass.MinimumSeconds(nums);
        Assert.Equal(expected, actual);
    }
}
