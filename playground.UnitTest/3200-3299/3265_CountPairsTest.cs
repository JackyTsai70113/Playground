using System;
using playground._3200_3299;

namespace playground.UnitTest._3200_3299;

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
