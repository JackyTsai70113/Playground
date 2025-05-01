using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0854_KSimilarityTest
{
    [Theory]
    [InlineData("ab", "ca", -1)]
    [InlineData("ab", "ba", 1)]
    [InlineData("abc", "bca", 2)]
    [InlineData("abccaacceecdeea", "bcaacceeccdeaae", 9)]
    public void KSimilarity(string s1, string s2, int expected)
    {
        var actual = _0854_KSimilarity.KSimilarity(s1, s2);
        Assert.Equal(expected, actual);
    }
}
