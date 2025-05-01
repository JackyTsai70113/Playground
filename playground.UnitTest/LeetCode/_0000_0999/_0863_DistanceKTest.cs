using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0863_DistanceKTest
{
    [Theory]
    [InlineData("[3,5,1,6,2,0,8,null,null,7,4]", "[5]", 2, new int[] { 1, 7, 4 })]
    [InlineData("[1]", "[1]", 3, new int[0])]
    public void DistanceK(string root, string target, int k, int[] expected)
    {
        var actual = _0863_DistanceK.DistanceK(root.ToTreeNode(), target.ToTreeNode(), k);
        Assert.Equal(expected, actual);
    }
}
