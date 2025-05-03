using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0464_CanIWinTest
{
    [Theory]
    [InlineData(10, 11, false)]
    [InlineData(10, 0, true)]
    [InlineData(10, 1, true)]
    [InlineData(10, 2, true)]
    [InlineData(10, 3, true)]
    [InlineData(10, 4, true)]
    [InlineData(10, 5, true)]
    [InlineData(10, 6, true)]
    [InlineData(10, 7, true)]
    [InlineData(10, 8, true)]
    [InlineData(10, 9, true)]
    [InlineData(5, 50, false)]
    public void CanIWin(int maxChoosableInteger, int desiredTotal, bool expected)
    {
        var actual = _0464_CanIWin.CanIWin(maxChoosableInteger, desiredTotal);
        Assert.Equal(expected, actual);
    }
}
