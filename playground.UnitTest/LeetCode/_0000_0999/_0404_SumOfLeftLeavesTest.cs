using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0404_SumOfLeftLeavesTest
{
    [Theory]
    [InlineData("[3,9,20,null,null,15,7]", 24)]
    [InlineData("[1]", 0)]
    public void SumOfLeftLeaves(string A, int expected)
    {
        var actual = _0404_SumOfLeftLeaves.SumOfLeftLeaves(A.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
