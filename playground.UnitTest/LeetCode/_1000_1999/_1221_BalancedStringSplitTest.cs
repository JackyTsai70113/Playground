using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1221_BalancedStringSplitTest
{
    [Theory]
    [InlineData("RLRRLLRLRL", 4)]
    [InlineData("RLRRRLLRLL", 2)]
    [InlineData("LLLLRRRR", 1)]
    public void BalancedStringSplit(string s, int expected)
    {
        var actual = _1221_BalancedStringSplit.BalancedStringSplit(s);
        Assert.Equal(expected, actual);
    }
}
