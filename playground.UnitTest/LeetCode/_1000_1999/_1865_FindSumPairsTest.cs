using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1865_FindSumPairsTest
{
    [Fact]
    public void Example1Test()
    {
        // 範例 1 的輸入數據
        int[] nums1 = { 1, 1, 2, 2, 2, 3 };
        int[] nums2 = { 1, 4, 5, 2, 5, 4 };

        _1865_FindSumPairs findSumPairs = new(nums1, nums2);

        int result1 = findSumPairs.Count(7);
        Assert.Equal(8, result1);

        findSumPairs.Add(3, 2);

        int result2 = findSumPairs.Count(8);
        Assert.Equal(2, result2);

        int result3 = findSumPairs.Count(4);
        Assert.Equal(1, result3);

        findSumPairs.Add(0, 1);

        findSumPairs.Add(1, 1);

        int result4 = findSumPairs.Count(7);
        Assert.Equal(11, result4);
    }
}
