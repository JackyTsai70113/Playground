using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0287_FindDuplicateTest
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
    [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
    [InlineData(new int[] { 3, 3, 3, 3, 3 }, 3)]
    [InlineData(new int[] { 3, 3, 1, 2, 3 }, 3)]
    public void FindDuplicate(int[] nums, int expected)
    {
        var before = nums.ToArray();
        var actual = _0287_FindDuplicate.FindDuplicate(nums);
        Assert.Equal(expected, actual);
        // ensure we don't modify the array after algorithm
        Assert.Equal(nums, before);
    }
}
