using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2717_SemiOrderedPermutationTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4, 3 }, 2)]
    [InlineData(new int[] { 2, 4, 1, 3 }, 3)]
    [InlineData(new int[] { 1, 3, 4, 2, 5 }, 0)]
    public void SemiOrderedPermutation(int[] nums, int expected)
    {
        var actual = _2717_SemiOrderedPermutation.SemiOrderedPermutation(nums);
        Assert.Equal(expected, actual);
    }
}
