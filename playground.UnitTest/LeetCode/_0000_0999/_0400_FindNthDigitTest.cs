using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0400_FindNthDigitTest
{
    [Theory]
    [InlineData(3, 3)]
    [InlineData(11, 0)]
    [InlineData(189, 9)]
    [InlineData(190, 1)]
    [InlineData(191, 0)]
    [InlineData(192, 0)]
    [InlineData(2147483647, 2)]
    public void FindNthDigit(int n, int expected)
    {
        var actual = _0400_FindNthDigit.FindNthDigit(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 3)]
    [InlineData(11, 0)]
    [InlineData(189, 9)]
    [InlineData(190, 1)]
    [InlineData(191, 0)]
    [InlineData(192, 0)]
    [InlineData(2147483647, 2)]
    public void FindNthDigit2(int n, int expected)
    {
        var actual = _0400_FindNthDigit.FindNthDigit2(n);
        Assert.Equal(expected, actual);
    }
}
