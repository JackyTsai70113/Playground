namespace playground.UnitTest;

public class MaxPathSumTest_0124
{
    [Theory]
    [InlineData("[1,2,3]", 6)]
    [InlineData("[-1,-2,-3]", -1)]
    [InlineData("[-10,9,20,null,null,15,7]", 42)]
    public void MaxPathSum(string nums, int expected)
    {
        var actual = MaxPathSum_0124.MaxPathSum(nums.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
