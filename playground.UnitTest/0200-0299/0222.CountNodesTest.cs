namespace playground.UnitTest;

public class CountNodesTest_0222
{
    [Theory]
    [InlineData("[1,2,3,4,5,6]", 6)]
    [InlineData("[1]", 1)]
    [InlineData("[]", 0)]
    public void SumNuCountNodesmbers(string root, int expected)
    {
        var actual = CountNodes_0222.CountNodes(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
