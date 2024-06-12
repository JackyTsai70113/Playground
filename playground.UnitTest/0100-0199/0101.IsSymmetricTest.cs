namespace playground.UnitTest;

public class IsSymmetricTest0101
{
    [Theory]
    [InlineData("[1,2,2,3,4,4,3]", true)]
    [InlineData("[1,2,2,null,3,null,3]", false)]
    [InlineData("[1,1]", false)]
    [InlineData("[1,null,1]", false)]
    [InlineData("[1,2,1]", false)]
    public void IsSymmetric(string root, bool expected)
    {
        var actual = IsSymmetric0101.IsSymmetric(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
