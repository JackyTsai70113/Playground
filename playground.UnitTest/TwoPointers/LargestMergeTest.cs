using playground.TwoPointers;

namespace playground.UnitTest.TwoPointers;

public class LargestMergeTest
{
    [Theory]
    [InlineData("cabaa", "bcaaa", "cbcabaaaaa")]
    [InlineData("abcabc", "abdcaba", "abdcabcabcaba")]
    [InlineData("aac", "aab", "aacaab")]
    [InlineData("aa", "aab", "aabaa")]
    [InlineData("aa", "bb", "bbaa")]
    [InlineData("aac", "aa", "aacaa")]
    [InlineData("qe", "qqe", "qqqee")]
    public void LargestMerge(string word1, string word2, string expected)
    {
        var actual = LargestMergeClass.LargestMerge(word1, word2);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("cabaa", "bcaaa", "cbcabaaaaa")]
    [InlineData("abcabc", "abdcaba", "abdcabcabcaba")]
    [InlineData("aac", "aab", "aacaab")]
    [InlineData("aa", "aab", "aabaa")]
    [InlineData("aa", "bb", "bbaa")]
    [InlineData("aac", "aa", "aacaa")]
    [InlineData("qe", "qqe", "qqqee")]
    public void LargestMerge1(string word1, string word2, string expected)
    {
        var actual = LargestMergeClass.LargestMerge1(word1, word2);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("cabaa", "bcaaa", "cbcabaaaaa")]
    [InlineData("abcabc", "abdcaba", "abdcabcabcaba")]
    [InlineData("aac", "aab", "aacaab")]
    [InlineData("aa", "aab", "aabaa")]
    [InlineData("aa", "bb", "bbaa")]
    [InlineData("aac", "aa", "aacaa")]
    [InlineData("qe", "qqe", "qqqee")]
    public void LargestMerge2(string word1, string word2, string expected)
    {
        var actual = LargestMergeClass.LargestMerge2(word1, word2);
        Assert.Equal(expected, actual);
    }
}
