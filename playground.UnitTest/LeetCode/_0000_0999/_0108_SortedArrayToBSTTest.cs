using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0108_SortedArrayToBSTTest
{
    [Theory]
    [InlineData(new int[] { -10, -3, 0, 5, 9 }, "[0,-10,5,null,-3,null,9]")]
    [InlineData(new int[] { 1, 3 }, "[1,null,3]")]
    public void SortedArrayToBST(int[] nums, string expected)
    {
        var actual = _0108_SortedArrayToBST.SortedArrayToBST(nums);
        Assert.Equal(expected, actual.ToString());
    }
}
