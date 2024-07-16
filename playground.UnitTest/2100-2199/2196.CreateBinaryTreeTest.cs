namespace playground.UnitTest;

public class CreateBinaryTreeTest2196
{
    [Theory]
    [InlineData("[[20,15,1],[20,17,0],[50,20,1],[50,80,0],[80,19,1]]", "[50,20,80,15,17,19]")]
    [InlineData("[[1,2,1],[2,3,0],[3,4,1]]", "[1,2,null,null,3,4]")]
    public void CreateBinaryTree(string A, string expected)
    {
        var actual = CreateBinaryTree2196.CreateBinaryTree(A.To2dArr());
        Assert.Equal(expected, actual.ToString());
    }
}
