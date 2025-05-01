using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0632_SmallestRangeTest
{
    [Theory]
    [InlineData("[[4,10,15,24,26],[0,9,12,20],[5,18,22,30]]", new int[] { 20, 24 })]
    [InlineData("[[1,2,3],[1,2,3],[1,2,3]]", new int[] { 1, 1 })]
    public void SmallestRange(string nums, int[] expected)
    {
        var actual = _0632_SmallestRange.SmallestRange(nums.To2dArr());
        Assert.Equal(expected, actual);
    }
}
