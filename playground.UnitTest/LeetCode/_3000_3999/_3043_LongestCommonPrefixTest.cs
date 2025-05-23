﻿using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3043_LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new int[] { 1, 10, 100 }, new int[] { 1000 }, 3)]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 4, 4 }, 0)]
    public void MaximumHappinessSum(int[] arr1, int[] arr2, int expected)
    {
        var actual = _3043_LongestCommonPrefix.LongestCommonPrefix(arr1, arr2);
        Assert.Equal(expected, actual);
    }
}
