using System;
using playground._1000_1099;

namespace playground.UnitTest._1000_1099;

public class _1004_LongestOnesTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
    [InlineData(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3, 10)]
    public void LongestOnes(int[] nums, int k, int expected)
    {
        var actual = _1004_LongestOnes.LongestOnes(nums, k);
        Assert.Equal(expected, actual);
    }
}
