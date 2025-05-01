using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2730_LongestSemiRepetitiveSubstringTest
{
    [Theory]
    [InlineData("52233", 4)]
    [InlineData("5494", 4)]
    [InlineData("1111111", 2)]
    public void LongestSemiRepetitiveSubstring(string s, int expected)
    {
        var actual = _2730_LongestSemiRepetitiveSubstring.LongestSemiRepetitiveSubstring(s);
        Assert.Equal(expected, actual);
    }
}