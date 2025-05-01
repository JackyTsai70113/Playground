using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0450_DeleteNodeTest
{
    [Theory]
    [InlineData("[6,2,7,1,5,null,8,null,null,4]", 2, "[6,4,7,1,5,null,8]")]
    [InlineData("[5,3,6,2,4,null,7]", 0, "[5,3,6,2,4,null,7]")]
    [InlineData("[5,3,6,2,4,null,7]", 3, "[5,4,6,2,null,null,7]")]
    [InlineData("[5,3,6,2,4,null,7]", 4, "[5,3,6,2,null,null,7]")]
    [InlineData("[5,3,6,2,4,null,7]", 5, "[6,3,7,2,4]")]
    [InlineData("[5,3,6,2,4,null,7]", 6, "[5,3,7,2,4]")]
    [InlineData("[2]", 2, "[]")]
    [InlineData("[2,1,3]", 1, "[2,null,3]")]
    [InlineData("[3,2,4,1]", 2, "[3,1,4]")]
    [InlineData("[2,1,3,null,null,null,4]", 3, "[2,1,4]")]
    [InlineData("[2,1]", 2, "[1]")]
    [InlineData("[]", 0, "[]")]
    public void DeleteNode(string root, int key, string expected)
    {
        var actual = _0450_DeleteNode.DeleteNode(root.ToTreeNode(), key);
        if (actual == null)
            Assert.Equal(expected.ToTreeNode(), actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}

