using System;
using playground._2700_2799;

namespace playground.UnitTest._2700_2799;

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