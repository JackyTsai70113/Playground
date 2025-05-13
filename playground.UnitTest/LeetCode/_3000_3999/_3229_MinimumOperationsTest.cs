namespace playground.UnitTest.LeetCode._3000_3999;

public class _3229_MinimumOperationsTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 3, 4 }, new int[] { 4, 1, 3, 2 }, 5)]
    [InlineData(new int[] { 3, 5, 1, 2 }, new int[] { 4, 6, 2, 4 }, 2)]
    [InlineData(new int[] { 4, 6, 2, 4 }, new int[] { 3, 5, 1, 2 }, 2)]
    [InlineData(new int[] { 1, 3, 2 }, new int[] { 2, 1, 4 }, 5)]
    [InlineData(new int[] { 5, 9, 2, 2 }, new int[] { 7, 9, 3, 8 }, 8)]
    public void MinimumOperations(int[] nums, int[] target, int expected)
    {
        var actual = new _3229_MinimumOperations().MinimumOperations(nums, target);
        Assert.Equal(expected, actual);
    }
}
