namespace playground.UnitTest.LeetCode._3000_3999;

public class _3107_MinOperationsToMakeMedianKTest
{
    [Theory]
    [InlineData(new int[] { 2, 5, 6, 8, 5 }, 4, 2)]
    [InlineData(new int[] { 2, 5, 6, 8, 5 }, 7, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 4, 0)]
    public void MinOperationsToMakeMedianK(int[] nums, int k, long expected)
    {
        var actual = _3107_MinOperationsToMakeMedianK.MinOperationsToMakeMedianK(nums, k);
        Assert.Equal(expected, actual);
    }
}
