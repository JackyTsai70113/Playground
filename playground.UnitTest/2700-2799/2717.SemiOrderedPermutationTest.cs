namespace playground.UnitTest;

public class SemiOrderedPermutationTest2717
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4, 3 }, 2)]
    [InlineData(new int[] { 2, 4, 1, 3 }, 3)]
    [InlineData(new int[] { 1, 3, 4, 2, 5 }, 0)]
    public void SemiOrderedPermutation(int[] nums, int expected)
    {
        var actual = SemiOrderedPermutation2717.SemiOrderedPermutation(nums);
        Assert.Equal(expected, actual);
    }
}
