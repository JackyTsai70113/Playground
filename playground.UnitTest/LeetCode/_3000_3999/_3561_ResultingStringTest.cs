using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3561_ResultingStringTest
{
    [Theory]
    [InlineData("abc", "c")]
    [InlineData("adcb", "")]
    [InlineData("zadb", "db")]
    public void ResultingString(string s, string expected)
    {
        var result = _3561_ResultingString.ResultingString(s);
        Assert.Equal(expected, result);
    }
}
