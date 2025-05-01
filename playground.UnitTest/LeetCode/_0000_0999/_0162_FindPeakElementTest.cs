using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0162_FindPeakElementTest
{
    [Theory]
    [InlineData("[1,2,3,1]", 2)]
    [InlineData("[1,2,1,3,5,6,4]", 5)]
    [InlineData("[1,2,3,4]", 3)]
    [InlineData("[1,2,3]", 2)]
    [InlineData("[3,2,1]", 0)]
    [InlineData("[4,3,2,1]", 0)]
    [InlineData("[2,1]", 0)]
    public void FindPeakElement(string nums, int expected)
    {
        var actual = _0162_FindPeakElement.FindPeakElement(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
