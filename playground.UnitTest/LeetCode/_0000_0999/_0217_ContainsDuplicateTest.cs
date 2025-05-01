using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0217_ContainsDuplicateTest
{
    [Theory]
    [InlineData("[1,2,3,1]", true)]
    [InlineData("[1,2,3,4]", false)]
    [InlineData("[1,1,1,3,3,4,3,2,4,2]", true)]
    public void ContainsDuplicate(string nums, bool expected)
    {
        var actual = _0217_ContainsDuplicate.ContainsDuplicate(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
