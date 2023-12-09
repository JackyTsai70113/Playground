namespace playground.UnitTest;

public class InorderTraversalTest_0094
{
    [Theory]
    [InlineData("[1,null,2,3]", "[1,3,2]")]
    [InlineData("[1]", "[1]")]
    [InlineData("[]", "[]")]
    public void InorderTraversal(string root, string expected)
    {
        var actual = InorderTraversal_0094.InorderTraversal(root.ToTreeNode());
        Assert.Equal(expected.ToArr(), actual);
    }
}
