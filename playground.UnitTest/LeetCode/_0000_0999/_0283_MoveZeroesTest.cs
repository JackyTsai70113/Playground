using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0283_MoveZeroesTest
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 }, new[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 })]
    public void MoveZeroes(int[] nums, int[] expected)
    {
        _0283_MoveZeroes.MoveZeroes(nums);
        Assert.Equal(expected, nums);
    }
}
