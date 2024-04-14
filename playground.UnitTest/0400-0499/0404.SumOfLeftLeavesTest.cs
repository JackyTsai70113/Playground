namespace playground.UnitTest;

public class SumOfLeftLeavesTest0404
{
    [Theory]
    [InlineData("[3,9,20,null,null,15,7]", 24)]
    [InlineData("[1]", 0)]
    public void SumOfLeftLeaves(string A, int expected)
    {
        var actual = SumOfLeftLeaves0404.SumOfLeftLeaves(A.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
