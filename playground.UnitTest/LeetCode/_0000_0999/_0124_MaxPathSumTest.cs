using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0124_MaxPathSumTest
{
    [Theory]
    [InlineData("[1,2,3]", 6)]
    [InlineData("[-1,-2,-3]", -1)]
    [InlineData("[-10,9,20,null,null,15,7]", 42)]
    public void MaxPathSum(string nums, int expected)
    {
        var actual = _0124_MaxPathSum.MaxPathSum(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
