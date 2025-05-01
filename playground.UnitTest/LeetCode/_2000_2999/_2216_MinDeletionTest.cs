using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2216_MinDeletionTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 3, 5 }, 1)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, 2)]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 3 }, 3)]
    public void MinDeletion(int[] nums, int expected)
    {
        var actual = _2216_MinDeletion.MinDeletion(nums);
        Assert.Equal(expected, actual);
    }
}
