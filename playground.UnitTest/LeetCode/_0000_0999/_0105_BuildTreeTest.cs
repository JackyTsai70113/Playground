using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0105_BuildTreeTest
{
    [Theory]
    [InlineData("[3,9,20,15,7]", "[9,3,15,20,7]", "[3,9,20,null,null,15,7]")]
    [InlineData("[-1]", "[-1]", "[-1]")]
    public void BuildTree(string preorder, string inorder, string expected)
    {
        var actual = _0105_BuildTree.BuildTree(preorder.ToArr(), inorder.ToArr());
        Assert.Equal(expected, actual.ToString());
    }
}
