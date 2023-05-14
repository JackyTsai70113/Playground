using playground.Greedy;

namespace playground.UnitTest.DirectedGraph;

public class KSimilarityTest
{
    [Theory]
    [InlineData("ab", "ca", -1)]
    // [InlineData("ab", "ba", 1)]
    // [InlineData("abc", "bca", 2)]
    // [InlineData("abccaacceecdeea", "bcaacceeccdeaae", 9)]
    public void KSimilarity(string s1, string s2, int expected)
    {
        var actual = KSimilarityClass.KSimilarity(s1, s2);
        Assert.Equal(expected, actual);
    }
}
