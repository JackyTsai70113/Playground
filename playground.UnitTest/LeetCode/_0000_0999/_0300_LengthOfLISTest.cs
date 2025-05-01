using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0300_LengthOfLISTest
{
    [Theory]
    [InlineData("[10,9,2,5,3,7,101,18]", 4)]
    [InlineData("[0,1,0,3,2,3]", 4)]
    [InlineData("[7,7,7,7,7,7,7]", 1)]
    public void MaxSlidingWindow(string nums, int expected)
    {
        var actual = _0300_LengthOfLIS.LengthOfLIS(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
