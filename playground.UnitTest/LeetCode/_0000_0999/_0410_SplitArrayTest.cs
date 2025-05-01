using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0410_SplitArrayTest
{
    [Theory]
    [InlineData("[7,2,5,10,8]", 2, 18)]
    [InlineData("[1,2,3,4,5]", 2, 9)]
    public void SplitArray(string nums, int k, int expected)
    {
        var actual = _0410_SplitArray.SplitArray(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
