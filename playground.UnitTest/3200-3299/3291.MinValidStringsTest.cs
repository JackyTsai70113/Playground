namespace playground.UnitTest;

public class MinValidStringsTest3291
{
    [Theory]
    [InlineData(new string[] { "abc", "aaaaa", "bcdef" }, "aabcdabc", 3)]
    [InlineData(new string[] { "abababab", "ab" }, "ababaababa", 2)]
    [InlineData(new string[] { "abcdef" }, "xyz", -1)]
    public void MinValidStrings(string[] words, string target, int expected)
    {
        var actual = MinValidStrings3291.MinValidStrings(words, target);
        Assert.Equal(expected, actual);
    }
}
