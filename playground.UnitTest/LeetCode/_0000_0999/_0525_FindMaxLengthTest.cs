using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0525_FindMaxLengthTest
{
    [Theory]
    [InlineData("[0,1]", 2)]
    [InlineData("[1,0,1]", 2)]
    [InlineData("[1,1]", 0)]
    public void KthSmallest(string nums, int expected)
    {
        var actual = _0525_FindMaxLength.FindMaxLength(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
