using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3362_MaxRemovalTest
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2 }, "[[0,2],[0,2],[1,1]]", 1)]
    [InlineData(new int[] { 1, 1, 1, 1 }, "[[1,3],[0,2],[1,3],[1,2]]", 2)]
    [InlineData(new int[] { 1, 2, 3, 4 }, "[[0,3]]", -1)]
    [InlineData(new int[] { 4, 3, 2, 1 }, "[[1,3],[0,2]]", -1)]
    [InlineData(new int[] { 1, 0, 1 }, "[[0,0],[1,1],[2,2]]", 1)]
    public void MaxRemoval(int[] nums, string queries, int expected)
    {
        var actual = _3362_MaxRemoval.MaxRemoval(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
