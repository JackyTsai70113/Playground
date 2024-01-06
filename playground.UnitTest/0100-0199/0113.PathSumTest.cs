namespace playground.UnitTest;

public class PathSumTest0113
{
    [Theory]
    [InlineData("[5,4,8,11,null,13,4,7,2,null,null,5,1]", 22, "[[5,4,11,2],[5,8,4,5]]")]
    [InlineData("[1,2,3]", 5, "[]")]
    [InlineData("[1,2]", 0, "[]")]
    public void PathSum(string root, int targetSum, string expected)
    {
        var actual = PathSum0113.PathSum(root.ToTreeNode(), targetSum);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
