using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class MaximumSumQueriesTest
{
    [Theory]
    [InlineData(new int[] { 4, 3, 3, 1, 2 }, new int[] { 2, 3, 4, 9, 5 }, "[[4,1],[1,3],[2,5]]", new int[] { 6, 10, 7 })]
    [InlineData(new int[] { 3, 2, 5 }, new int[] { 2, 3, 4 }, "[[4,4],[3,2],[1,1]]", new int[] { 9, 9, 9 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 2, 3 }, "[[3,3]]", new int[] { -1 })]
    public static void MaximumSumQueries(int[] nums1, int[] nums2, string queries, int[] expected)
    {
        var actual = MaximumSumQueriesClass.MaximumSumQueries(nums1, nums2, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
