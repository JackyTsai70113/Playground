using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3425_LongestSpecialPathTest
{
    [Theory]
    [InlineData("[[0,1,2],[1,2,3],[1,3,5],[1,4,4],[2,5,6]]", new int[] { 2, 1, 2, 1, 3, 1 }, new int[] { 6, 2 })]
    [InlineData("[[1,0,8]]", new int[] { 2, 2 }, new int[] { 0, 1 })]
    [InlineData("[[1,0,7],[1,2,4]]", new int[] { 1, 1, 3 }, new int[] { 4, 2 })]
    [InlineData("[[3,0,3],[1,3,6],[3,2,10]]", new int[] { 1, 5, 4, 1 }, new int[] { 10, 2 })]
    public void LongestSpecialPath(string edges, int[] nums, int[] expected)
    {
        var actual = _3425_LongestSpecialPath.LongestSpecialPath(edges.To2dArr(), nums);
        Assert.Equal(expected, actual);
    }
}
