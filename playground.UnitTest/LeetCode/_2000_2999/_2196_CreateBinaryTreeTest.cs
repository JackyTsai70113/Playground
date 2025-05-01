using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2196_CreateBinaryTreeTest
{
    [Theory]
    [InlineData("[[20,15,1],[20,17,0],[50,20,1],[50,80,0],[80,19,1]]", "[50,20,80,15,17,19]")]
    [InlineData("[[1,2,1],[2,3,0],[3,4,1]]", "[1,2,null,null,3,4]")]
    public void CreateBinaryTree(string A, string expected)
    {
        var actual = _2196_CreateBinaryTree.CreateBinaryTree(A.To2dArr());
        Assert.Equal(expected, actual.ToString());
    }
}
