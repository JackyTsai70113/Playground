using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0968_MinCameraCoverTest
{
    [Theory]
    [InlineData("[0]", 1)]
    [InlineData("[0,0,null,0,0]", 1)]
    [InlineData("[0,0,null,0,null,0,null,null,0]", 2)]
    [InlineData("[0,null,0,0,null,0,0,null,null,0]", 3)]
    [InlineData("[0,0,null,null,0,0,null,null,0,0]", 2)]
    public void MinCameraCover(string root, int expected)
    {
        var actual = _0968_MinCameraCover.MinCameraCover(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
