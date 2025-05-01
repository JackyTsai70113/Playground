using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0860_LemonadeChangeTest
{
    [Theory]
    [InlineData(new int[] { 5, 5, 5, 20 }, true)]
    [InlineData(new int[] { 10, 5, 5, 10, 20 }, false)]
    [InlineData(new int[] { 5, 5, 5, 10, 20 }, true)]
    [InlineData(new int[] { 5, 5, 10, 10, 20 }, false)]
    public void MinFlips(int[] bills, bool expected)
    {
        var actual = _0860_LemonadeChange.LemonadeChange(bills);
        Assert.Equal(expected, actual);
    }
}
