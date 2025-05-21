using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3356_MinZeroArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2 }, "[[0,2,1],[0,2,1],[1,1,3]]", 2)]
    [InlineData(new int[] { 4, 3, 2, 1 }, "[[1,3,2],[0,2,1]]", -1)]
    [InlineData(new int[] { 0 }, "[[0,0,2],[0,0,4],[0,0,4],[0,0,3],[0,0,5]]", 0)]
    [InlineData(new int[] { 7, 6, 8 }, "[[0,0,2],[0,1,5],[2,2,5],[0,2,4]]", 4)]
    public void MinZeroArray(int[] nums, string queries, int expected)
    {
        var actual = _3356_MinZeroArray.MinZeroArray(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
