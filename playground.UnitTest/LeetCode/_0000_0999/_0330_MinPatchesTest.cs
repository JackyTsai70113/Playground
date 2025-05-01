using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0330_MinPatchesTest
{
    [Theory]
    [InlineData("[1,3]", 6, 1)]
    [InlineData("[1,5,10]", 20, 2)]
    [InlineData("[1,2,2]", 5, 0)]
    [InlineData("[1,2,31,33]", 2147483647, 28)]
    public void MinPatches(string nums, int n, int expected)
    {
        var actual = _0330_MinPatches.MinPatches(nums.ToArr(), n);
        Assert.Equal(expected, actual);
    }
}
