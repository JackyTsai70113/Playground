namespace playground.UnitTest;

public class IsSameTreeTest0100
{
    [Theory]
    [InlineData("[1,2,3]", "[1,2,3]", true)]
    [InlineData("[1,2]", "[1,null,2]", false)]
    [InlineData("[1,null,2]", "[1,2]", false)]
    [InlineData("[1,2,1]", "[1,1,2]", false)]
    public void IsSameTree(string p, string q, bool expected)
    {
        var actual = IsSameTree0100.IsSameTree(p.ToTreeNode(), q.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
