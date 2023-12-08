namespace playground.UnitTest;

public class BuildTreeTest_0106
{
    [Theory]
    [InlineData("[9,3,15,20,7]", "[9,15,7,20,3]", "[3,9,20,null,null,15,7]")]
    [InlineData("[2,1]", "[2,1]", "[1,2]")]
    [InlineData("[-1]", "[-1]", "[-1]")]
    public void BuildTree(string inorder, string postorder, string expected)
    {
        var actual = BuildTree_0106.BuildTree(inorder.ToArr(), postorder.ToArr());
        Assert.Equal(expected, actual.ToString());
    }
}
