namespace playground.UnitTest.LeetCode._3000_3999;

public class _3224_MinChangesTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 2, 4, 3 }, 4, 2)]
    [InlineData(new int[] { 3, 0, 1, 2, 4, 1 }, 4, 2)]
    [InlineData(new int[] { 0, 1, 2, 3, 3, 6, 5, 4 }, 6, 2)]
    [InlineData(new int[] { 18, 10, 14, 18, 17, 2, 11, 5 }, 19, 2)]
    public void MinChanges(int[] nums, int k, int expected)
    {
        var actual = _3224_MinChanges.MinChanges(nums, k);
        Assert.Equal(expected, actual);
    }
}
