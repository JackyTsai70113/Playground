namespace playground.UnitTest;

public class FindPermutationTest3149
{
    [Theory]
    [InlineData(new int[] { 0, 1 }, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 0 }, new int[] { 0, 1 })]
    [InlineData(new int[] { 1, 0, 2 }, new int[] { 0, 1, 2 })]
    [InlineData(new int[] { 0, 2, 1 }, new int[] { 0, 2, 1 })]
    [InlineData(new int[] { 1, 4, 8, 7, 6, 10, 3, 5, 11, 9, 0, 2 }, new int[] { 0, 10, 2, 11, 8, 9, 5, 7, 3, 6, 4, 1 })]
    public static void FindPermutation(int[] nums, int[] expected)
    {
        var actual = FindPermutation3149.FindPermutation(nums);
        Assert.Equal(expected, actual);
    }
}
