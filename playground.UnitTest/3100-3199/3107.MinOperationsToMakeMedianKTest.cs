namespace playground.UnitTest;

public class MinOperationsToMakeMedianKTest3107
{
    [Theory]
    [InlineData(new int[] { 2, 5, 6, 8, 5 }, 4, 2)]
    [InlineData(new int[] { 2, 5, 6, 8, 5 }, 7, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 4, 0)]
    public void MinOperationsToMakeMedianK(int[] nums, int k, long expected)
    {
        var actual = MinOperationsToMakeMedianK3107.MinOperationsToMakeMedianK(nums, k);
        Assert.Equal(expected, actual);
    }
}
