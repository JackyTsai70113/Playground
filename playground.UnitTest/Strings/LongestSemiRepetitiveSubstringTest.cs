using playground.Strings;

namespace playground.UnitTest.Strings;

public class LongestSemiRepetitiveSubstringTest
{
    [Theory]
    [InlineData("52233", 4)]
    [InlineData("5494", 4)]
    [InlineData("111111", 2)]
    public void LongestSemiRepetitiveSubstring(string s, int expected)
    {
        var actual = LongestSemiRepetitiveSubstringClass.LongestSemiRepetitiveSubstring(s);
        Assert.Equal(expected, actual);
    }
}
