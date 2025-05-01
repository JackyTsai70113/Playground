using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0230_KthSmallestTest
{
    [Theory]
    [InlineData("[3,1,4,null,2]", 1, 1)]
    [InlineData("[5,3,7,2,4,6,null,1]", 3, 3)]
    [InlineData("[5,3,7,2,4,6,null,1]", 6, 6)]
    public void KthSmallest(string nums, int k, int expected)
    {
        var actual = _0230_KthSmallest.KthSmallest(nums.ToTreeNode(), k);
        Assert.Equal(expected, actual);
    }
}
