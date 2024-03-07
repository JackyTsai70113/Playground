namespace playground.UnitTest;

public class KSimilarityTest0854
{
    [Theory]
    [InlineData("ab", "ca", -1)]
    [InlineData("ab", "ba", 1)]
    [InlineData("abc", "bca", 2)]
    [InlineData("abccaacceecdeea", "bcaacceeccdeaae", 9)]
    public void KSimilarity(string s1, string s2, int expected)
    {
        var actual = KSimilarity0854.KSimilarity(s1, s2);
        Assert.Equal(expected, actual);
    }
}
