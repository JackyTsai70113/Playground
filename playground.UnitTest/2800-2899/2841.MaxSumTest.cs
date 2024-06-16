namespace playground.UnitTest;

public class MaxSumTest2841
{
    [Theory]
    [InlineData(new int[] { 2, 6, 7, 3, 1, 7 }, 3, 4, 18)]
    [InlineData(new int[] { 5, 9, 9, 2, 4, 5, 4 }, 1, 3, 23)]
    [InlineData(new int[] { 1, 2, 1, 2, 1, 2, 1 }, 3, 3, 0)]
    public void MaxSum(int[] nums, int m, int k, int expected)
    {
        var actual = MaxSum2841.MaxSum(nums, m, k);

        Assert.Equal(expected, actual);
    }
}
