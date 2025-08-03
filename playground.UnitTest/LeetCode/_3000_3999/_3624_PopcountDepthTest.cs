using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3624_PopcountDepthTest
{
    [Theory]
    [InlineData("[2,4]", "[[1,0,1,1],[2,1,1],[1,0,1,0]]", new int[] { 2, 1 })]
    [InlineData("[3,5,6]", "[[1,0,2,2],[2,1,4],[1,1,2,1],[1,0,1,0]]", new int[] { 3, 1, 0 })]
    [InlineData("[1,2]", "[[1,0,1,1],[2,0,3],[1,0,0,1],[1,0,0,2]]", new int[] { 1, 0, 1 })]
    public void PopcountDepth(string numsStr, string queriesStr, int[] expected)
    {
        var nums = numsStr.ToArr<long>();
        var queries = queriesStr.To2dArr<long>();
        var actual = _3624_PopcountDepth.PopcountDepth(nums, queries);
        Assert.Equal(expected, actual);
    }
}