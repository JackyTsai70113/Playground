using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0201_RangeBitwiseAndTest
{
    [Theory]
    [InlineData(5, 7, 4)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2147483647, 0)]
    [InlineData(1073741824, 2147483647, 1073741824)]
    public void RangeBitwiseAnd(int left, int right, int expected)
    {
        var actual = _0201_RangeBitwiseAnd.RangeBitwiseAnd(left, right);
        Assert.Equal(expected, actual);
    }
}
