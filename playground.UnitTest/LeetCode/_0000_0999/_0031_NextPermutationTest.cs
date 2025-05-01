using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0031_NextPermutationTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
    [InlineData(new int[] { 1, 3, 2 }, new int[] { 2, 1, 3 })]
    [InlineData(new int[] { 1, 3, 4, 2 }, new int[] { 1, 4, 2, 3 })]
    [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
    public void NextPermutation(int[] nums, int[] expected)
    {
        _0031_NextPermutation.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }
}
