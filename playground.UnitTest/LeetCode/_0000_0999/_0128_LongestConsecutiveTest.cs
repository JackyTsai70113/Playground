using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0128_LongestConsecutiveTest
{
    [Theory]
    [InlineData("[100,4,200,1,3,2]", 4)]
    [InlineData("[0,3,7,2,5,8,4,6,0,1]", 9)]
    public void LongestConsecutive(string nums, int expected)
    {
        var actual = _0128_LongestConsecutive.LongestConsecutive(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
