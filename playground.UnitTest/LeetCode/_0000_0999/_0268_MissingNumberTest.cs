using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0268_MissingNumberTest
{
    [Theory]
    [InlineData(new int[] { 3, 0, 1 }, 2)]
    [InlineData(new int[] { 0, 1 }, 2)]
    [InlineData(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    public void MissingNumber(int[] nums, int expected)
    {
        var actual = _0268_MissingNumber.MissingNumber(nums);
        Assert.Equal(expected, actual);
    }
}
