namespace playground.UnitTest;

public class _1754_LargestMergeTest
{
    [Theory]
    [InlineData("cabaa", "bcaaa", "cbcabaaaaa")]
    [InlineData("abcabc", "abdcaba", "abdcabcabcaba")]
    [InlineData("aac", "aab", "aacaab")]
    [InlineData("aa", "aab", "aabaa")]
    [InlineData("aa", "bb", "bbaa")]
    [InlineData("aac", "aa", "aacaa")]
    [InlineData("qe", "qqe", "qqqee")]
    public void LargestMerge(string s1, string s2, string expected)
    {
        var actual = _1754_LargestMerge.LargestMerge(s1, s2);
        Assert.Equal(expected, actual);
    }
}
