namespace playground.UnitTest;

public class LeafSimilarTest0872
{
    [Theory]
    [InlineData("[3,5,1,6,2,9,8,null,null,7,4]", "[3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]", true)]
    [InlineData("[1,2,null,3]", "[1,3]", true)]
    [InlineData("[119,113,null,11,30,43,76,15,60,67,74]", "[11,69,60,115,66,15,60,67,74,null,76]", true)]
    [InlineData("[1,null,2]", "[1]", false)]
    [InlineData("[1]", "[1,null,2]", false)]
    [InlineData("[2,1,3]", "[1]", false)]
    [InlineData("[1]", "[2,1,3]", false)]
    [InlineData("[1]", "[1]", true)]
    public void LeafSimilar(string root1, string root2, bool expected)
    {
        var actual = LeafSimilar0872.LeafSimilar(root1.ToTreeNode(), root2.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
