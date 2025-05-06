using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3523_MaximumPossibleSizeTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 5, 3, 5 }, 3)]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { 19, 80, 63, 74 }, 2)]
    public void MaximumPossibleSize(int[] nums, int expected)
    {
        var actual = _3523_MaximumPossibleSize.MaximumPossibleSize(nums);
        Assert.Equal(expected, actual);
    }
}
