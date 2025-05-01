using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2506_SimilarPairsTest
{
    [Theory]
    [InlineData(new string[] { "aba", "aabb", "abcd", "bac", "aabc" }, 2)]
    [InlineData(new string[] { "aabb", "ab", "ba" }, 3)]
    [InlineData(new string[] { "nba", "cba", "dba" }, 0)]
    public void SimilarPairs(string[] words, int expected)
    {
        var actual = _2506_SimilarPairs.SimilarPairs(words);
        Assert.Equal(expected, actual);
    }
}
