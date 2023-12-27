namespace playground.UnitTest;

public class GetMinimumDifferenceTest_0530
{
    [Theory]
    [InlineData("[4,2,6,1,3]", 1)]
    [InlineData("[1,0,48,null,null,12,49]", 1)]
    public void MaxPathSum(string nums, int expected)
    {
        var actual = GetMinimumDifference_0530.GetMinimumDifference(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[4,2,6,1,3]", 1)]
    [InlineData("[1,0,48,null,null,12,49]", 1)]
    public void MaxPathSum2(string nums, int expected)
    {
        var actual = GetMinimumDifference_0530.GetMinimumDifference2(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
