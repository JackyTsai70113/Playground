using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1234_BalancedStringTest
{
    [Theory]
    [InlineData("QWER", 0)]
    [InlineData("QQWE", 1)]
    [InlineData("QQQW", 2)]
    [InlineData("QQQQ", 3)]
    [InlineData("WWEQERQWQWWRWWERQWEQ", 4)]
    [InlineData("WWQQRRRRQRQQ", 4)]
    public void Test(string s, int expected)
    {
        var result = _1234_BalancedString.BalancedString(s);
        Assert.Equal(expected, result);
    }
}
