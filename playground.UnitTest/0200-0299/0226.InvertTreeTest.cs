namespace playground.UnitTest;

public class InvertTreeTest0226
{
    [Theory]
    [InlineData("[4,2,7,1,3,6,9]", "[4,7,2,9,6,3,1]")]
    [InlineData("[2,1,3]", "[2,3,1]")]
    [InlineData("[]", "[]")]
    public void InvertTree(string root, string expected)
    {
        var actual = InvertTree0226.InvertTree(root.ToTreeNode());
        if (actual == null)
            Assert.Equal(expected.ToTreeNode(), actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
