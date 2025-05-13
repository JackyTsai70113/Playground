using System;
using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3265_CountPairsTest
{
    [Theory]
    [InlineData(new int[] { 21, 12, 30, 17, 3 }, 2)]
    [InlineData(new int[] { 3, 12, 30, 17, 21 }, 2)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10)]
    [InlineData(new int[] { 123, 231 }, 0)]
    public void CountPairs(int[] nums, int expected)
    {
        var actual = _3265_CountPairs.CountPairs(nums);
        Assert.Equal(expected, actual);
    }
}
