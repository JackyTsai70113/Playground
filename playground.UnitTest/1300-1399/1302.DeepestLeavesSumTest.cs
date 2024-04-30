namespace playground.UnitTest;

public class DeepestLeavesSumTest1302
{
    [Theory]
    [InlineData("[1,2,3,4,5,null,6,7,null,null,null,null,8]", 15)]
    [InlineData("[6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]", 19)]
    public void DeepestLeavesSum(string root, int expected)
    {
        var actual = DeepestLeavesSum1302.DeepestLeavesSum(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
