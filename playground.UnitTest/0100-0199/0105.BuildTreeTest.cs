namespace playground.UnitTest;

public class BuildTreeTest_0105
{
    [Theory]
    [InlineData("[3,9,20,15,7]", "[9,3,15,20,7]", "[3,9,20,null,null,15,7]")]
    [InlineData("[-1]", "[-1]", "[-1]")]
    public void BuildTree(string preorder, string inorder, string expected)
    {
        var actual = BuildTree_0105.BuildTree(preorder.ToArr(), inorder.ToArr());
        Assert.Equal(expected, actual.ToString());
    }
}
