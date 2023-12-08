namespace playground.UnitTest;

public class Tree2strTest_0606
{
    [Theory]
    [InlineData("[1,2,3,4]", "1(2(4))(3)")]
    [InlineData("[1,2,3,null,4]", "1(2()(4))(3)")]
    public void Tree2str(string root, string expected)
    {
        var actual = Tree2str_0606.Tree2str(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
