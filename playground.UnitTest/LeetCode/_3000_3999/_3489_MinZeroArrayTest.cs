using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3489_MinZeroArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2 }, "[[0,2,1],[0,2,1],[1,1,3]]", 2)]
    [InlineData(new int[] { 4, 3, 2, 1 }, "[[1,3,2],[0,2,1]]", -1)]
    [InlineData(new int[] { 1, 2, 3, 2, 1 }, "[[0,1,1],[1,2,1],[2,3,2],[3,4,1],[4,4,1]]", 4)]
    [InlineData(new int[] { 1, 2, 3, 2, 6 }, "[[0,1,1],[0,2,1],[1,4,2],[4,4,4],[3,4,1],[4,4,5]]", 4)]
    [InlineData(new int[] { 0, 0, 0 }, "[[0,2,1],[0,2,1],[1,1,3]]", 0)]
    public void MinZeroArray(int[] nums, string queries, int expected)
    {
        var actual = _3489_MinZeroArray.MinZeroArray(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
