namespace playground.UnitTest;

public class IsUnivalTreeTest0965
{
    [Theory]
    [InlineData("[1,1,1,1,1,null,1]", true)]
    [InlineData("[2,2,2,5,2]", false)]
    [InlineData("[2,2,2,2,5]", false)]
    public void IsUnivalTree(string root, bool expected)
    {
        var actual = IsUnivalTree0965.IsUnivalTree(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
