namespace playground.UnitTest;

public class BstToGstTest1038
{
    [Theory]
    [InlineData("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]", "[30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]")]
    [InlineData("[0,null,1]", "[1,null,1]")]
    public void BstToGst(string root, string expected)
    {
        var actual = new BstToGst1038().BstToGst(root.ToTreeNode());
        Assert.Equal(expected, actual.ToString());
    }
}
