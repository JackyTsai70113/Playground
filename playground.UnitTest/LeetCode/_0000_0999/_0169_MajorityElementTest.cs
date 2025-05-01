using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0169_MajorityElementTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3 }, 2)]
    [InlineData(new int[] { 2, 3, 2 }, 2)]
    [InlineData(new int[] { 3, 2, 2 }, 2)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 1, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 1, 2, 1 }, 1)]
    [InlineData(new int[] { 1, 2, 1, 2, 1, 2, 2, 2 }, 2)]
    [InlineData(new int[] { 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345, 543, 345 }, 345)]
    public void MajorityElement(int[] nums, int expected)
    {
        var actual = _0169_MajorityElement.MajorityElement(nums);
        Assert.Equal(expected, actual);
    }
}
