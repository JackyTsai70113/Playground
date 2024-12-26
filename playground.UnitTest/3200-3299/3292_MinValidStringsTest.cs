using playground._3200_3299;

namespace playground.UnitTest._3200_3299;

public class _3292_MinValidStringsTest
{
    [Theory]
    [InlineData(new string[] { "abc", "aaaaa", "bcdef" }, "aabcdabc", 3)]
    [InlineData(new string[] { "abababab", "ab" }, "ababaababa", 2)]
    [InlineData(new string[] { "abcdef" }, "xyz", -1)]
    public void MinValidStrings(string[] words, string target, int expected)
    {
        var actual = _3292_MinValidStrings.MinValidStrings(words, target);
        Assert.Equal(expected, actual);
    }
}
