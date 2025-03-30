namespace playground.UnitTest;

public class MinCameraCoverTest0968
{
    [Theory]
    [InlineData("[0]", 1)]
    [InlineData("[0,0,null,0,0]", 1)]
    [InlineData("[0,0,null,0,null,0,null,null,0]", 2)]
    [InlineData("[0,null,0,0,null,0,0,null,null,0]", 3)]
    [InlineData("[0,0,null,null,0,0,null,null,0,0]", 2)]
    public void MinCameraCover(string root, int expected)
    {
        var actual = MinCameraCover0968.MinCameraCover(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
