using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2736_MaximumSumQueriesTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] {
            new[] { 4, 3, 3, 1, 2 },
            new[] { 2, 3, 4, 9, 5 },
            new int[][] {
                new[] { 4, 1 },
                new[] { 1, 3 },
                new[] { 2, 5 } },
            new int[] { 6, 10, 7 } };
        yield return new object[] {
            new int[] { 3, 2, 5 },
            new int[] { 2, 3, 4 },
            new int[][] {
                new[] { 4, 4 },
                new[] { 3, 2 },
                new[] { 1, 1 } },
            new int[] { 9, 9, 9 } };
        yield return new object[] {
            new int[] { 2, 1 },
            new int[] { 2, 3 },
            new int[][]{ new[] { 3, 3 } },
            new int[] { -1 } };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public static void MaximumSumQueries(
        int[] nums1,
        int[] nums2,
        int[][] queries,
        int[] expected)
    {
        var actual = _2736_MaximumSumQueries.MaximumSumQueries(nums1, nums2, queries);
        Assert.Equal(expected, actual);
    }
}
