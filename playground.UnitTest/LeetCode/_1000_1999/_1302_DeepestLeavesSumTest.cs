namespace playground.UnitTest.LeetCode._1000_1999;

public class _1302_DeepestLeavesSumTest
{
    [Theory]
    [InlineData("[1,2,3,4,5,null,6,7,null,null,null,null,8]", 15)]
    [InlineData("[6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]", 19)]
    public void DeepestLeavesSum(string root, int expected)
    {
        var actual = _1302_DeepestLeavesSum.DeepestLeavesSum(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
