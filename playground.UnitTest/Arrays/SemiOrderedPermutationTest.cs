using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class SemiOrderedPermutationTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4, 3 }, 2)]
    [InlineData(new int[] { 2, 4, 1, 3 }, 3)]
    [InlineData(new int[] { 1, 3, 2, 4 }, 0)]
    public void SemiOrderedPermutation(int[] nums, long expected)
    {
        var actual = SemiOrderedPermutationClass.SemiOrderedPermutation(nums);
        Assert.Equal(expected, actual);
    }
}
