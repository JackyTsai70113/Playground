using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0442_FindDuplicatesTest
{
    [Theory]
    [InlineData(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 2, 3 })]
    [InlineData(new[] { 1, 1, 2 }, new[] { 1 })]
    [InlineData(new[] { 1 }, new int[] { })]
    public void FindDuplicates(int[] nums, int[] expected)
    {
        var before = nums.ToArray();
        var actual = _0442_FindDuplicates.FindDuplicates(nums);
        Assert.Equal(expected, actual);
        // ensure we don't modify the array after algorithm
        Assert.Equal(nums, before);
    }
}
