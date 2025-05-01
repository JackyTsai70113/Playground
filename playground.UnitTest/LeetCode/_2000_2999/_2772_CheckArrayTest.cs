using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2772_CheckArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3, 1, 1, 0 }, 3, true)]
    [InlineData(new int[] { 1, 3, 1, 1 }, 2, false)]
    [InlineData(new int[] { 1 }, 2, false)]
    public void CheckArray(int[] nums, int k, bool expected)
    {
        var actual = _2772_CheckArray.CheckArray(nums, k);
        Assert.Equal(expected, actual);
    }
}
