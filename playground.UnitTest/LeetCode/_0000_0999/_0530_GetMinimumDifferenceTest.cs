using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0530_GetMinimumDifferenceTest
{
    [Theory]
    [InlineData("[4,2,6,1,3]", 1)]
    [InlineData("[1,0,48,null,null,12,49]", 1)]
    public void MaxPathSum(string nums, int expected)
    {
        var actual = _0530_GetMinimumDifference.GetMinimumDifference(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[4,2,6,1,3]", 1)]
    [InlineData("[1,0,48,null,null,12,49]", 1)]
    public void MaxPathSum2(string nums, int expected)
    {
        var actual = _0530_GetMinimumDifference.GetMinimumDifference2(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
