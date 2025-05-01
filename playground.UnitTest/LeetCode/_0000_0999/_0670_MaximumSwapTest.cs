using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0670_MaximumSwapTest
{
    [Theory]
    [InlineData(2736, 7236)]
    [InlineData(98638, 98836)]
    [InlineData(1992, 9912)]
    [InlineData(19931227, 99131227)]

    public void MaximumSwap(int num, int expected)
    {
        var actual = _0670_MaximumSwap.MaximumSwap(num);
        Assert.Equal(expected, actual);
    }
}
