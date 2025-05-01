using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0189_RotateTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new[] { -1, -100, 3, 99 }, 2, new[] { 3, 99, -1, -100 })]
    public void Rotate(int[] nums, int k, int[] expected)
    {
        _0189_Rotate.Rotate(nums, k);
        Assert.Equal(expected, nums);
    }
}
