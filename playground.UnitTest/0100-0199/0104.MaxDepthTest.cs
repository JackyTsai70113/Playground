namespace playground.UnitTest;

public class MaxDepthTest104
{
    [Theory]
    [InlineData("[3,9,20,null,null,15,7]", 3)]
    [InlineData("[1,null,2]", 2)]
    public void MaxDepth(string root, int expected)
    {
        var actual = MaxDepth104.MaxDepth(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
