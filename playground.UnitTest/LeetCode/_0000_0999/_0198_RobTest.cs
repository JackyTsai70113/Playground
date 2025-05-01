using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0198_RobTest
{
    [Theory]
    [InlineData("[1,2,3,1]", 4)]
    [InlineData("[2,7,9,3,1]", 12)]
    [InlineData("[2,1,1,2]", 4)]
    public void Rob(string nums, int expected)
    {
        var actual = _0198_Rob.Rob(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
