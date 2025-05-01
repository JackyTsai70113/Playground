using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0015_ThreeSumTest
{
    [Theory]
    [InlineData("[-1,0,1,2,-1,-4]", "[[-1,-1,2],[-1,0,1]]")]
    [InlineData("[0,1,1]", "[]")]
    [InlineData("[0,0,0]", "[[0,0,0]]")]
    public void ThreeSum(string nums, string expected)
    {
        var actual = _0015_ThreeSum.ThreeSum(nums.ToArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
