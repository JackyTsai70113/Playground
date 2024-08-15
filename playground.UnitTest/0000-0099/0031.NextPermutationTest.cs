namespace playground.UnitTest;

public class NextPermutationTest0031
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
    [InlineData(new int[] { 1, 3, 2 }, new int[] { 2, 1, 3 })]
    [InlineData(new int[] { 1, 3, 4, 2 }, new int[] { 1, 4, 2, 3 })]
    [InlineData(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
    public void NextPermutation(int[] nums, int[] expected)
    {
        NextPermutation0031.NextPermutation(nums);
        Assert.Equal(expected, nums);
    }
}
