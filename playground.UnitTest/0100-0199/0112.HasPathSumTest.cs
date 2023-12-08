namespace playground.UnitTest;

public class HasPathSumTest_0112
{
    [Theory]
    [InlineData("[5,4,8,11,null,13,4,7,2,null,null,null,1]", 22, true)]
    [InlineData("[1,2,3]", 5, false)]
    [InlineData("[]", 0, false)]
    public void HasPathSum(string root, int targetSum, bool expected)
    {
        var actual = HasPathSum_0112.HasPathSum(root.ToTreeNode(), targetSum);
        Assert.Equal(expected, actual);
    }
}
